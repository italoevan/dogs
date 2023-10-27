using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Dog
{
    [Key]
    public int DogId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Breed Breed { get; set; }

}
