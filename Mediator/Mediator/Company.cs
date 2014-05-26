using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Company
    {
        string Name;
        public List<Departments> list_dep;
        public Company(string name)
        {
            this.Name = name;
            list_dep = new List<Departments>();
        }
        public void CreateDepart(string name)
        {
            list_dep.Add(new Departments(name));
        }
        public Departments getDepr(string name)
        {
            foreach (Departments depr in list_dep)
            {
                if (depr.ToString().Equals(name)) return depr;
            }
            return null;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
