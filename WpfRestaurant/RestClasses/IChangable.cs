using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClasses
{
    public interface IChangable
    {
        void Change(int arg);
        void Add();
        void Delete();
    }
}
