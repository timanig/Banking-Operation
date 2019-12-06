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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        MySqlConnection con = new MySqlConnection("server = localhost; database = lplbank; username = root; password=;");
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string str = "select * from account where accid = '" + txtacc.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, con);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    txtbal.Text = "$" + rd[4].ToString();
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
            double bal, withdraw;

            accno = txtacc.Text;
            date = txtdate.Text;

            bal = double.Parse(txtbal.Text.TrimStart('$'));
            withdraw = double.Parse(txtwithdraw.Text);

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction;

            transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;


            try
            {
                cmd.CommandText =
                    "update account set balance = balance - '" + withdraw + "' where accid = '" + accno + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into transaction(accid,date,bal,withdraw) " +
                    "values('" + accno + "','" + date + "','" + bal + "','" + withdraw + "')";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("transaction completed ...");

                txtacc.Text = "";
                this.txtdate.Value = DateTime.Now;
                txtbal.Text = "";
                txtwithdraw.Text = "";

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
