using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationOfToys.Models.Enums;

namespace LocationOfToys.Models
{
    public class Box
    {
        public int Id { get; set; }
        public BoxColours BoxColour { get; set; }
        public string Name { get; set; }
        public ICollection<Toy> Toys { get; set; } = new List<Toy>();

        //constructors
        public Box()
        {
        }
        public Box(int id, BoxColours boxColour, string name)
        {
            Id = id;
            BoxColour = boxColour;
            Name = name;
        }

        //add a toy to the box
        public void AddToysToBox(Toy toy)
        {
            Toys.Add(toy);
        }

        //remove a toy from th box(temporary, later gonna be add in service class)
        public void RemoveToysToBox(Toy toy)
        {
            Toys.Remove(toy);
        }
    }
}
