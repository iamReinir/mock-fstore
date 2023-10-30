using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{

    public class MemberRepository : IMemberRepository
    {
        private string _conn_string;
        private IDbConnection _database;
        private int curID = 0;
        private string datafile;
        private SortedSet<Member> _members;

        public int UsableID() { return curID + 1; }
        public MemberRepository(string connection_string)
        {
            _conn_string = connection_string;
            _database = new SqlConnection(_conn_string);             
        }
        public bool Create(Member member)
        {
            IDbTransaction? transact = null;
            try { 
                if(_database.State != ConnectionState.Open)
                    _database.Open();
                transact = _database.BeginTransaction();                
                var cmd = _database.CreateCommand();
                cmd.Transaction = transact;
                cmd.Connection = _database;
                cmd.CommandText = "INSERT INTO dbo.members (name, email, password, city, country, company_name) " +
                    "VALUES (@name, @email, @password, @city, @country, @company_name);";
                cmd.Parameters.Add(Param("@name", member?.Name));
                cmd.Parameters.Add(Param("@email", member?.Email));
                cmd.Parameters.Add(Param("@password", member?.Password));
                cmd.Parameters.Add(Param("@city", member?.City));
                cmd.Parameters.Add(Param("@country", member?.Country));
                cmd.Parameters.Add(Param("@company_name", member?.CompanyName));
                cmd.ExecuteNonQuery();            
                transact.Commit();
                _database.Close();
                return true;
            }
            catch (Exception)
            {
                transact?.Rollback();
                return false;
            }
            finally
            {
                _database.Close();
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

        // Have to check the ID of the line 
        // The datagrid somehow update the value of the inner attribute
        private bool Update_in_file(Member old_mem, Member? new_info)
        {
            string clonefile = "clone.dat";
            bool result = false;
            File.Copy(datafile, clonefile);
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(clonefile);
                writer = new StreamWriter(datafile);
                while (reader.EndOfStream == false)
                {
                    string? line = reader.ReadLine();
                    var curMem = new Member(line);
                    if(curMem.ID == old_mem.ID)
                    {
                        result = true;
                        if (new_info != null) writer.WriteLine(new_info.Encode());
                        continue;
                    }
                    writer.WriteLine(line);
                }
            }
            catch { return false; }
            finally
            {                
                reader?.Dispose();
                writer?.Dispose();
                File.Delete(clonefile);
            }            
            return result;
        }
        public bool Delete(int id)
        {
            try
            {
                _database.Open();
                var transact = _database.BeginTransaction();               
                var cmd = _database.CreateCommand();
                cmd.Transaction = transact;
                cmd.CommandText = "DELETE FROM dbo.members " +
                    "WHERE Id=@id;";
                cmd.Parameters.Add(Param("@id", id));
                cmd.ExecuteNonQuery();
                transact.Commit();
                _database.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _database?.Close();
            }
        }

        public ICollection<Member> GetAll()
        {
            IDataReader? reader = null;
            try
            {
                var result = new List<Member>();
                _database.Open();                
                var cmd = _database.CreateCommand();
                cmd.CommandText = "SELECT id,name, email, password, city, country, company_name FROM dbo.members;";                
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var mem = new Member();
                    mem.ID = reader.GetInt32(0);                    
                    mem.Name = reader.GetString(1).Trim();
                    mem.Email = reader.GetString(2).Trim();
                    mem.Password = reader.GetString(3).Trim();
                    mem.City = reader.GetString(4).Trim();
                    mem.Country = reader.GetString(5).Trim();
                    mem.CompanyName = reader.GetString(6).Trim();                    
                    result.Add(mem);
                }
                reader.Close();
                _database.Close();
                return result;
            }
            catch (Exception)
            {
                return new List<Member>();
            }
            finally
            {
                _database.Close();
                reader?.Close();
            }

        }

        public Member? Read(int id)
        {
            try
            {
                var result = new List<Member>();
                _database.Open();
                var cmd = _database.CreateCommand();
                cmd.CommandText = "SELECT id,name, email, password, city, country, company_name FROM dbo.members " +
                    "WHERE Id=@id;";
                cmd.Parameters.Add(Param("@id", id));
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Member
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1).Trim(),
                        Email = reader.GetString(2).Trim(),
                        Password = reader.GetString(3).Trim(),
                        City = reader.GetString(4).Trim(),
                        Country = reader.GetString(5).Trim(),
                        CompanyName = reader.GetString(6).Trim()
                    });
                }
                _database.Close();
                return result.SingleOrDefault();
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public bool Update(Member? new_info)
        {
            try
            {
                _database.Open();
                var transact = _database.BeginTransaction();
                var cmd = _database.CreateCommand();
                cmd.Transaction = transact;                
                cmd.CommandText = "UPDATE dbo.members " +
                    "SET name=@name, email=@email, password=@password,city=@city,country=@country,company_name=@company_name " +
                    "WHERE Id=@id";
                cmd.Parameters.Add(Param("@name", new_info?.Name));
                cmd.Parameters.Add(Param("@email", new_info?.Email));
                cmd.Parameters.Add(Param("@password", new_info?.Password));
                cmd.Parameters.Add(Param("@city", new_info?.City));
                cmd.Parameters.Add(Param("@country", new_info?.Country));
                cmd.Parameters.Add(Param("@company_name", new_info?.CompanyName));
                cmd.Parameters.Add(Param("@id", new_info?.ID));
                cmd.ExecuteNonQuery();
                transact.Commit();                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _database.Close();
            }
        }
    }
}
