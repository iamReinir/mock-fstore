using BusinessObject;
namespace DataAccess
{
    public interface IMemberRepository
    {
        public bool Create(Member member);
        public Member? Read(int id);         
        public bool Update(Member member);
        public bool Delete(int id);
        public ICollection<Member> GetAll();
        public int UsableID();
    }
}