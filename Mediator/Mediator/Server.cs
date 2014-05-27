using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace Mediator
{
    public class Server
    {
        List<Company> list;
        List<Message> list_mes_send;
        List<Message> list_mes_rec;
        DataSet ds;
        SqlDataAdapter adp;
        SqlDataAdapter adp2;
        SqlConnection sql_connect;
        DataTable tbEmpl;
        DataTable tbMsg;
        SqlCommandBuilder sql;
        Thread thr;
        Empl currentUser;
        public Server(Empl currentUser)
        {
           this.currentUser=currentUser;
            this.list = new List<Company>();
            this.list_mes_send = new List<Message>();
            this.list_mes_rec = new List<Message>();
            string connect_string = @"Data Source=SID-PC\SQLEXPRESS;Initial Catalog=MediatorDB;Integrated Security=true;";
            sql_connect = new SqlConnection(connect_string);
            sql_connect.Open();
            ds = new DataSet();
            adp = new SqlDataAdapter("SELECT * FROM Сотрудники", sql_connect);
            adp.Fill(ds, "Сотрудники");
            tbEmpl = ds.Tables["Сотрудники"];
  
            adp2 = new SqlDataAdapter("SELECT * FROM Сообщения", sql_connect);
            adp2.Fill(ds, "Сообщения");
            tbMsg = ds.Tables["Сообщения"];
            sql = new SqlCommandBuilder(adp2);
            List<string> list = new List<string>();
            foreach (DataRow row in tbMsg.Rows)
            {
                list.Add(row[0].ToString()+row[1].ToString()+row[2].ToString());
            }
            this.thr = new Thread(this.updMessage);
            thr.Start();
        }
        ~Server()
        {
            thr.Abort();
            try
            {
                sql_connect.Close();
            }
            catch { };     
        }
        public void updMessage()
        {
         

           while (true)
            {
                adp2.SelectCommand.ExecuteNonQuery();
                tbMsg.Clear();
                adp2.Fill(ds, "Сообщения");
                for (int i = 0; i<tbMsg.Rows.Count;i++)
                {
                    //string a = row[2].ToString().Trim();
                    //string b = currentUser.ToString();
                    if (tbMsg.Rows[i][2].ToString().Trim().Equals(currentUser.ToString()))
                    {
                        MessageBox.Show("Получено сообщение");
                        RemoveRow(Int32.Parse(tbMsg.Rows[i][0].ToString()));
                    }
                }
                Thread.Sleep(10000);
            }
        }
        public void RemoveRow(int id)
        {
            tbMsg.Rows.RemoveAt(0);
            adp2.DeleteCommand = new SqlCommand("DELETE FROM Сообщения WHERE id=" + id);
            adp2.DeleteCommand.Connection = sql_connect;
            adp2.DeleteCommand.ExecuteNonQuery();
        }
        public void SendMessage(Message msg)
        {
            DataRow row = tbMsg.NewRow();
            row[1] = msg.From.ToString();
            row[2] = msg.To.ToString();
            row[3] = msg.ToString();
            tbMsg.Rows.Add(row);
            adp2.Update(ds, "Сообщения");   
        }

        public void AddCmp(Company obj)
        {
            this.list.Add(obj);
        }

        public void AddMessage(Message mes)
        {
            this.list_mes_send.Add(mes);
        }
        public void RemoveMessage(Message mes)
        {
            this.list_mes_send.Remove(mes);
        }
        public void Tic()
        {
            if (list_mes_send.Count != 0)
            {
                foreach (Message mes in list_mes_send)
                {
                    if (!mes.isFin) { SendMessage(mes); mes.isFin = true; }
                }
            }
        }
      /*  public void SendMessage(Message mes)
        {
            foreach (Company cmp in list)
            {
                foreach (Departments depr in cmp.list_dep)
                {
                    foreach (Empl emp in depr.list_empl)
                    {
                        if (emp.isTarget(mes)) { emp.AddMessage(mes); mes.isFin = true; break; }
                    }
                }
            }


        }*/
    }
}
