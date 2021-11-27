using System;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using FirebaseJob.Models;
using FirebaseJob.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FirebaseJob
{
    public class FirebaseJob
    {
        private readonly FirebaseClient _firebaseClient;
        private readonly ICustomerPurchaseManager _customerPurchaseManager;

        public FirebaseJob(FirebaseClient firebaseClient, ICustomerPurchaseManager customerPurchaseManager)
            => (_firebaseClient, _customerPurchaseManager) = (firebaseClient, customerPurchaseManager);

        [FunctionName("FirebaseJob")]
        public async Task Run([TimerTrigger("*/10 * * * *")]TimerInfo myTimer, ILogger log)
        {
            var salesPath = Environment.GetEnvironmentVariable("FirebaseSalesEventPath");
            var firebaseSales = await _firebaseClient
                .Child(salesPath)
                .OrderByKey()
                .LimitToFirst(50)
                .OnceAsync<CustomerPurchase>();

            var sales = firebaseSales.Select(firebaseSale => firebaseSale.Object);
            await _customerPurchaseManager.CreateManyAsync(sales);

            var keys = firebaseSales.Select(firebaseSales => firebaseSales.Key);
            var tasks = keys.Select(key => _firebaseClient.Child(salesPath + $"/{key}").DeleteAsync());

            await Task.WhenAll(tasks);
        }
    }
}
