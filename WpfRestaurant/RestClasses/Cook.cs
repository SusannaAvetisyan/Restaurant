using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    class Cook : PersonBase, IChangable
    {
        public int Salary { get; private set; }
        private string login;
        private string password;
        public bool isChef { get; private set; }
        public bool isRemoved { get; private set; }

        public Cook()
        { }

        public Cook(int ID, string name, string surname, int salary, string login, string password, bool isCh, bool isRem)
                :base(ID, name, surname)
        {
            Salary = salary;
            this.login = login;
            this.password = password;
            isChef = isCh;
            isRemoved = isRem;
        }

        public void Change(int newSalary)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            /*kavelacni nor xoharar
             */
            throw new NotImplementedException();
        }

        public void Delete()
        {
            /*kjnji xoharar
             */
            throw new NotImplementedException();
        }
    }
}
