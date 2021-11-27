using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseJob.Models;

namespace FirebaseJob.Services
{
    public interface ICustomerPurchaseManager
    {
         Task CreateManyAsync(IEnumerable<CustomerPurchase> sales);
    }
}