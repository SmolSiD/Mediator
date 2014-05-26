using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Departments
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
        public Empl getEmp(string SName, string Name)
        {
            foreach (Empl emp in list_empl)
            {
                if (emp.ToString().Equals(SName + " " + Name)) return emp;
            }
            return null;
        }
        public void CreateEmpl(string Name, string Sname)
        {
           list_empl.Add(new Empl(Sname,Name));
        }
    }
}
