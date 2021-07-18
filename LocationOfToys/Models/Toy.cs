using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationOfToys.Models.Enums;

namespace LocationOfToys.Models
{
    public class Toy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ToysCategories ToyCategory { get; set; }

        //constructors
        public Toy()
        {
        }
        public Toy(int id, string name, ToysCategories toyCategory)
        {
            Id = id;
            Name = name;
            ToyCategory = toyCategory;
        }
    }
}
