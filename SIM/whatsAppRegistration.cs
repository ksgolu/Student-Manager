using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
//using WhatsAppApi

namespace SIM
{
    public partial class whatsAppRegistration : Form
    {
        //whatsApp wapp;
        
        string password;
        public whatsAppRegistration(int panelNo)
        {
            InitializeComponent();
            if(panelNo==1)
            {
                panelRegistration.Enabled = true;
                panelSignIn.Enabled = false;
                this.Width = 589;


                //txtLoginPhoneNo.Text = Properties.Settings.Default.PhoneNumber;
                //txtPassword.Text = Properties.Settings.Default.Password;
            }
            else
            {
                panelRegistration.Enabled = false;
                panelSignIn.Enabled = true;
                this.Width = 277;

            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Visible = true;
                labelErrorReport.Visible = false;

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    label7.Visible = false;
                    labelErrorReport.Visible = true;
                    labelErrorReport.Text = "Please enter your Name";
                    txtName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtRegiMobile.Text))
                {
                    label7.Visible = false;
                    labelErrorReport.Visible = true;

                    labelErrorReport.Text = "Please enter your mobile number";
                    txtRegiMobile.Focus();
                    return;
                }
                grpBx_ConfirmCode.Enabled = true;

                


                if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(txtRegiMobile.Text, out password, "sms"))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        
                        Save(); //function call
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Could not generate password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message");
            }
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panelRegistration.Enabled = false;
            panelSignIn.Enabled = true;

            txtLoginPhoneNo.Text = Properties.Settings.Default.PhoneNumber;
            txtPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void whatsAppRegistration_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Remember)
            {
                txtLoginPhoneNo.Text = Properties.Settings.Default.PhoneNumber;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkBx_Remember.Checked = Properties.Settings.Default.Remember;
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBx_Remember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = chkBx_Remember.Checked;
            Properties.Settings.Default.PhoneNumber = txtLoginPhoneNo.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            labelErrorReport2.Visible = false;
            if (string.IsNullOrEmpty(txtSmsCode.Text))
            {
                label6.Visible = false;
                labelErrorReport2.Visible = true;
                labelErrorReport2.Text = "Please Enter 6 digit code";
                txtSmsCode.Focus();
                return;

                password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(txtRegiMobile.Text, txtSmsCode.Text);
                Save(); //function call
            }
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------
                                                Functions
             -----------------------------------------------------------------------------------------------------------------------------------------*/

        private void Save()
        {
            try
            {
                
                Properties.Settings.Default.PhoneNumber = txtRegiMobile.Text;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.FullName = txtName.Text;
                Properties.Settings.Default.Save();

                

                if (Global.DB.Accounts.FindByAccountId(txtRegiMobile.Text) == null)
                {
                    whatsAppDataSet.AccountsRow row = Global.DB.Accounts.NewAccountsRow();
                    row.AccountId = txtRegiMobile.Text;
                    row.FullName = txtName.Text;
                    row.Password = password;
                    Global.DB.Accounts.AddAccountsRow(row);
                    Global.DB.Accounts.AcceptChanges();
                    Global.DB.Accounts.WriteXml(string.Format("{0}\\accounts.dat", Application.StartupPath));

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRegistration_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
