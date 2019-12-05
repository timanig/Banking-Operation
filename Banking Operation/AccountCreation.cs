using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Banking_Operation
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server = localhost; database = lplbank; username = root; password=;");

        public void custid()
        {
            con.Open();
            string query = "select max(custid) from customer";
            MySqlCommand cmd = new MySqlCommand(query,con);
           
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if(val =="")
                {
                    label14.Text = "10000";
                }
                else 
                {
                    int a;

                    a = int.Parse(dr[0].ToString());
                    a += 1;
                    label14.Text = a.ToString();


                }
                con.Close();

            }
        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {
            custid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            button1.BackColor = ColorTranslator.FromHtml();
            button3.BackColor = ColorTranslator.FromHtml();
        }
    }
}
