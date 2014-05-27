using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class TextMessage:ContentsMes
    {
        private string text;
        public TextMessage(string text)
        {
            this.text = text;
        }

        public override string toString()
        {
            return  this.text;
        }
    }
}
