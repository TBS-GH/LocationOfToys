using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationOfToys.Models;
using LocationOfToys.Models.Enums;

namespace LocationOfToys.Data
{
    public class SeedingService
    {
        //injectind DBcontext dependency
        private LocationOfToysContext _context;

        public SeedingService(LocationOfToysContext context)
        {
            _context = context;
        }

        //responsible for seeding my DB
        public void Seed()
        {
            //verifying if exist any data in my DB
            if (_context.Box.Any() || _context.Toy.Any())
            {
                return; //DB has been seeded
            }

            //workflow code first
            //adding new boxes
            Box b1 = new Box(1, BoxColours.green, "Caixa A");
            Box b2 = new Box(2, BoxColours.silver, "Caixa B");
            Box b3 = new Box(3, BoxColours.transparent, "Caixa C");

            //ading toys
            Toy t1 = new Toy(1, "Bone Shaker", ToysCategories.Hotwheels);
            Toy t2 = new Toy(2, "Optimus Prime", ToysCategories.Transformers);
            Toy t3 = new Toy(3, "Bone Shaker", ToysCategories.HotwheelsMonsterTruck);
            Toy t4 = new Toy(4, "Soldado", ToysCategories.Soldier);
            Toy t5 = new Toy(5, "Macinha Azul", ToysCategories.PlayDough);


            _context.AddRange(b1, b2, b3);

            _context.AddRange(t1, t2, t3, t4, t5);

            _context.SaveChanges();
        }
    }
}
