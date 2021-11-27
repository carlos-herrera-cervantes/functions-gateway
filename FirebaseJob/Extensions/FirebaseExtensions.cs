using System;
using System.Threading.Tasks;
using Firebase.Database;
using Microsoft.Extensions.DependencyInjection;

namespace FirebaseJob.Extensions
{
    public static class FirebaseExtensions
    {
        public static IServiceCollection AddFirebaseClient(this IServiceCollection services)
        {
            var firebaseAuth = new FirebaseOptions
            {
                AuthTokenAsyncFactory = ()
                    => Task.FromResult(Environment.GetEnvironmentVariable("FirebaseAppSecret"))
            };

            services.AddSingleton<FirebaseClient>(_ =>
                new FirebaseClient(Environment.GetEnvironmentVariable("FirebaseDatabase"), firebaseAuth));
            return services;
        }
    }
}