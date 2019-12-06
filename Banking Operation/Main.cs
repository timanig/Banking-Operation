using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Operation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountCreation account = new AccountCreation();
            account.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Deposit deposit = new Deposit();
            deposit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            review.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
