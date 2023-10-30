using BusinessObject;
using DataAccess;
using System.Text.Json.Nodes;

namespace MyStoreWinApp
{
    public class AppConfig
    {
        public enum Role
        {
            ADMIN,
            NORMAL,
            UNKNOW
        }
        private string _databaseName;
        private string path = "./appsettings.json";
        private IMemberRepository _memberRepository;
        private List<string> emails = new();
        private List<string> passwords = new();
        public readonly bool valid = true;

        public AppConfig() { }
        public (Role,Member?) Login(string email, string password) {
           for(int i = 0 ; i < emails.Count; i++)
            {
                if (emails[i] == email && passwords[i] == password)                
                    return (Role.ADMIN,null);
                
            }
            foreach(Member mem in _memberRepository.GetAll())
            {
                if (mem.Email == email && mem.Password == password)
                    return (Role.NORMAL, mem);
            }
            return (Role.UNKNOW,null);
        }
        public AppConfig(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
            using (Stream sr = new FileStream(path, FileMode.Open))
            {
                var cre = JsonObject.Parse(sr)?.AsObject()["accounts"];
                if (cre == null)
                {
                    return;
                }
                foreach (var node in cre.AsArray())
                {
                    var currentNode = node.AsObject();
                    var email = currentNode["email"]?.GetValue<String>();
                    var password = currentNode["password"]?.GetValue<String>();
                    if (email != null && password != null)
                    {
                        emails.Add(email);
                        passwords.Add(password);
                    }
                }
                return;
            }
        }
        public string? GetConnectionString()
        {
            using (Stream sr = new FileStream(path, FileMode.Open))
            {
                return JsonObject.Parse(sr)?.AsObject()["connection_string"]?.GetValue<string>();
            }
        }      
    }
}
