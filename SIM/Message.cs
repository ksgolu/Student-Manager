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
    public partial class TextMessage : Form
    {
        public TextMessage()
        {
            InitializeComponent();
        }

       

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(panelSlide.Height==27)
            {
                labelShowUser.Visible = false;
                for (int i = 27; i <=76; i+=5)
                {
                    panelSlide.Height = i;
                }
            }
            else
            {
                labelShowUser.Visible = true;
                for (int i = 76; i >= 27; i--)
                {
                    panelSlide.Height = i;
                }

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 76; i >= 27; i--)
            {
                panelSlide.Height = i;
            }
            btnSlide.Visible = true;
            labelShowUser.Text = txtUserid.Text;
            labelShowUser.Visible = true;
            panelMain.Enabled = true;
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(listBox1.Visible==true)
            {
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTo.Text = listBox1.Text;
        }

        private void TextMessage_Load(object sender, EventArgs e)
        {
            panelSlide.Height = 76;
            panelMain.Enabled = false;
        }
    }
}
