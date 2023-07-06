using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietiss
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {

            InitializeComponent();
        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            bunifuAppBar1.Title = "Anasayfa";
            tabpage_Anasayfa.Show();
            tabpage_Anasayfa.BringToFront();
        }






        private void btn_Diyet_Click(object sender, EventArgs e)
        {
            bunifuAppBar1.Title = "Besinler Sayfası";

            tabpage_Besinler.Show();

            tabpage_Besinler.BringToFront();
        }

        private void Btn_Danisanlar_Click(object sender, EventArgs e)
        {
            bunifuAppBar1.Title = "Danisanlar Sayfası";

            tabpage_Danisanlar.Show();

            tabpage_Danisanlar.BringToFront();
        }


        private void Btn_Sablonlar_Click(object sender, EventArgs e)
        {
            bunifuAppBar1.Title = "Şablonlar Sayfası";

            tabpage_Sablonlar.Show();

            tabpage_Sablonlar.BringToFront();
        }




        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http:gladiusyazilim.com");


        }



        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }

        private void btn_Gorusmeler_Click(object sender, EventArgs e)
        {
            bunifuAppBar1.Title = "Görüşmeler Sayfası";

        }

        private void btn_Muhasebe_Click(object sender, EventArgs e)
        {
            tabpage_Muhasebe.Show();

            tabpage_Muhasebe.BringToFront();
            bunifuAppBar1.Title = "Muhasebe Sayfası";

        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {
            tabpage_Profil.Show();

            tabpage_Profil.BringToFront();
            bunifuAppBar1.Title = "Profil Sayfası";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Close();
          

         
        }
        
        private void label5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
