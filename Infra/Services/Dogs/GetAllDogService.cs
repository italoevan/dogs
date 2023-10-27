using Domain.Entities;
using Domain.Services.Dogs;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Services.Dogs
{
    public class GetAllDogService : IGetAllDogService
    {
        private readonly AppDbContext _appDbContext;
        public GetAllDogService(AppDbContext context) => _appDbContext = context;
       

        public async Task<IEnumerable<Dog>> GetAllDogs()
        {
            var result = await _appDbContext.Dog.Include(dog => dog.Breed).ToListAsync();

            return result;
        }
    }
}
