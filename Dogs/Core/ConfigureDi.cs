using Domain.Services.Dogs;
using Domain.Usecases.Dogs;
using Infra.Services.Dogs;

namespace Dogs.Core
{
    public static class ConfigureDi
    {

        public static void Configure(IServiceCollection service)
        {
            service.AddTransient<IGetAllDogService,GetAllDogService>();

            service.AddTransient<IGetDog, GetDog>();
        }
    }
}
