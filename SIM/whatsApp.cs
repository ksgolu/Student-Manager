using EnvDTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class whatsApp : Form
    {
        public whatsApp()
        {
            InitializeComponent();
            whatsAppRegistration frm = new whatsAppRegistration(2);
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void send_Click(object sender, EventArgs e)
        {
            // labelWriteYourMessage.Visible = true;

             System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone="+txtPhoneNo.Text+"&text="+rTxtbx_Message.Text);
             System.Diagnostics.Process.Start("C:\\Users\\satya\\AppData\\Local\\WhatsApp\\app-0.2.3699\\WhatsApp.exe");
             rTxtbx_Message.Text = "\n\n    MESSAGE FOR:- \n%0A---------------------------------------------%0A\n\n\n\n\n" +
                "%0A----------------------------------------------%0A\n By:    Graphic Era University\n" +
                "%0A*Don't reply to this message";


                    labelWriteYourMessage.Visible = true;


        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            labelWriteYourMessage.Visible = true;
            rTxtbx_Message.Text = "\n\n    MESSAGE FOR:- \n%0A---------------------------------------------%0A\n\n\n\n\n" +
               "%0A----------------------------------------------%0A\n By:    Graphic Era University\n" +
               "%0A*Don't reply to this message";
        }

        private void rTxtbx_Message_Click(object sender, EventArgs e)
        {
            labelWriteYourMessage.Visible = false;
        }

        private void rTxtbx_Message_TextChanged(object sender, EventArgs e)
        {
            //labelWriteYourMessage.Visible = false;

        }

        private void newAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (whatsAppRegistration frm = new whatsAppRegistration(1)) //when the new registration form open with this parameter i.e 1, than registration panel will be enabled
                     frm.ShowDialog();
            
        }

        private void signinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatsAppRegistration frm = new whatsAppRegistration(2);
            frm.ShowDialog();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}




/*MESSAGE FOR:- 
---------------------------------------------

             


----------------------------------------------
 By:    Graphic Era University
* Don't reply to this message*/
