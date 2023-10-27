using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Dogs;

public interface IGetAllDogService
{

    public Task<IEnumerable<Dog>> GetAllDogs();

}
