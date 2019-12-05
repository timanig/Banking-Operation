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
            button2.BackColor = ColorTranslator.FromHtml("Green");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            button4.BackColor = ColorTranslator.FromHtml("192, 192, 0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid, lname, fname, street, city, state, phone, date, email, accno, acctype, des, bal;

            cid = label14.Text;
            lname = txtlname.Text;
            fname = txtfname.Text;
            street = txtstreet.Text;
            city = txtcity.Text;
            state = txtstate.Text;
            phone = txtphone.Text;
            date = txtdate.Text;
            email = txtemail.Text;
            accno = txtacc.Text;
            acctype = txtacctype.Text;
            des = txtdes.Text;
            bal = txtbal.Text;


            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction;

            transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;


            try
            {
                cmd.CommandText =
                    "insert into customer(custid,lastname,firstname,street,city,state,phone,date,email) " +
                    "values('"+cid+ "','" + lname + "','" + fname + "','" + street + "','" + city + "','" + state + "','" + phone + "','" + date + "','" + email + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into account(accid,custid,acctype,description,balance) values('"+ accno + "','" + cid + "','" + acctype + "','" + des + "','" + bal + "')";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Record added ...");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }
    }
}
