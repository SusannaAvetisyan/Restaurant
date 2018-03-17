using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestClasses
{
    public class PersonBase
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public PersonBase()
        { }

        public PersonBase(int ID, string name, string surname)
        {
            this.ID = ID;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Surname: {1}", Name, Surname);
        }
    }


}
