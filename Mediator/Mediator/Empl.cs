using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Empl
    {
        string Name;
        string Sname;
        string post;
        List<Message> list_mes;
        Server serv; 
        public Empl(string SName, string Name, string post)
        {
            this.Name = Name;
            this.Sname=SName;
            this.post=post;
            this.list_mes = new List<Message>();
        }
        public void setServer(Server serv)
        {
            this.serv = serv;
        }
        public void AddMessage(Message mes)
        {
            list_mes.Add(mes); 
        }
        public bool isTarget(Message mes)
        {
            if (mes.To.Equals(this)) return true;
            else return false;

        }
        public void SendMessage(Message mes)
        {
            serv.AddMessage(mes);
        }
        public override string ToString()
        {
            return this.Sname+" "+this.Name;
        }
    }
}
