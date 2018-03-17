using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    public class Boss : PersonBase
    {
        private string login;
        private string password;

        public Boss()
        { }

        public Boss(int ID, string name, string surname, string log, string pswd) : base(ID, name, surname)
        {
            login = log;
            password = pswd;
        }

        
    }
}
