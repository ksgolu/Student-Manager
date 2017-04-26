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
//using S;

namespace SIM
{
    public partial class Login : Form
    {
        /*string userid = "satyam";
        string pwd = "golu";*/
        int check = 0;
        public Login(int a)
        {
            InitializeComponent();
            check = a;
   

        }

        private void btnX_Click(object sender, EventArgs e)
        {
           this.Close();
            /*Form1 form = new Form1("Invalid login");
            form.Close();*/

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //txtUserid.Text = "ks_satyam";
            //txtPassword.Text = "golu";
            string source = "data source = KUMARSATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";

            

            try
            {
                using (SqlConnection conn = new SqlConnection(source))
                {
                    SqlCommand cmd = new SqlCommand("select * from logintabel where UserId='"+ txtUserid.Text +"' and Password='"+ txtPassword.Text +"'", conn);
                    //string=""
                    SqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    int count = 0;
                    while(dr.Read())
                    { count++; }
                    bool available=false;
                    string usrnm = txtUserid.Text;
                    foreach (char ch  in usrnm)
                    {
                        if(ch=='#')
                        {
                            available = true;
                            break;
                        }
                    }
                    if (count == 1 && check==0)
                    {
                        bool ActiveStatus = false; ;
                        conn.Close();
                        pictureBox2.Visible = false;
                        pictureBox1.Visible = true;
                        this.Hide();

                        string notActive = "NotActive";
                        SqlCommand cd = new SqlCommand("select * from logintabel where UserId='" + txtUserid.Text + "' and Password='" + txtPassword.Text + "' and Status='"+notActive+"'", conn);
                        //string=""
                        SqlDataReader dataread;
                        conn.Open();
                        dataread = cd.ExecuteReader();
                        int count1 = 0;
                        while (dataread.Read())
                        { count1++; }
                        if (count1 == 1)
                        {
                            ActiveStatus = true;
                        }
                        
                       

                            Form1 form = new Form1(txtUserid.Text,txtPassword.Text, ActiveStatus,available);
                            form.Show();
                       

                        //this.Show();
                    }
                    //if (count == 1 && check == 0 && available == true)
                    //{
                    //    pictureBox2.Visible = false;
                    //    pictureBox1.Visible = true;
                    //    this.Hide();

                    //    SIM_Admin form = new SIM_Admin();
                    //    form.Show();
                    //    //this.Show();

                    //}
                    else if(count == 1 && check == 1)
                    {
                        pictureBox2.Visible = false;
                        pictureBox1.Visible = true;
                        this.Hide();
                        MessageBox.Show("I am in check=1");
                        //Form1  form = new Form1(txtUserid.Text);
                       // form.Show();

                        this.Hide();

                        /*Form1 form = new Form1(txtUserid.Text);
                        form.Show();*/
                    }
                    else if (count>1)
                    {
                        MessageBox.Show("More than one person having same userid\nPlease contact your Adminstrator","Login Failed warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        for (int i = 1; i == 3; i++)
                            Console.Beep();
                        pictureBox2.Visible = true;
                        pictureBox2.Enabled = true;
                        labelMessage.Text = "Oops   please   try   again";
                        if(string.IsNullOrEmpty(txtUserid.Text))
                            panelLoginColour1.BackColor = Color.Red;
                        if(string.IsNullOrEmpty(txtPassword.Text))
                            panelLoginColour2.BackColor = Color.Red;
                        if( (string.IsNullOrEmpty(txtUserid.Text) ) && ( string.IsNullOrEmpty(txtPassword.Text) ) )
                        {
                            panelLoginColour1.BackColor = Color.Red;
                            panelLoginColour2.BackColor = Color.Red;
                        }
                        //txtUserid.Text = "";
                        txtPassword.Text = "";
                        conn.Close();
                        
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to log you", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string source = "data source = KUMARSATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";
            if (MessageBox.Show("Please contact your Admin in case you forgot userid and password both.\n\nDo you want to reset password only ","Forgot password", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                panelMain.Enabled = false;
                groupBoxPassword.Visible = true;
                using (SqlConnection conn = new SqlConnection(source))
                {
                    SqlCommand cmd = new SqlCommand("select * from logintabel where UserId='" + txtGropBoxId.Text + "' and securityAnswer='" + txtGroupBoxAnswer.Text + "'", conn);
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SIM_AdminSetting adminsetting = new SIM_AdminSetting();
            adminsetting.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text=="")
            {
                panelLoginColour2.BackColor = Color.Red;
            }
            
        }

        private void txtUserid_Click(object sender, EventArgs e)
        {
            panelLoginColour1.BackColor = Color.MediumSeaGreen;

            
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            panelLoginColour2.BackColor = Color.MediumSeaGreen;
            if (txtUserid.Text == "")
            {
                panelLoginColour1.BackColor = Color.Red;
            }
            else
            {
                panelLoginColour1.BackColor = Color.MediumSeaGreen;
            }
        }

        private void txtGroupBoxAnswer_Click(object sender, EventArgs e)
        {
            txtGroupBoxAnswer.Text = "";
            txtGroupBoxAnswer.ForeColor = Color.Black;
        }

        private void btnGroupBoxOk_Click(object sender, EventArgs e)
        {
            groupBoxPassword.Visible = false;
            panelMain.Enabled = true;
        }

        private void btnGroupBoxCancel_Click(object sender, EventArgs e)
        {
            groupBoxPassword.Visible = false;
            panelMain.Enabled = true;
        }

        private void chkBx_Remember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoginRemember = chkBx_Remember.Checked;
            Properties.Settings.Default.LoginId = txtUserid.Text;
            Properties.Settings.Default.LoginPassword = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.LoginRemember)
            {
                txtUserid.Text = Properties.Settings.Default.LoginId;
                txtPassword.Text = Properties.Settings.Default.LoginPassword;
                chkBx_Remember.Checked = Properties.Settings.Default.LoginRemember;
            }
        }
    }
}
