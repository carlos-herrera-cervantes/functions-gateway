using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseJob.Models;

namespace FirebaseJob.Managers
{
    public interface IManager<T> where T : BaseEntity
    {
         Task CreateManyAsync(IEnumerable<T> documents);
    }
}