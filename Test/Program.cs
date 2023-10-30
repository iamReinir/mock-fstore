using BusinessObject;
using MyStoreWinApp;
using DataAccess;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args) {
            Debug.Assert(Foldl_test());
            Debug.Assert(repos_member_test());
            Debug.Assert(Product_repos_test());

        }

        public static bool Foldl_test()
        {
            Console.WriteLine("Foldl Test");
            dynamic expected_result = null;
            dynamic actual_result = null;
            dynamic consumer = null;
            var result = true;
            //Case 0
            var case0 = new int[101];
            for (int i = 0; i <= 100; ++i) case0[i] = i;
            expected_result = 5050;
            consumer = new Func<int,int,int>((item,acc) => acc + item);
            actual_result = Repository<int>.Foldl<int,int>(case0 , consumer,0);
            Console.WriteLine(Log(0,expected_result,actual_result));
            result = result && expected_result == actual_result;
            //Case 1
            var case1 = new string[]
            {
                "this",
                "is",
                "one",
                "test",
                "string"
            };
            expected_result = "this,is,one,test,string";
            actual_result = Repository<string>.Foldl<string, string>(case1, (item, acc) =>
            {
                if (acc != "") acc += ",";
                acc += item;
                return acc;
            }, "");
            Console.WriteLine(Log(1,expected_result,actual_result));           
            result = result && expected_result == actual_result;
            return result;
        }

        static string Log(int tcase, object ex, object ac, string note = "")
        {
            var res = "\n==========================================\n" +
                "Test case #" + tcase + "\n" +
                "Expected result : " + ex + "\n" +
                "Actual result : " + ac + "\n";
            if (ex.Equals(ac))
                res += "PASSED\n";
            else
                res += "FAILED\n";
            if(note != "") res += "Note : " + note;
            return res + "\n==========================================\n";
        }

        static bool repos_member_test()
        {
            Console.WriteLine("Test Repository<Member>\n");
            bool result = true;
            var db = new SqlConnection(new AppConfig().GetConnectionString());
            var memberRepos = RepositoryObjects.GetRepository<Member>(db);
            Member mem = new Member()
            {
                Name = "reinirTest",
                Email = "reinirTest@mail",
                Password = "password",
                Country = "Country",
                CompanyName = "CN",
                City = "City",
            };

            Console.WriteLine("Create Test");
            memberRepos.Create(mem);
            int id = -1;
            foreach (var item in memberRepos.Read())
            {
                if(item .Name == "reinirTest")
                {
                    id = item.ID;
                    mem = item;
                    break;
                }
            }
            result = result && id > -1;
            Console.WriteLine("result:" + result);

            Console.WriteLine("Update Test");
            mem.Name = "ReinirTest22";
            memberRepos.Save(mem);
            id = -1;
            foreach (var item in memberRepos.Read())
            {
                if (item.Name == "ReinirTest22")
                {
                    id = item.ID; 
                    mem = item;
                    break;
                }
            }
            result = result && id != -1 && mem.Name == "ReinirTest22";
            Console.WriteLine("result:" + result);

            Console.WriteLine("Delete Test");
            memberRepos.Delete(mem);
            id = -1;            
            foreach (var item in memberRepos.Read())
            {
                if (item.Name == "reinirTest22")
                {
                    id = item.ID;
                    break;
                }
            }
            result = result && id == -1;
            Console.WriteLine("result:" + result);
            db.Close();
            return result;
        }
        public static bool Product_repos_test()
        {
            Console.WriteLine("Test Repository<Product>\n");
            bool result = true;
            var db = new SqlConnection(new AppConfig().GetConnectionString());
            var product_repos = RepositoryObjects.GetRepository<Product>(db);

            Console.WriteLine("Create Test");
            var prod = new Product()
            {
                Category = "Sweet",
                Name = "CakeTest",
                Unit_instock = 100,
                Unit_price = 96,
                Weight = "300g"
            };
            product_repos.Create(prod);
            int id = -1;
            foreach (var pro in product_repos.Read())
            {
                if (pro.Name == prod.Name)
                {
                    id = pro.ID; 
                    break;
                }
            }
            result = result && id != -1;
            Console.WriteLine(result);

            Console.WriteLine("Update Test");
            prod.Name = "Jimmy";
            prod.ID = id;
            product_repos.Save(prod);
            id = -1;
            foreach (var pro in product_repos.Read())
            {
                if (pro.Name == prod.Name)
                {
                    id = pro.ID; 
                    break;
                }
            }
            result = result && id != -1;
            Console.WriteLine(result);

            Console.WriteLine("Delete Test");
            product_repos.Delete(prod);
            prod = null;
            foreach (var pro in product_repos.Read())
            {
                if (pro.Name == "Jimmy")
                {
                    prod = pro;
                    break;
                }
            }
            result = result && prod == null;
            Console.WriteLine(result);
            db.Close();
            return result;
        }
    }
}