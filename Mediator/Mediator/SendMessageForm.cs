using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mediator
{
    public partial class SendMessageForm : Form
    {
        string Name;
        string Sname;
        public SendMessageForm(string curName,string curSname)
        {
            InitializeComponent();
            this.Name = curName;
            this.Sname = curSname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = Sname + " " + Name;
        }

        private void SendMessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
