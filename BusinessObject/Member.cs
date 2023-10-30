using System.Text;

namespace BusinessObject
{

    [Serializable]
    public class Member : IComparable<Member>
    {               
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? CompanyName { get; set; } = "";
        public string? City { get; set; } = "";
        public string? Country { get; set; } = "";

        public int CompareTo(Member? other)
        {
            if (other == null) return 1;
            return this.ID.CompareTo(other.ID);
        }        
        public void deepCopy(Member obj)
        {            
            ID=obj.ID;
            Name = obj.Name;
            Email = obj.Email;
            Password = obj.Password;
            City = obj.City;
            Country = obj.Country;
        }

        public Member(int iD)
        {
            ID = iD;
        }

        private static Member Decode(string member)
        {
            string[] tokens = member.Split(" # ");
            var result = new Member(int.Parse(tokens[0]));
            result.Name = tokens[1];
            result.Email = tokens[2];
            result.Password = tokens[3];
            result.City = tokens[4];
            result.Country = tokens[5];
            return result;
        }

        public Member() {
            ID = -1;
        }
        public Member(string member)
        {            
            var result = Decode(member);            
            this.deepCopy(result);
        }

        public Member(StreamReader reader)
        {
            if (reader.EndOfStream)
                throw new Exception("End of stream");
            this.deepCopy(Decode(reader.ReadLine()));  
        }

        public string Encode()
        {
            return $"{ID} # " +
                $"{Name} # " +
                $"{Email} # " +
                $"{Password} # " +
                $"{City} # " +
                $"{Country}";
        }      

        public bool AppendToTextFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename,true))
            {
                sw.WriteLine(this.Encode());
                sw.Dispose();
            }            
            return true;
        }       
    }
}