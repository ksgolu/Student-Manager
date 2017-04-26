using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIM
{
    public partial class FormUserVerification : Form
    {
        string password,userId;
        
        public FormUserVerification(string userId,string password)
        {
            this.password = password;
            this.userId = userId;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            //pictureBoxPwdOk.Visible = false;
            if (txtCurrentPassword.Text == password)
            {
                pictureBoxPwdOk1.Visible = true;
                pictureBoxPwdError1.Visible = false;
                panel15.Enabled = true;
            }
            else
            {
                pictureBoxPwdError1.Visible = true;
                pictureBoxPwdOk1.Visible = false;
               
            }
        }

        private void txtRe_enter_TextChanged(object sender, EventArgs e)
        {
            //pictureBoxPwdOk.Visible = false;
            if (txtRe_enter.Text == txtNewPassword.Text)
            {
                pictureBoxPwdOk2.Visible = true;
                pictureBoxPwdError2.Visible = false;
                panel20.Enabled = true;
            }
            else
            {
                pictureBoxPwdError2.Visible = true;
                pictureBoxPwdOk2.Visible = false;
               
            }
        }

        private void TxtAnswer_TextChanged(object sender, EventArgs e)
        {
            //pictureBoxPwdOk.Visible = false;
            if (TxtAnswer.Text != null)
            {
                pictureBoxPwdOk3.Visible = true;
                pictureBoxPwdError3.Visible = false;
               
            }
            else
            {
                pictureBoxPwdError3.Visible = true;
                pictureBoxPwdOk3.Visible = false;
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Text = TxtAnswer.Text = txtRe_enter.Text = txtNewPassword.Text = null;
            pictureBoxPwdError1.Visible = pictureBoxPwdError2.Visible = pictureBoxPwdError3.Visible = false;
            pictureBoxPwdOk1.Visible = pictureBoxPwdOk2.Visible = pictureBoxPwdOk3.Visible = false;
            panel15.Enabled = panel20.Enabled = false;
        }






        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool checkTextFocus1 = false;bool checkTextFocus2 = false; bool checkTextFocus3 = false;
            if(string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                txtCurrentPassword.Focus();
                pictureBoxPwdOk1.Visible = false;
                pictureBoxPwdError1.Visible = true;
                checkTextFocus1 = true; ;
                //return;
            }

            if(string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtRe_enter.Text))
            { 
                
                txtNewPassword.Focus();
                pictureBoxPwdOk2.Visible = false;
                pictureBoxPwdError2.Visible = true;
                checkTextFocus2 = true;
                // return;

            }

             if (string.IsNullOrEmpty(cmBxQuestion.Text) || string.IsNullOrEmpty(TxtAnswer.Text))
            {


                TxtAnswer.Focus();
                pictureBoxPwdOk3.Visible = false;
                pictureBoxPwdError3.Visible = true;
                checkTextFocus3 = true;
                //return;

            }

            if(checkTextFocus1)
            {
                txtCurrentPassword.Focus();
                return;

            }
            else if (checkTextFocus2)
            {
                if (txtNewPassword.Text == "")
                    txtNewPassword.Focus();
                else
                    txtRe_enter.Focus();
                return;

            }
            else if (checkTextFocus3)
            {
                TxtAnswer.Focus();
                return;
            }



            string source = "data source = KUMARSATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";
            //String query= "select * from  where UserId='" + txtUserid.Text + "' and Password='" + txtPassword.Text + "'"

            try
            {
                using (SqlConnection conn = new SqlConnection(source))
                {
                    string ActiveStatus = "Active";
                    SqlCommand cmd = new SqlCommand("update LoginTabel set Password='" + this.txtRe_enter.Text + "',SecurityAnswer='" + this.TxtAnswer.Text + "',Status='" + ActiveStatus + "',SecurityQuestion='" + this.cmBxQuestion.Text + "' where UserId='"+userId+"'", conn);
                    SqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Your account is activated successfully","Account Activation");
                    while (dr.Read())
                    {
                      
                    }
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting error while Save data in database.\n\n" +ex.Message,"Update Error");
            }





        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtRe_enter.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormUserVerification_Load(object sender, EventArgs e)
        {
            txtUserId.Text = userId;
        }
    }
}
