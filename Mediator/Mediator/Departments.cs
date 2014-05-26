using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Departments
    {
        Company parent;
        string name;
        public List<Empl> list_empl;
        public  Departments(string name)
        {
            //this.parent = parent;
            this.name = name;
            list_empl = new List<Empl>();
        }
        public void AddEmpl(Empl empl)
        {
            list_empl.Add(empl);
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
