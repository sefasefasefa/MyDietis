using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietiss.Dialogs
{
    public partial class Frm_Danisan : Form
    {
        public Frm_Danisan()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Enter Name")
                txt_name.Text = " ";
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "Enter Name")
                txt_name.Text = " ";
        }

        private void txt_mail_Enter(object sender, EventArgs e)
        {
            if (txt_mail.Text == " Enter Email")
                txt_mail.Text = " ";
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {



        }

        private void txt_mail_Leave(object sender, EventArgs e)
        {
            if (txt_mail.Text == " Enter Email")
                txt_mail.Text = " ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.WindowState  = FormWindowState.Minimized;
        }
    }
}
