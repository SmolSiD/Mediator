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
    public partial class AddCmpForm : Form
    {
        Form1 main;
        public AddCmpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.nameCmp = textBox1.Text;
            this.Close();
        }

        private void AddCmpForm_Load(object sender, EventArgs e)
        {
          main = this.Owner as Form1;
        }
    }
}
