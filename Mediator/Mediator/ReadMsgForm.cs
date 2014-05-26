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
    public partial class ReadMsgForm : Form
    {
        List<string> list;
        Form1 main;
        public ReadMsgForm(List<string> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void ReadMsgForm_Load(object sender, EventArgs e)
        {
            foreach (string line in list)
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
