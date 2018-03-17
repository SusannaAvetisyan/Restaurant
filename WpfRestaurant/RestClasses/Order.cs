using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    class Order 
    {
        public int ID { get; private set; }
        public int TableNumber { get; set; }
        public string DishName { get; set; }
        public string State { get; set; }
        public int Rating { get; set; }

        public Order() { }

        public Order(int id, int tableNumber, string dishName, string state, int rating)
        {
            ID = id;
            TableNumber = tableNumber;
            DishName = dishName;
            State = state;
            Rating = rating;
        }
        public static void GiveOrder(List<Order> items)
        {
            /*kanchel sp amen orderi hamat vor Order tableum kavelacni
             * items@
             */
        }
        public static void FinishOrder(Order item)
        {
            /*kanchel sp vor kpxi orderi state inprocessic 
             * finished
             */
        }
        public static int Bill(int orderID)
        {
            /*kanchel sp vor khashvi Orderi uteliqneri gumarayin gin@
             */
        }
        public static void Rate(Order item, int rating)
        {
            /*bazayaum trvac orderi koxq@ avelacnum e rating
             */
        }
    }
}
