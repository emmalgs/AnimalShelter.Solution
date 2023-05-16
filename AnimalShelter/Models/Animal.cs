
using System.Collections.Generic;
using System;
using System.Linq;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Date { get; set; }
        public int AnimalId { get; set; }
    }

    public enum AnimalType
    {
        Dog,
        Cat,
        Bird,
        Fish,
        Horse,
        Dragon,
        Squacker,
        Duck
    }
}