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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server = localhost; database = lplbank; username = root; password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            string fno, tno, date;
            double bal;

            fno = ftxt.Text;
            tno = totxt.Text;
            date = datetxt.Text;
            bal = double.Parse(txtamount.Text);


            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction;

            transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;


            try
            {
                cmd.CommandText =
                    "update account set balance = balance - '" + bal + "' where accid = '" + fno + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "update account set balance = balance + '" + bal + "' where accid = '" + tno + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into transfer(f_acc,to_acc,date,amount) " +
                    "values('" + fno + "','" + tno + "','" + date + "','" + bal + "')";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("transaction completed ...");

                ftxt.Text = "";
                this.datetxt.Value = DateTime.Now;
                txtamount.Text = "";
                totxt.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
