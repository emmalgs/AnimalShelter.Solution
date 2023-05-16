
using System.Collections.Generic;
using System;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateOnly Date { get; set; }
        public int AnimalId { get; set; }
    }
}