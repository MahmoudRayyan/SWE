using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_first
{
    public partial class Form1 : Form
    {
        DbConnector db; 
        public Form1()
        {
            InitializeComponent();
            db= new DbConnector();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpass.Clear();
            txtusername.Focus();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_access()) {
                if (Check()) {
                    Form2 sec_page = new Form2();
                     sec_page.Show();    

                }
            }
        }

        private bool Check()
        {
            string username = db.getSingleValue("Select admin_ID from Admins where admin_username ='" + txtusername.Text+ "'and  admin_pass='" + txtpass.Text +"'", out username, 0);
          

            if (username == null)
            {
                MessageBox.Show("Error ,Please Enter The Right UserName And The Password...");
                return false;
            }
            return true;

        }

        private bool is_access() {
            if (txtusername.Text.ToString().Trim() == String.Empty || txtpass.Text.ToString().Trim() == String.Empty)
            {
                MessageBox.Show("Please Enter All Required Information");
                return false;
            }
            return true;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
