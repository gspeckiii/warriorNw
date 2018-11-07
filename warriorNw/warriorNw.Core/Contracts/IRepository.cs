using System.Linq;
using warriorNw.Core.Models;

namespace warriorNw.Core.Contacts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void update(T t);
    }
}