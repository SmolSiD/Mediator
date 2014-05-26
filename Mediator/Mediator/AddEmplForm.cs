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
    public partial class AddEmplForm : Form
    {
        Form1 main;
        List<string> list;
        public AddEmplForm()
        {
            InitializeComponent();
        }

        private void AddEmplForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            list = main.getCompanyList();
            foreach (string line in list)
            {
                comboBox1.Items.Add(line);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list2 = main.getDeprList(comboBox1.SelectedIndex);
            foreach (string line in list2)
            {
                comboBox2.Items.Add(line);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.numbComp = comboBox1.SelectedIndex;
            main.numbDepr = comboBox2.SelectedIndex;
            main.nameEmpl = textBox1.Text;
            main.SnameEmpld = textBox2.Text;
            this.Close();
        }
    }
}
