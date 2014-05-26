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
    public partial class AddDeprForm : Form
    {
        List<string> list;
        Form1 main;
        public AddDeprForm()
        {
            
            InitializeComponent();

        }

        private void AddDeprForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            list = main.getCompanyList();
            foreach (string line in list)
            {
                comboBox1.Items.Add(line);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.numbComp = comboBox1.SelectedIndex;
            main.nameDepr = textBox1.Text;
            this.Close();
        }
    }
}
