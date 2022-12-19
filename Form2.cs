using Login_first.admin_control;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
           InitializeComponent();
            __Home H = new __Home();
            add_control(H);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void add_control(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            Container.Controls.Clear();
            Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            __Home H = new __Home();
            add_control(H);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            __Home H = new __Home();
            add_control(H);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            __Information info = new __Information();
            add_control(info);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            __Edit edit = new __Edit();
            add_control(edit);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
