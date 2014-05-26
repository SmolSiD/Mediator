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
       public string nameCmp;
       public string nameDepr;
       public int numbComp;
       public string nameEmpl;
       public string SnameEmpld;
       public int numbDepr;
       Empl currentUser;
       int currentIndUser;
       Server serv;
        public Form1()
        {
            InitializeComponent();
            list_cmp = new List<Company>();
            serv = new Server();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Company my_comp=new Company("АналитПрибор");
            list_cmp.Add(my_comp);
            serv.AddCmp(my_comp);
            my_comp.CreateDepart("ОТСН");
            my_comp.CreateDepart("СЭО");
            my_comp.CreateDepart("КО-78");
            my_comp.list_dep[0].AddEmpl(new Empl("Сироткин", "Денис"));
          currentUser = my_comp.list_dep[0].list_empl[my_comp.list_dep[0].list_empl.Count - 1];
            my_comp.list_dep[0].AddEmpl(new Empl("Мялик", "Ярослав"));
            my_comp.list_dep[1].AddEmpl(new Empl("sdfds", "sdfsdf"));
            foreach (Company cmp in list_cmp)
            {
                foreach (Departments depr in cmp.list_dep)
                {
                    foreach (Empl empl in depr.list_empl)
                    {
                        empl.setServer(serv);
                    }
                }
            }
        }

        public List<string> getCompanyList()
        {
            List<string> list=new List<string>();
            foreach (Company cmp in list_cmp)
            {
                list.Add(cmp.ToString());
            }
            return list;
        }
        public List<string> getDeprList(int i)
        {
            List<string> list = new List<string>();
            foreach (Departments depr in list_cmp[i].list_dep)
            {
                list.Add(depr.ToString());
            }
            return list;
        }
      public Company getCompany(string name)
        {
            foreach (Company cmp in list_cmp)
            {
                if (cmp.ToString().Equals(name)) return cmp;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
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

        private void компаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отделToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сообщениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
         /*   TreeView node = (TreeView)sender;
           // SendMessageForm SendMsg = new SendMessageForm(currentUser.ToString().Split(' ')[0], currentUser.ToString().Split(' ')[1]);
            string path=node.SelectedNode.FullPath;
            string [] temp=path.Split('\\');
            Empl dest=getCompany(temp[0]).getDepr(temp[1]).getEmp(temp[2].Split(' ')[0],temp[2].Split(' ')[1]);
            Message msg=new Message(currentUser,dest);
            string text = "Hello World";
            ContentsMes content = new TextMessage(text);
            msg.setContent(content);
            currentUser.SendMessage(msg);
            //treeView1.
           // Message mes=new Message(currentUser,*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serv.Tic();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeView node = (TreeView)sender;
            // SendMessageForm SendMsg = new SendMessageForm(currentUser.ToString().Split(' ')[0], currentUser.ToString().Split(' ')[1]);
            string path = node.SelectedNode.FullPath;
            string[] temp = path.Split('\\');
            Empl dest = getCompany(temp[0]).getDepr(temp[1]).getEmp(temp[2].Split(' ')[0], temp[2].Split(' ')[1]);
            Message msg = new Message(currentUser, dest);
            string text = "Hello World";
            ContentsMes content = new TextMessage(text);
            msg.setContent(content);
            currentUser.SendMessage(msg);
            //treeView1.
            // Message mes=new Message(currentUser,
        }

        private void компаниюToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddCmpForm addCmp = new AddCmpForm();
            addCmp.Owner = this;
            addCmp.ShowDialog();
            list_cmp.Add(new Company(nameCmp));
            serv.AddCmp(list_cmp[list_cmp.Count - 1]);
            button1.PerformClick();
        }

        private void отделToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddDeprForm addDepr = new AddDeprForm();
            addDepr.Owner = this;
            addDepr.ShowDialog();
            list_cmp[numbComp].CreateDepart(nameDepr);
            button1.PerformClick();
        }

        private void сотрудникаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddEmplForm addEmpl = new AddEmplForm();
            addEmpl.Owner = this;
            addEmpl.ShowDialog();
            list_cmp[numbComp].list_dep[numbDepr].CreateEmpl(nameEmpl, SnameEmpld);
            list_cmp[numbComp].list_dep[numbDepr].list_empl[list_cmp[numbComp].list_dep[numbDepr].list_empl.Count - 1].setServer(serv);
            button1.PerformClick();
        }

        private void сообщенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отправитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dgfdgfd");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void сообщенияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

  


    }
}
