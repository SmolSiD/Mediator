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
    public partial class Form1 : Form
    {
       List<Company> list_cmp;
        public Form1()
        {
            InitializeComponent();
            list_cmp = new List<Company>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Company my_comp=new Company("АналитПрибор");
            list_cmp.Add(my_comp);
            my_comp.CreateDepart("ОТСН");
            my_comp.CreateDepart("СЭО");
            my_comp.CreateDepart("КО-78");
            my_comp.list_dep[0].AddEmpl(new Empl("Сироткин", "Денис", "инженер-программист"));
            my_comp.list_dep[0].AddEmpl(new Empl("Мялик", "Ярослав", "инженер-программист"));
            my_comp.list_dep[1].AddEmpl(new Empl("sdfds", "sdfsdf", "sdfsdf"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Company cmp in list_cmp)
            {
                treeView1.Nodes.Add(new TreeNode(cmp.ToString()));
                foreach (Departments depr in cmp.list_dep)
                {
                    treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(depr.ToString());
                    foreach (Empl empl in depr.list_empl)
                    {
                        treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes[treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Count-1].Nodes.Add(empl.ToString());
                    }
                }
            }
        }


    }
}
