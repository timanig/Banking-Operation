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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        string username, password;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            userLogin.Text = "";
            userPassword.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            username = userLogin.Text.Trim();
            password = userPassword.Text.Trim();

            userLogin.Clear();
            userPassword.Clear();


            if (count == 3) 
            {
                MessageBox.Show("ERROR TOO MANY FAILED ATTEMPTS");
                Application.Exit();
            }

            if (username == "" || password == "")
            {
                label4.Text = "Enter Username & Password";
                count += 1;
                userLogin.Focus();
            }
            else if (username.Length >= 11 || password.Length >= 11)
            {
                label4.Text = "Only 10 Characters are allowed!";
                count += 1;
                userLogin.Focus();
            }
           
            else
            {


                if (username == "dan" && password == "finance")
                {
                    count = 0;
                    progressbar pr = new progressbar();
                    this.Hide();
                    pr.Show();
                }
                else
                {
                    label4.Text = "Incorrect username or Password";
                    count += 1;
                    userLogin.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void userLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
