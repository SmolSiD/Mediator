using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Server
    {
        List<Company> list;
        List<Message> list_mes;
        public Server()
        {
            this.list = new List<Company>();
            this.list_mes = new List<Message>();
        }
        public void AddCmp(Company obj)
        {
            this.list.Add(obj);
        }
        public void AddMessage(Message mes)
        {
            this.list_mes.Add(mes);
        }
        public void RemoveMessage(Message mes)
        {
            this.list_mes.Remove(mes);
        }
        public void Tic()
        {
            if (list_mes.Count != 0)
            {
                foreach (Message mes in list_mes)
                {
                    if (!mes.isFin) SendMessage(mes);
                }
            }
        }
        public void SendMessage(Message mes)
        {
            foreach (Company cmp in list)
            {
                foreach (Departments depr in cmp.list_dep)
                {
                    foreach (Empl emp in depr.list_empl)
                    {
                        if (emp.isTarget(mes)) { emp.AddMessage(mes); mes.isFin = true; break; }
                    }
                }
            }

        }
    }
}
