using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    class Waiter : PersonBase, IChangable
    {
        public int Salary { get; private set; }
        public bool isRemoved { get; private set; }

        public Waiter()
        { }

        public Waiter(int ID, string name, string surname, int salary, bool isRem)
        {
            Salary = salary;
            isRemoved = isRem;
        }
        public static List<Waiter> GetWaiters()
        {
            /*kashxati sp ev kveradradzni bolor waiternerin
             */
        }
        public void Add()
        {
            /*Waiter tabeli mej kavelacni argn 
             */
        }
        public void Delete()
        {
            /*Waiter tabei mej kjnji argn
             */
        }

        public void Change(int arg)
        {
            throw new NotImplementedException();
        }
    }
}
