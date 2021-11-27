using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseJob.Managers;
using FirebaseJob.Models;

namespace FirebaseJob.Services
{
    public class CustomerPurchaseManager : ICustomerPurchaseManager    
    {
        private readonly IManager<CustomerPurchase> _customerPurchaseManager;

        public CustomerPurchaseManager(IManager<CustomerPurchase> customerPurchaseManager)
            => _customerPurchaseManager = customerPurchaseManager;

        public async Task CreateManyAsync(IEnumerable<CustomerPurchase> sales)
            => await _customerPurchaseManager.CreateManyAsync(sales);
    }
}