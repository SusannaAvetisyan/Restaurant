using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    class Dish : IChangable
    {
        public string Name { get; private set; }
        public int Price { get; set; }
        public bool IsRemoved { get; private set; }
        public int CookID { get; private set; }

        public Dish() { }

        public Dish(string name, int price, bool isRemoved, int cookID)
        {
            Name = name;
            Price = price;
            IsRemoved = isRemoved;
            CookID = cookID;
        }

        public static List<Dish> GetMenu()
        {
            /*open connection 
             * ashxatacnel sp vor selet all from dish funkcia kkatari
             * sargel dishi obyektner u array listi tesqov veradardznel
             */
        }
        public static int GetRating(Dish item)
        {
            /*khashvi orderner axyuskaic amen 
             * uteliqi rating@ 
             */
        }

        public void Change(int price)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
