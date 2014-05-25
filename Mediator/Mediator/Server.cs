using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Server
    {
        List<Empl> list;
        List<Message> list_mes;
        public Server()
        {
            this.list = new List<Empl>();
            this.list_mes = new List<Message>();
        }
        public void AddEmpl(Empl obj)
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

        public void SendMessage(Message mes)
        {
            foreach (Empl empl in list)
            {
                if (empl.isTarget(mes)) { empl.AddMessage(mes); break; }
            }
        }
    }
}
