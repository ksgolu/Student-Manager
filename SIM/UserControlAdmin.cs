using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{

    public partial class UserControlAdmin : UserControl
    {
        int buttonNo = 0;
        public UserControlAdmin()
        {
            InitializeComponent();



        }

        private void label55_Click(object sender, EventArgs e)
        {

        }


        /*---------------------------------------------------------------------------------------------------------------------------------------------------
 *                                      THIS FORM LOAD TAKE CARE OF ALL THE USER BUTTONS, ONLY THOSE BUTTON ARE APPEAR ON THE FORM WHICH HAVE THE NAME
 *----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void UserControlAdmin_Load(object sender, EventArgs e)
        {

            if (btnUser1.Text == Properties.Settings.Default.btn1)
            {
                btnUser1.Visible = false;
            }
            else
                btnUser1.Text = Properties.Settings.Default.btn1;

            if (btnUser2.Text == Properties.Settings.Default.btn2)
            {

                btnUser2.Visible = false;
            }
            else
                btnUser2.Text = Properties.Settings.Default.btn2;

            if (btnUser3.Text == Properties.Settings.Default.btn3)
            {

                btnUser3.Visible = false;
            }
            else
                btnUser3.Text = Properties.Settings.Default.btn3;

            if (btnUser4.Text == Properties.Settings.Default.btn4)
            {
                btnUser4.Visible = false;
            }
            else
                btnUser4.Text = Properties.Settings.Default.btn4;

            if (btnUser5.Text == Properties.Settings.Default.btn5)
            {
                btnUser5.Visible = false;
            }
            else
                btnUser5.Text = Properties.Settings.Default.btn5;

            if (btnUser6.Text == Properties.Settings.Default.btn6)
            {
                btnUser6.Visible = false;
            }
            else
                btnUser6.Text = Properties.Settings.Default.btn6;

            if (btnUser7.Text == Properties.Settings.Default.btn7)
            {
                btnUser7.Visible = false;
            }
            else
                btnUser7.Text = Properties.Settings.Default.btn7;

            if (btnUser8.Text == Properties.Settings.Default.btn8)
            {
                btnUser8.Visible = false;
            }
            else
                btnUser8.Text = Properties.Settings.Default.btn8;

            if (btnUser9.Text == Properties.Settings.Default.btn9)
            {
                btnUser9.Visible = false;
            }
            else
                btnUser9.Text = Properties.Settings.Default.btn9;

            if (btnUser10.Text == Properties.Settings.Default.btn10)
            {
                btnUser10.Visible = false;
            }
            else
                btnUser10.Text = Properties.Settings.Default.btn10;

            if (btnUser11.Text == Properties.Settings.Default.btn11)
            {
                btnUser11.Visible = false;
            }
            else
                btnUser11.Text = Properties.Settings.Default.btn11;

            if (btnUser12.Text == Properties.Settings.Default.btn12)
            {
                btnUser12.Visible = false;
            }
            else
                btnUser12.Text = Properties.Settings.Default.btn12;

            if (btnUser13.Text == Properties.Settings.Default.btn13)
            {
                btnUser13.Visible = false;
            }
            else
                btnUser13.Text = Properties.Settings.Default.btn13;

            if (btnUser14.Text == Properties.Settings.Default.btn14)
            {
                btnUser14.Visible = false;
            }
            else
                btnUser14.Text = Properties.Settings.Default.btn14;

        }
        /*_____________________________________________________________________________________________________________________________________________*/









        /*-------------------------------------------------------------------------------------------------------------------------------------
     *   1.BUTTON WHICH OPEN THE NEW PANEL TO ADD THE USER AND THE 2. ADD BUTTON ON THIS PANEL WILL ADD THE USER .3.THIS WILL CLOSE THE PANEL
     *---------------------------------------------------------------------------------------------------------------------------------------*/

        private void btnAddUser_Click(object sender, EventArgs e)   //1.
        {
            if (panelAddUser.Visible == true)
            {

                panelAddUser.Visible = false;
                // panel1.Enabled = true;
            }
            else
            {
                panelAddUser.Visible = true;
                //panel1.Enabled = false;
            }
            panel8.Visible = false;
        }


        private void btn_PnlAddUser_Add_Click(object sender, EventArgs e)  //2.
        {
            if (btnUser1.Text == "")
            {

                btnUser1.Text = txtName.Text; ;
                Properties.Settings.Default.btn1 = txtName.Text;

                btnUser1.Visible = true;
                Properties.Settings.Default.Save();



            }

            else if (btnUser2.Text == "")
            {

                btnUser2.Text = txtName.Text; ;
                Properties.Settings.Default.btn2 = txtName.Text;
                btnUser2.Visible = true;
                // Properties.Settings.Default.Save();
            }
            else if (btnUser3.Text == "")
            {
                btnUser3.Text = txtName.Text; ;
                Properties.Settings.Default.btn3 = txtName.Text;
                btnUser3.Visible = true;
                // Properties.Settings.Default.Save();
            }
            else if (btnUser4.Text == "")
            {
                btnUser4.Text = txtName.Text; ;
                Properties.Settings.Default.btn4 = txtName.Text;
                btnUser4.Visible = true;
            }
            else if (btnUser5.Text == "")
            {
                btnUser5.Text = txtName.Text; ;
                Properties.Settings.Default.btn5 = txtName.Text;
                btnUser5.Visible = true;
            }
            else if (btnUser6.Text == "")
            {
                btnUser6.Text = txtName.Text;
                Properties.Settings.Default.btn6 = txtName.Text;
                btnUser6.Visible = true;
            }
            else if (btnUser7.Text == "")
            {
                btnUser7.Text = txtName.Text;
                Properties.Settings.Default.btn7 = txtName.Text;
                btnUser7.Visible = true;
            }
            else if (btnUser8.Text == "")
            {
                btnUser8.Text = txtName.Text;
                Properties.Settings.Default.btn8 = txtName.Text;
                btnUser8.Visible = true;
            }
            else if (btnUser9.Text == "")
            {
                btnUser9.Text = txtName.Text;
                Properties.Settings.Default.btn9 = txtName.Text;
                btnUser9.Visible = true;
            }
            else if (btnUser10.Text == "")
            {
                btnUser10.Text = txtName.Text;
                Properties.Settings.Default.btn10 = txtName.Text;
                btnUser10.Visible = true;
            }
            else if (btnUser11.Text == "")
            {
                btnUser11.Text = txtName.Text;
                Properties.Settings.Default.btn11 = txtName.Text;
                btnUser11.Visible = true;
            }
            else if (btnUser12.Text == "")
            {
                btnUser12.Text = txtName.Text;
                Properties.Settings.Default.btn12 = txtName.Text;
                btnUser12.Visible = true;
            }
            else if (btnUser13.Text == "")
            {
                btnUser13.Text = txtName.Text;
                Properties.Settings.Default.btn13 = txtName.Text;
                btnUser13.Visible = true;
            }
            else if (btnUser14.Text == "")
            {
                btnUser14.Text = txtName.Text;
                Properties.Settings.Default.btn14 = txtName.Text;
                btnUser14.Visible = true;
            }
            else
                MessageBox.Show("You Can't add any more user", "Add user message");
            Properties.Settings.Default.Save();
            panelAddUser.Visible = false;
            panel8.Visible = false;
        }


        private void btn_PnlAddUser_Cancel_Click(object sender, EventArgs e)//3. 
        {
            panelAddUser.Visible = false;
            panel8.Visible = false;
        }

        /*______________________________________________________________________________________________________________________________________________*/






        public bool ButtonClick() //this function will hide all the view button except one which is requesting to visible 
        {
            btnView1.Visible = false;
            btnView2.Visible = false;
            btnView3.Visible = false;
            btnView4.Visible = false;
            btnView5.Visible = false;
            btnView6.Visible = false;
            btnView7.Visible = false;
            btnView8.Visible = false;
            btnView1.Visible = false;
            btnView9.Visible = false;
            btnView10.Visible = false;
            btnView11.Visible = false;
            btnView12.Visible = false;
            btnView13.Visible = false;
            btnView14.Visible = false;

            return true;
        }


        /*----------------------------------------------------------------------------------------------------------------------------------------
         *                                                                  ALL THE USER BUTTON  ON THE LEFT SIDE OF CONTROLS
         *----------------------------------------------------------------------------------------------------------------------------------------*/

        private void btnUser1_Click_1(object sender, EventArgs e)
        {

            btnView1.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 1;
        }


        private void btnUser2_Click(object sender, EventArgs e)
        {
            btnView2.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 2;
        }


        private void btnUser3_Click(object sender, EventArgs e)
        {
            btnView3.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 3;
        }



        private void btnUser4_Click(object sender, EventArgs e)
        {
            btnView4.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 4;
        }


        private void btnUser5_Click(object sender, EventArgs e)
        {
            btnView5.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 5;
        }


        private void btnUser6_Click(object sender, EventArgs e)
        {
            btnView6.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 6;

        }


        private void btnUser7_Click(object sender, EventArgs e)
        {
            btnView7.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 7;
        }


        private void btnUser8_Click(object sender, EventArgs e)
        {
            btnView8.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 8;
        }


        private void btnUser9_Click(object sender, EventArgs e)
        {
            btnView9.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 9;
        }


        private void btnUser10_Click(object sender, EventArgs e)
        {
            btnView10.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 10;
        }


        private void btnUser11_Click(object sender, EventArgs e)
        {
            btnView11.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 11;
        }


        private void btnUser12_Click(object sender, EventArgs e)
        {
            btnView12.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 12;
        }


        private void btnUser13_Click(object sender, EventArgs e)
        {
            btnView13.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 13;
        }


        private void btnUser14_Click(object sender, EventArgs e)
        {
            btnView14.Visible = ButtonClick();
            pnlDetails.Visible = false;
            buttonNo = 14;
        }



        /*________________________________________________________________________________________________________________________________________________*/






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PanelDetails()
        {
            if (pnlDetails.Visible == true)
                pnlDetails.Visible = false;
            else
                pnlDetails.Visible = true;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------
         *                      ALL THE VIEW BUTTON NEXT TO THE USER BUTTON
         *----------------------------------------------------------------------------------------------------------------------------------------*/

        private void btnView1_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView3_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView4_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView5_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView6_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView7_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView8_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView9_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView10_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView11_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView12_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView13_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }

        private void btnView14_Click(object sender, EventArgs e)
        {
            PanelDetails();
        }




        /*_______________________________________________________________________________________________________________________________________________*/


       


       
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            panel8.Visible = true;


            //progressBar1.Value += 20;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = null;
        }

        private void txtPassword_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        public void RemoveUser(int buttonNo)// function which handels all the button while removing the user. this function will remove the user button as well as view button next to it
        {
            switch (buttonNo)
            {
                case 1:
                    {
                        Properties.Settings.Default.btn1 = "";
                        btnUser1.Visible = false;
                        btnView1.Visible = false;
                        break;
                    }
                case 2:
                    {
                        Properties.Settings.Default.btn2 = "";
                        btnUser2.Visible = false;
                        btnView2.Visible = false;
                        break;
                    }
                case 3:
                    {
                        Properties.Settings.Default.btn3 = "";
                        btnUser3.Visible = false;
                        btnView3.Visible = false;
                        break;
                    }
                case 4:
                    {

                        Properties.Settings.Default.btn4 = "";
                        btnUser4.Visible = false;
                        btnView4.Visible = false;
                        break;
                    }
                case 5:
                    {

                        Properties.Settings.Default.btn5 = "";
                        btnUser5.Visible = false;
                        btnView5.Visible = false;
                        break;
                    }
                case 6:
                    {

                        Properties.Settings.Default.btn6 = "";
                        btnUser6.Visible = false;
                        btnView6.Visible = false;
                        break;
                    }
                case 7:
                    {

                        Properties.Settings.Default.btn7 = "";
                        btnUser7.Visible = false;
                        btnView7.Visible = false;
                        break;
                    }
                case 8:
                    {

                        Properties.Settings.Default.btn8 = "";
                        btnUser8.Visible = false;
                        btnView8.Visible = false;
                        break;
                    }
                case 9:
                    {

                        Properties.Settings.Default.btn9 = "";
                        btnUser9.Visible = false;
                        btnView9.Visible = false;
                        break;
                    }
                case 10:
                    {

                        Properties.Settings.Default.btn10 = "";
                        btnUser10.Visible = false;
                        btnView10.Visible = false;
                        break;
                    }
                case 11:
                    {

                        Properties.Settings.Default.btn11 = "";
                        btnUser11.Visible = false;
                        btnView11.Visible = false;
                        break;
                    }
                case 12:
                    {

                        Properties.Settings.Default.btn12 = "";
                        btnUser12.Visible = false;
                        btnView12.Visible = false;
                        break;
                    }
                case 13:
                    {

                        Properties.Settings.Default.btn13 = "";
                        btnUser13.Visible = false;
                        btnView13.Visible = false;
                        break;
                    }
                case 14:
                    {

                        Properties.Settings.Default.btn14 = "";
                        btnUser14.Visible = false;
                        btnView14.Visible = false;
                        break;
                    }


            }
            Properties.Settings.Default.Save();


        }



        /*---------------------------------------------------------------------------------------------------------------------
         *                  THIS TWO BUTTON IS ON DETAILS PANEL 1. IS CALLING THE REMOVEUSER FUNCTION TO REMOVE 2. HIDE THE PANEL WHEN UPPAR LEFT CORNER BUTTON IS PRESSES
         *----------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void pnlDetails_RemoveUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to remove this user", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RemoveUser(buttonNo);
                MessageBox.Show("This user is removed", "Removed user");
            }

            pnlDetails.Visible = false;
        }

        private void btnHide_PnlDetails_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
        }


    }
}  