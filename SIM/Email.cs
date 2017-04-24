using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SIM
{
    public partial class Email : Form
    {
        NetworkCredential Login;
        SmtpClient client;
        MailMessage msg;
        public Email()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
            if(string.IsNullOrEmpty(txtName.Text))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "Name is mising";
                return;
                //SoundPlayer player = new SoundPlayer();
                //player.
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "Email is mising";
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "Password is mising";
                return;
            }
            if (string.IsNullOrEmpty(txtSmtp.Text))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "Protocol is mising";
                return;
            }
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "Port is mising";
                return;

            }

            Login = new NetworkCredential(txtUserName.Text, txtPassword.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = checkSSL.Checked;
            client.Credentials = Login;
            msg = new MailMessage { From = new MailAddress(txtUserName.Text + txtSmtp.Text.Replace("smtp.", "@"), txtName.Text , Encoding.UTF8) };



            msg.To.Add(new MailAddress("satyamshay@gmail.com"));
            if (!string.IsNullOrEmpty(txtCc.Text))
                msg.To.Add(new MailAddress(txtCc.Text));
            msg.Subject = "Login Alert";
            msg.Body = txtName.Text +" with user-id :- " + txtUserName.Text+" is loged in SIM ";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            labelErrorMessage.Visible = true;
            labelErrorMessage.Text = "Trying to log you...";
            try
            {
                client.SendCompleted += new SendCompletedEventHandler(LoginSCCB);
            }
            catch(Exception ex)
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage.Text = "No Network available";
            }
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);

            Properties.Settings.Default.EmailName = txtName.Text;
            Properties.Settings.Default.Emailid = txtUserName.Text;
            Properties.Settings.Default.Save();

            labelLoginName.Text = Properties.Settings.Default.EmailName;
            labelEmailId.Text = Properties.Settings.Default.Emailid;

            
            if(checkRemember.Checked)
            {
                Properties.Settings.Default.EmailRemember = true;
                
            }
            else
            {
                Properties.Settings.Default.EmailRemember = false;
            }
           
            Properties.Settings.Default.Save();



        }


        public void LoginSCCB(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                labelErrorMessage.Text = "Something went wrong try again";
            if (e.Error != null)
                labelErrorMessage.Text = "User-id or password is wrong";
            else
            {

                panelInfo.Visible = true;
                panelMain.Enabled = true;

            }
        }



        /*public void verification(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Messsage", MessageBoxButtons.OK);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0}{1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK);
            else
            {
                
               
            }
        }*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtUserName.Text = null;
            txtPassword.Text = null;
            txtPort.Text = "587";
            txtSmtp.Text = "smtp.gmail.com";
            checkSSL.CheckState = CheckState.Checked;
            labelErrorMessage.Text = null;
            panelInfo.Visible = false;
            panelSignin.Visible = true;
            panelMain.Enabled = false;
            Properties.Settings.Default.EmailRemember = false;
            Properties.Settings.Default.Save();


        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailName = txtName.Text;
            Properties.Settings.Default.Emailid = txtUserName.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
           // Properties.Settings.Default.EmailRemember = checkRemember.Checked;
            Properties.Settings.Default.Emailport= txtPort.Text;
            Properties.Settings.Default.EmailSmtp = txtSmtp.Text;
            Properties.Settings.Default.SSL = checkSSL.Checked;
            Properties.Settings.Default.Save();
        }

        private void linkNewAc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/SignUp?hl=en");

        }

        private void checkSSL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SSL = checkSSL.Checked;
            Properties.Settings.Default.Save();

        }

        private void Email_Load(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            panelSignin.Visible = true;
            panelMain.Enabled = false;
            if (Properties.Settings.Default.EmailRemember)
            {

                Properties.Settings.Default.EmailRemember = checkRemember.Checked;
                txtName.Text = Properties.Settings.Default.EmailName;
                txtUserName.Text = Properties.Settings.Default.Emailid;
                txtPassword.Text = Properties.Settings.Default.Password;
                // Properties.Settings.Default.EmailRemember = checkRemember.Checked;
                txtPort.Text = Properties.Settings.Default.Emailport;
                txtSmtp.Text = Properties.Settings.Default.EmailSmtp;
                checkSSL.Checked = Properties.Settings.Default.SSL;
            }

            /*if (Properties.Settings.Default.EmailRemember)
            {
              


                /* Login = new NetworkCredential(Properties.Settings.Default.Emailid, Properties.Settings.Default.Emailpassword);
                 client = new SmtpClient(Properties.Settings.Default.EmailSmtp);
                 client.Port = Convert.ToInt32(Properties.Settings.Default.Emailport);
                 client.EnableSsl = Properties.Settings.Default.SSL;
                 client.Credentials = Login;
                 msg = new MailMessage { From = new MailAddress(Properties.Settings.Default.Emailid + Properties.Settings.Default.EmailSmtp.Replace("smtp.", "@"), "satyam", Encoding.UTF8) };*/
           /* }
            else
            {
                panelInfo.Visible = false;
                panelSignin.Visible = true;
                
            }*/
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtTo.Text))
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Address is missing";
                txtTo.Focus();
                return;
            }

            if(string.IsNullOrEmpty(txtSubject.Text))
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Subject is missing";
                txtSubject.Focus();
                return;
            }
            if(string.IsNullOrEmpty(rtxtBx_Message.Text))
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Trying to send empty email";
                rtxtBx_Message.Focus();
                return;
            }


            /* Login = new NetworkCredential(Properties.Settings.Default.Emailid, Properties.Settings.Default.Emailpassword);
             client = new SmtpClient(Properties.Settings.Default.EmailSmtp);
             client.Port = Convert.ToInt32(Properties.Settings.Default.Emailport);
             client.EnableSsl = Properties.Settings.Default.SSL;
             client.Credentials = Login;
             msg = new MailMessage { From = new MailAddress(Properties.Settings.Default.Emailid + Properties.Settings.Default.EmailSmtp.Replace("smtp.", "@"), "satyam", Encoding.UTF8) };*/


           
        

                msg.To.Add(new MailAddress(txtTo.Text));
                if (!string.IsNullOrEmpty(txtCc.Text))
                    msg.To.Add(new MailAddress(txtCc.Text));
                msg.Subject = txtSubject.Text;
                msg.Body = rtxtBx_Message.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Sending Message...";
                client.SendCompleted += new SendCompletedEventHandler(SCCB);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
           
           

            
        }


        public void SCCB(object sender, AsyncCompletedEventArgs e)
        {
            btnSend.Enabled = false;
            if (e.Cancelled)
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Sending cancel";
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Messsage", MessageBoxButtons.OK);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0}{1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK);
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Someting went wrong try again";
            }                
            else
            {
                labelMessageStatus.Visible = true;
                labelMessageStatus.Text = "Your messsage is sent successfully";
                txtTo.Text = null;
                txtSubject.Text = null;
                txtCc.Text = null;
                rtxtBx_Message.Text = null;
                btnSend.Enabled = true;
            }
        }


       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*if(txtPassword.PasswordChar.)
            string pwd= txtPassword.Text;
            txtPassword.Text = pwd;*/
            txtPassword.PasswordChar.ToString();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
           // labelMessageStatus.Visible = false;
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            //labelMessageStatus.Visible = false;
        }

        private void rtxtBx_Message_TextChanged(object sender, EventArgs e)
        {
            //labelMessageStatus.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
