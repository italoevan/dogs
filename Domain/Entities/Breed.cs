﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Breed
    {
        public int BreedId { get; set; }
        
        public DateTime Creation { get; set; }

        public string Name { get; set; }
    }
}
