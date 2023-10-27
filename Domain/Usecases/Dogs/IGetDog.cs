using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usecases.Dogs
{
    public interface IGetDog
    {
        public Task<IEnumerable<Dog>> GetAllDogs();

    }
}
