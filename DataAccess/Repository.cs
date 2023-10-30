using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;
using System.Reflection;
namespace DataAccess
{
    public class Repository<T> : IRepository<T>
    {
        public IDbConnection? Database { get; set; } = null;
        public Func<string, string>? Mapper { get; set; } = null;

        // Create a T object from values in arg0, order is in SelectAttributes
        public Func<object[], T>? Constructor { get; set; } = null;

        // T's attributes that affected by Insert and Update
        public string[]? InsertUpdateAttributes { get; set; } = null;

        // T's attributes used to delete and check for update
        public string[]? EqualAttributes { get; set; } = null;

        // T's attributes that is selected
        public string[]? SelectAttributes { get; set; } = null;

        private IDbCommand? _command = null;
        private IDbTransaction? _transaction = null;

        public event EventHandler<T> OnRepositoryChanged;

        public Repository() {
            if (Mapper == null)
                Mapper = (self) => self;
            var allProps = Map<PropertyInfo, string>(typeof(T).GetProperties(), (prop) => prop.Name);
            InsertUpdateAttributes ??= allProps;
            EqualAttributes ??= allProps;
            SelectAttributes ??= allProps;

            // Do nothing event
            OnRepositoryChanged += (x, y) => { return; };
        }        

        private ICollection<T> Query(Func<IDataReader, ICollection<T>>? query = null)
        {
            IDataReader? reader = null;
            try
            {
                if (Database == null) return new List<T>();
                if (Database.State != ConnectionState.Open) Database.Open();
                _transaction = Database.BeginTransaction();
                _command = Database.CreateCommand();
                _command.Transaction = _transaction;                
                var res = query(reader);             
                _transaction.Commit();
                return res;
            }
            catch (Exception ex)
            {               
                reader?.Close();
                _transaction?.Rollback();
                Database?.Close();
                return new List<T>();
            }
            finally
            {
                reader?.Close();
                Database?.Close();               
            }
        }


        public bool NonQuery(Func<T,bool> action, T item)
        {
            IDbTransaction? transact = null;
            try
            {
                if(Database == null) return false;
                if (Database.State != ConnectionState.Open) Database.Open();
                transact = Database.BeginTransaction();
                _command = Database.CreateCommand();
                _command.Transaction = transact;
                if (!action(item)) throw new Exception("Action failed");
                transact.Commit();
                Database.Close();
                return true;
            }
            catch (Exception)
            {
                transact?.Rollback();
                return false;
            }
            finally
            {
                transact?.Dispose();
                Database?.Close();
            }
        }       

        static private IDbDataParameter Param(string name, object value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value
            };
        }

        public static U[] Map<T,U>(T[] list, Func<T,U> transformation)
        {
            var result = new U[list.Length];
            for (int i = 0; i < list.Length; ++i)
            {
                result[i] = transformation(list[i]);
            }
            return result;
        }

        public static TREsult Foldl<TItem, TREsult>(
            TItem[] list, 
            Func<TItem, TREsult, TREsult> consumer, 
            TREsult staringPoint)
        {
            TREsult? result = staringPoint;
            foreach(var item in list)
            {
                result = consumer(item, result);   
            }
            return result;
        }

        
        private bool Insert(T entity)
        {
            var mapper = Mapper;
            var cmd = _command;
            if (cmd == null) return false; ;
            var props = InsertUpdateAttributes;
            var cols = Map<string, string>(props, mapper);
            var tablename = mapper(entity.GetType().Name);                                             
            cmd.CommandText = InsertQuery(tablename,cols,props);
            foreach (var attr in props)
            {
                cmd.Parameters.Add(Param("@" + attr, entity.GetType().GetProperty(attr).GetValue(entity)));
            }
            cmd.ExecuteNonQuery();
            return true;                       
        }

        private int InsertReturn(T entity)
        {
            IDbTransaction? transact = null;
            try
            {
                if (Database == null) return -1;
                if (Database.State != ConnectionState.Open) Database.Open();
                transact = Database.BeginTransaction();
                _command = Database.CreateCommand();
                _command.Transaction = transact;
                var props = InsertUpdateAttributes;
                var cols = Map<string, string>(props, Mapper);
                var tablename = Mapper(entity.GetType().Name);
                _command.CommandText = InsertQuery(tablename, cols, props);
                foreach (var attr in props)
                {
                    _command.Parameters.Add(Param("@" + attr, entity.GetType().GetProperty(attr).GetValue(entity)));
                }
                var res = _command.ExecuteScalar();
                transact.Commit();
                transact = null;
                Database.Close();
                if (res.GetType() == typeof(DBNull)) return 0;
                return Convert.ToInt32(res);
            }
            catch (Exception)
            {
                transact?.Rollback();
                return -1;
            }
            finally
            {
                transact?.Dispose();
                Database?.Close();
            }
        }

        private List<T>? Select(IDataReader reader, int count = -1)
        {            
            if (Constructor == null) return new List<T>();
            var cmd = _command;
            if (cmd == null) return null;
            var props = Map<string,string>(SelectAttributes,Mapper);
            var table_name = Mapper(typeof(T).Name);
            cmd.CommandText = SelectQuery(table_name, props, count);
            using (reader = cmd.ExecuteReader())
            {
                var result = new List<T>();
                while (reader.Read())
                {
                    var values = new object[SelectAttributes.Length];
                    for (int i = 0; i < values.Length; ++i)
                    {
                        values[i] = reader.GetValue(i);
                    }
                    result.Add(Constructor(values));
                }
                reader.Close();
                return result;
            }
        }

