using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
   public class Message
    {
        public Empl From;
        public Empl To;
        ContentsMes content;
        DateTime date;
        public Message(Empl From,Empl To,ContentsMes content)
        {
            this.From = From;
            this.To = To;
            this.content = content;
            this.date = DateTime.Now;
        }
        public Message(Empl From, Empl To)
        {
            this.From = From;
            this.To = To;
            this.date = DateTime.Now;
        }
        public void setContent(ContentsMes content)
        {
            this.content = content;

        }
    }
}
