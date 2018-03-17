using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    class Table
    {
        public int Number { get; set; }
        public int WaiterID { get; private set; }
        Table() { }
        Table(int num, int waiterID)
        {
            Number = num;
            WaiterID = waiterID;
        }
    }
}
