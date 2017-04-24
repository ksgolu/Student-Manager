using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class SIM_AdminSetting : Form
    {
        string profilePwd="Profile",Answer,Squestion, tempSquestion, tempAnswer;

        public SIM_AdminSetting()
        {
            InitializeComponent();
        }

        private void SIM_AdminSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtInfoCpas_TextChanged(object sender, EventArgs e)
        {
            if (txtInfoCpas.Text!=null)
            {
                txtInfoNpas.Enabled = true;
               
            }
            else
            {
                txtInfoNpas.Enabled = false;

            }

        }

        private void txtInfoNpas_TextChanged(object sender, EventArgs e)
        {
            if (txtInfoCpas.Text == txtInfoNpas.Text)
            {
                pictureBoxOk.Visible = true;
                pictureBoxError.Visible = false;
                btnInfoSave.Enabled = true;
            }
            else
            {
                
                pictureBoxError.Visible = true;
                pictureBoxOk.Visible = false;
                btnInfoSave.Enabled = false;
            }
        }

        private void btnInfoSave_Click(object sender, EventArgs e)
        {
            if(txtInfoNpas!=null)
            profilePwd = txtInfoNpas.Text;

        }

        private void btnInfoCancel_Click(object sender, EventArgs e)
        {
            panelInfo.Enabled = false;
            txtInfoCpas.Text = "";
            txtInfoNpas.Text = "";

        }

        private void label14_Click(object sender, EventArgs e)
        {
            panelInfo.Enabled = true;
        }

        private void txtRePwd_TextChanged(object sender, EventArgs e)
        {
            //pictureBoxPwdError.Visible = false;
            //pictureBoxPwdOk.Visible = false;
            if (txtRePwd.Text==txtNpwd.Text)
            {
                pictureBoxPwdOk.Visible = true;
                pictureBoxPwdError.Visible = false;
                btnSave.Enabled = true;
            }
            else
            {
                pictureBoxPwdError.Visible = true;
                pictureBoxPwdOk.Visible = false;
                btnSave.Enabled = false;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your profile password is mail to your register email id", "Forgot Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtProfilePassword_TextChanged(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed();
        }

        public void changed()
        {
            if(comboBox1.Text== "Which is your first school")
            {
                 tempSquestion = "Which is your first school";
                 tempAnswer = txtInfoAnswer.Text;
            }
            if (comboBox1.Text == "Name of your best friend")
            {
                tempSquestion = "Name of your best friend";
                tempAnswer = txtInfoAnswer.Text;
            }
            if (comboBox1.Text == "First place which you visit")
            {
                tempSquestion = "First place which you visit";
                tempAnswer = txtInfoAnswer.Text;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select security question", "Security Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if(comboBox1.Text)




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtProfilePassword.Text==profilePwd)
            {
                panelProfile.Visible = false;
                label17.Visible = false;
            }
            else
            {
                for(int i=1;i==3;i++)
                Console.Beep();

                label17.Visible = true;
            }

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
