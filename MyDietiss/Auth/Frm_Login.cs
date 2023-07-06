using MyDietiss.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietiss.Auth
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }


        private void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void bunifuTextBox1_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Clear();
        }

        private void bunifuTextBox2_Click(object sender, EventArgs e)
        {
            bunifuTextBox2.Clear();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Frm_Reset sa = new Frm_Reset();
            sa.Show();
          
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Frm_Main emp = new Frm_Main();
            if (Application.OpenForms["Frm_Main"] == null)
            {
                emp.ShowDialog();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
