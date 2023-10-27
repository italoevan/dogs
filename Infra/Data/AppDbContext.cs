using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Infra.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }


    public DbSet<Dog> Dog { get; set; }
    public DbSet<Breed> Breed { get; set; }

}
