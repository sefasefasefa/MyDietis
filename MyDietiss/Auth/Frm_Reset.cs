using Jenga;
using ServiceStack.OrmLite;
using System;
using System.Windows.Forms;
namespace MyDietiss.Auth
{
    public partial class Frm_Reset : Form
    {
        private readonly MyDietiss.Models.Employee _identity;
        public string ErrorMessage { get; set; } = " Passwords do not match.";
        public string SuccessMessage { get; set; } = "Password successfully Changed. ";
        public Frm_Reset(MyDietiss.Models.Employee identity = null)
        {
            InitializeComponent();
            //this._identity = identity;
            //if (_identity == null) _identity = Authentication.GetIdentity<MyDietiss.Models.Employee>();
            //txtEmail.Text =  _identity.Email;
            //lblTitle.Text = _identity.Password.Trim().Length == 0 ? "Set Password" : "Reset Password";
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
          
        }

       


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ////validate for errors
            //if (validationProvider.Validate().Length > 0) return;
            ////check if passwords are same
            //if (txtPassword.Text.Trim() == txtPassword2.Text.Trim())
            //{
            //    MessageBox.Show(ErrorMessage,"Hata",MessageBoxButtons.OK);
            //    return;
            //}
            //Cursor.Current = Cursors.WaitCursor;
            //var account = Authentication.GetIdentity<MyDietiss.Models.Employee>();
            //account.Password = txtPassword.Text.Trim().ToSHA512Hash();
            //Kt.Db.Save(account);
            //MessageBox.Show(SuccessMessage,"Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Cursor.Current = Cursors.Default;
        }

        private void Frm_Reset_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtPassword2_Click(object sender, EventArgs e)
        {
            txtPassword2.Clear();
        }
    } 

}
    

    
    


