using Domain.Entities;
using Domain.Services.Dogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usecases.Dogs
{
    public class GetDog : IGetDog
    {

        public GetDog(IGetAllDogService service) => _service = service;

        readonly private IGetAllDogService _service;

        public Task<IEnumerable<Dog>> GetAllDogs()
        {
            return _service.GetAllDogs();
        }
    }
}
