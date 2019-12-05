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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost; database = lplbank; username = root; password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Open();

                string str = "select * from account where accid = '" + txtacc.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str,con);

                MySqlDataReader rd = cmd.ExecuteReader();
                
                while(rd.Read())
                {
                    txtbal.Text = "$"+rd[4].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accno, date;
            double bal, deposit;

            accno = txtacc.Text;
            date = txtdate.Text;

            bal = double.Parse(txtbal.Text.TrimStart('$'));
            deposit = double.Parse(txtdep.Text);

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction;

            transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;


            try
            {
                cmd.CommandText =
                    "update account set balance = balance + '"+ deposit + "' where accid = '" + accno + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into transaction(accid,date,bal,deposit) values('" + accno + "','" + date + "','" + bal + "','" + deposit + "')";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("transaction completed ...");
                
                txtacc.Text="";
                this.txtdate.Value = DateTime.Now;
                txtbal.Text="";
                txtdep.Text="";

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
