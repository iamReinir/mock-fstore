using BusinessObject;
using DataAccess;
using System.Text.Json.Nodes;

namespace MyStoreWinApp
{
    public class AppConfig
    {                
        private string path = "./appsettings.json";        
        public AppConfig(string? path = null) {
            if (path == null) return;
            this.path = path;
        }                
        public string? GetConnectionString()
        {
            using (Stream sr = new FileStream(path, FileMode.Open))
            {
                return JsonObject.Parse(sr)?.AsObject()["connection_string"]?.GetValue<string>();
            }
        }    
        
        public List<(string,string)> GetAdminAccount()
        {
            List<(string, string)> result = new();
            using (Stream sr = new FileStream(path, FileMode.Open))
            {
                var cre = JsonObject.Parse(sr)?.AsObject()["accounts"];
                if (cre == null)
                {
                    return result;
                }
                foreach (var node in cre.AsArray())
                {
                    var currentNode = node.AsObject();
                    var email = currentNode["email"]?.GetValue<String>();
                    var password = currentNode["password"]?.GetValue<String>();
                    if (email != null && password != null)
                    {
                        result.Add((email, password));
                    }
                }                
            }
            return result;
        }
    }
}
