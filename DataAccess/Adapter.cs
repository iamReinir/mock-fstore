using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Adapter : IMemberRepository
    {
        public IRepository<Member> Core;
        public Adapter(IRepository<Member> x) { Core = x; }
        public bool Create(Member member)
        {
            return Core.Create(member) != null;
        }

        public bool Update(Member member)
        {
            return Core.Save(member);
        }

        public bool Delete(int id)
        {
            return Core.Delete(new Member() { ID=id });

        }

        ICollection<Member> IMemberRepository.GetAll() {
            return Core.Read();
        }
        public Member? Read(int id)
        {
            throw new NotImplementedException();
        }
        public int UsableID()
        {
            throw new NotImplementedException();
        }
    }
}