        private bool Update(T entity)
        {
            if (_command == null) return false;
            var table_name = Mapper(typeof(T).Name);
            var eq_cols = Map<string, string>(EqualAttributes, Mapper);
            var update_cols = Map<string,string>(InsertUpdateAttributes, Mapper);
            _command.CommandText = UpdateQuery(table_name,eq_cols, EqualAttributes
                    ,update_cols,InsertUpdateAttributes);
            foreach (string attr in InsertUpdateAttributes)
                _command.Parameters.Add(Param("@" + attr, typeof(T).GetProperty(attr).GetValue(entity)));
            foreach(string attr in EqualAttributes)
                _command.Parameters.Add(Param("@" + attr, typeof(T).GetProperty(attr).GetValue(entity)));
            int x = _command.ExecuteNonQuery();
            return true;
        }

        public bool Remove(T entity)
        {
            if (_command == null) return false;
            var table_name = Mapper(typeof(T).Name);
            var eq_cols = Map<string, string>(EqualAttributes, Mapper);
            _command.CommandText = DeleteQuery(table_name, eq_cols, EqualAttributes);
            foreach(string attr in EqualAttributes)
            {
                _command.Parameters.Add(Param("@" + attr, typeof(T).GetProperty(attr).GetValue(entity)));
            }
            _command.ExecuteNonQuery();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_name"></param>
        /// <param name="cols"> The column names of the table</param>
        /// <param name="parameter_attrs">The attributes of the inserted object. 
        /// Will be put in the SQL query in the form @attr_name for parameterized query</param>
        /// <returns></returns>
        public static string InsertQuery(string table_name, string[] cols, string[] parameter_attrs)
        {
            string mergerd_cols = Foldl<string, string>(cols, (prop, acc) => {
                if (acc != "") acc += ",";
                acc += (prop);
                return acc;
            }, "");
            string obj_props = Foldl<string, string>(parameter_attrs, (prop, acc) =>
            {
                if (acc != "") acc += ",";
                acc += "@" + (prop);
                return acc;
            }, "");
            return $"INSERT INTO {table_name} ({mergerd_cols}) VALUES ({obj_props}) SELECT SCOPE_IDENTITY();";
        }

        public static string DeleteQuery(string table_name, string[] eq_cols, string[] parameter_attrs)
        {
            string condition = "";
            for (int i = 0; i < eq_cols.Length; ++i)
            {
                if (condition != "") condition += " AND ";
                condition += eq_cols[i] + "= @" + parameter_attrs[i]; 
            }
            return $"DELETE FROM {table_name} WHERE {condition}";
        }

        public static string UpdateQuery(
                string table_name, 
                string[] eq_cols, 
                string[] eq_attrs, 
                string[] update_cols, 
                string[] update_attrs)
        {
            string condition = "";
            for (int i = 0; i < eq_cols.Length; ++i)
            {
                if (condition != "") condition += ",";
                condition += eq_cols[i] + "= @" + eq_attrs[i];
            }

            string set = "";
            for (int i = 0; i < update_cols.Length; ++i)
            {
                if (set != "") set += ",";
                set += update_cols[i] + "= @" + update_attrs[i];
            }
            return $"UPDATE {table_name} SET {set} WHERE {condition}";
        }

        public static string SelectQuery(string table_name, string[] cols, int count = -1)
        {
            string mergerd_cols = Foldl<string, string>(cols, (prop, acc) => {
                if (acc != "") acc += ",";
                acc += (prop);
                return acc;
            }, "");
            string result = "SELECT";
            if (count != -1) result += " TOP " + count;
            return result + $" {mergerd_cols} FROM {table_name}";
        }    
        bool IRepository<T>.Save(T entity)
        {            
            var res = NonQuery((entity) => Update(entity),entity);
            OnRepositoryChanged(this, entity);
            return res;
        }
        T IRepository<T>.Create(T entity)
        {

            /* var res =  NonQuery((entity) => {
                return this.Insert(entity); 
            }, entity);
            */
            var res = InsertReturn(entity);
            typeof(T).GetProperty(EqualAttributes[0]).SetMethod.Invoke(entity, new[] { (object)res });
            OnRepositoryChanged(this, entity);            
            return entity;
        }

        ICollection<T> IRepository<T>.Read(int count = -1)
        {
            return Query((datareader) => Select(datareader, count));
        }
        bool IRepository<T>.Delete(T entity)
        {            
            var res =  NonQuery((e) => Remove(e), entity);
            OnRepositoryChanged(this, entity);
            return res;
        }

        public TResult Foldl<TResult>(Func<T, TResult?, TResult?> accumulator, 
            TResult? start)
        {
            TResult result = start;
            IDataReader reader = null;
            try
            {
                Database.Open();
                _command = Database.CreateCommand();
                var props = Map<string, string>(SelectAttributes, Mapper);
                var table_name = Mapper(typeof(T).Name);
                _command.CommandText = SelectQuery(table_name, props, -1);
                reader = _command.ExecuteReader();                
                while (reader.Read())
                {
                    var values = new object[SelectAttributes.Length];
                    for (int i = 0; i < values.Length; ++i)
                    {
                        values[i] = reader.GetValue(i);
                    }
                    var obj = Constructor(values);
                    result = accumulator(obj, result);
                }
                
            }
            finally
            {
                reader?.Close();
                Database.Close();
            }
            return result;
        }
    }
}
