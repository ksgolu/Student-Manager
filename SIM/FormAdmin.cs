using System;
using System.Windows.Forms;
//using Syncfusion.Windows.Forms.Tools;

namespace SIM
{
    public partial class SIM_Admin : Form
    {
        public int A = 0,check=0;
        public SIM_Admin()
        {

            InitializeComponent();
            
        }
        //------------------------------------------------------FORM CLOSING AND MINIMIZE SETTTING--------------------------------------------------------------
        private void SIM_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == 0)
            {
                if (MessageBox.Show("Are your sure to exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            if (check == 1)
            {
                Application.ExitThread();
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)//This button is situted at the top right corner of form1 to close the application

        {
            if (MessageBox.Show("Are your sure to exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                //e.Cancel = true;
            }
        }


      
        //---------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------ALL MOUSER HOVER AND MOUSE LEAVE RELATED LOGIC ----------------------------------------------------------- 



        private void btnUser1_MouseHover_1(object sender, EventArgs e)
        {
            panelUser1.Width = 191;
        }
        private void btnUser1_MouseLeave_1(object sender, EventArgs e)
        {
            if( A == 0)
            panelUser1.Width = 59;
            else if(A==1)
            {
                //panelUser1.Width = 59;
            }
            else
            {
                panelUser1.Width = 59;
            }
        }

        private void btnUser2_MouseHover(object sender, EventArgs e)
        {
            //panelUser6.Width = 191;
        }
        private void btnUser2_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        private void btnUser22_MouseHover(object sender, EventArgs e)
        {
            panelUser2.Width = 191;
        }

        private void btnUser22_MouseLeave(object sender, EventArgs e)
        {
            if (A == 0)
            {
                panelUser2.Width = 59;

            }
            else if(A==2)
            {
                //panelUser2.Width = 59;
            }
            else
            {
                panelUser2.Width = 59;
            }
        }
        private void btnUser3_MouseHover(object sender, EventArgs e)
        {
            panelUser3.Width = 191;
        }
        private void btnUser3_MouseLeave(object sender, EventArgs e)
        {
            if (A == 0)
            {
                panelUser3.Width = 59;

            }
            else if(A==3)
            {

            }
            else
            {
                panelUser3.Width = 59;
            }
            
        }

        private void btnUser4_MouseHover(object sender, EventArgs e)
        {
            
                panelUser4.Width = 191;
            
            
        }
        
        private void btnUser4_MouseLeave_1(object sender, EventArgs e)
        {
            if (A == 0)
            {
                panelUser4.Width = 59;

            }
            else if(A==4)
            {

            }
            else
            {
                panelUser4.Width = 59;
            }
            
        }

        private void btnUser5_MouseHover_1(object sender, EventArgs e)
        {
            panelUser5.Width = 191;
        }  

        private void btnUser5_MouseLeave_1(object sender, EventArgs e)
        {
            if (A == 0)
                panelUser5.Width = 59;
            else if(A==5)
            {

            }
            else
            {
                panelUser5.Width = 59;
            }

        }

        private void btnUser6_MouseHover(object sender, EventArgs e)//THis button is not usable because the name declare to this buton is  not usable
        {
          
        }

        private void btnUser6_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void btnUser66_MouseHover(object sender, EventArgs e)//button user66 is copy of button user6, because of some programming error i need to declare it again with the name of btnuser66
        {
            panelUser66.Width = 191;
        }

        private void btnUser66_MouseLeave(object sender, EventArgs e)
        {
            if (A == 0)
            {
                panelUser66.Width = 59;

            }
            else if(A==6)
            {

            }
            else
            {
                panelUser66.Width = 59;
            }
        }
        private void btnUser7_MouseHover(object sender, EventArgs e)
        {
            panelUser7.Width = 191;
        }

        private void btnUser7_MouseLeave(object sender, EventArgs e)
        {
            if (A == 0)
            {
                panelUser7.Width = 59;
            }
            else if(A==7)
            {

            }
            else
            {
                panelUser7.Width = 59;
            }
        }

       


        private void panelSelection_MouseHover(object sender, EventArgs e)
        {
            //panelSelection.Width = 118;
        }

        private void panelSelection_MouseLeave(object sender, EventArgs e)
        {
            //panelSelection.Width = 34;
        }


        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            //panelSelection.Width = 110;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            //panelSelection.Width = 35;
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            //panelSelection.Width = 110;
        }

        private void btnStudent_MouseLeave(object sender, EventArgs e)
        {
            //panelSelection.Width = 35;
        }

        private void btnFaculty_MouseHover(object sender, EventArgs e)
        {
            //panelSelection.Width = 110;
        }

        private void btnFaculty_MouseLeave(object sender, EventArgs e)
        {
            //panelSelection.Width = 35;
        }

        private void btnStaff_MouseHover(object sender, EventArgs e)
        {
            //panelSelection.Width = 110;
        }

        private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
            //panelSelection.Width = 35;
        }
        
//======================================================================END OF MOUSE HOVER AND MOUSE LEAVE LOGICL----------------------------------------------------------- 


       
        private void button2_MouseHover(object sender, EventArgs e)
        {
            //button2.BackColor.GetBrightness();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //button2.Width = 112;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           // button2.Width = 69;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




//---------------------------------------------------------------BtnView SETTING AND PanelDetails OF USER AND ADDUSER PANEL SETTING------------------------------------------------------
        

        private void btnHide_Click(object sender, EventArgs e)//this button is located on panelDetails.
        { 
            groupBoxDetails.Visible = false;
            //btnHide.Visible = false;
            switch( A)
            {
                case 1:
                    {
                       
                        btnView1.Visible = true;

                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                       // panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                       // btnView8.Visible = false;
                        btnView7.Visible = false;



                        break;
                    }
                case 2:
                    {
                       
                        btnView2.Visible = true;



                        panelUser1.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                        //panelUser8.Width = 56;
                        btnView1.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                        btnView7.Visible = false;
                        //btnView8.Visible = false;
                        break;
                    }
                case 3:
                    {
                        btnView3.Visible = true;
                        panelUser2.Width = 56;
                        panelUser1.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                       // panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView1.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                        btnView7.Visible = false;
                        //btnView8.Visible = false;
                        
                        break;
                    }
                case 4:
                    {
                        btnView4.Visible = true;
                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser1.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                        //panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView1.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                        btnView7.Visible = false;
                        //btnView8.Visible = false;
                        
                        break;
                    }
                case 5:
                    {
                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser1.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                        //panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView1.Visible = false;
                        btnView6.Visible = false;
                        btnView7.Visible = false;
                        //btnView8.Visible = false;
                        btnView5.Visible = true;
                        break;
                    }
                case 6:
                    {
                        btnView6.Visible = true;
                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser1.Width = 56;
                        panelUser7.Width = 56;
                        //panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView1.Visible = false;
                        btnView7.Visible = false;
                        //btnView8.Visible = false;
                        
                        break;
                    }
                case 7:
                    {
                        btnView7.Visible = true;
                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser1.Width = 56;
                        //panelUser8.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                        btnView1.Visible = false;
                       // btnView8.Visible = false;
                        
                        break;
                    }
                case 8:
                    {
                        //btnView8.Visible = true;
                        panelUser2.Width = 56;
                        panelUser3.Width = 56;
                        panelUser4.Width = 56;
                        panelUser5.Width = 56;
                        panelUser66.Width = 56;
                        panelUser7.Width = 56;
                        panelUser1.Width = 56;
                        btnView2.Visible = false;
                        btnView3.Visible = false;
                        btnView4.Visible = false;
                        btnView5.Visible = false;
                        btnView6.Visible = false;
                        btnView7.Visible = false;
                        btnView1.Visible = false;
                        
                        break;
                    }
            }
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            btnView1.Visible = false;

                       
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            btnView2.Visible = false;

            
        }
        private void btnView3_Click_1(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            btnView3.Visible = false;

        }

        private void btnView4_Click_1(object sender, EventArgs e)
        {

            groupBoxDetails.Visible = true;
            btnView4.Visible = false;
        }

        private void btnView5_Click_1(object sender, EventArgs e)
        {

            groupBoxDetails.Visible = true;
            btnView5.Visible = false;
        }


        private void btnView6_Click_1(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            btnView6.Visible = false;
        }

        private void btnView7_Click_1(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            btnView7.Visible = false;
        }

       
        

        //==============================================================================================================================================================================================


        //----------------------------------------------------------------ADD USER BUTTON LOGIC-----------------------------------------------------------------------------------------



        private void btnUser1_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser1.Text == "1  Add User")
            {
                A = 1;
                panelAddUser.Visible = true;
                panelUser1.Width = 191;              

            }
            else
            {
                panelAddUser.Visible = false;
                A = 1;
                panelUser1.Width = 191;
                groupBoxDetails.Visible = true;
            }

        }

        private void btnUser2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnUser22_Click_1(object sender, EventArgs e) //btnUser user 22 is copy of button of btunUser2 . this is beacuse some problem in programming i need to create this. 
        {
            panelUser1.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser22.Text == "1  Add User")
            {
                A = 2;
                panelAddUser.Visible = true;
                panelUser2.Width = 191;
            }
            else
            {
                A = 2;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser2.Width = 191;                
            }

        }
        private void btnUser3_Click(object sender, EventArgs e)
        {
            //panelUser3.Width = 56;
            panelUser2.Width = 56;
            panelUser1.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser3.Text == "1  Add User")
            {
                A = 3;
                panelAddUser.Visible = true;
                panelUser3.Width = 191;
            }
            else
            {
                A = 3;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser3.Width = 191;
            }
        }
        private void btnUser4_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser1.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser4.Text == "1  Add User")
            {
                A = 4;
                panelAddUser.Visible = true;
                panelUser4.Width = 191;
            }
            else
            {
                A = 4;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser4.Width = 191;
            }
        }
        private void btnUser5_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser1.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser5.Text == "1  Add User")
            {
                A = 5;
                panelAddUser.Visible = true;
                panelUser5.Width = 191;
            }
            else
            {
                A = 5;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser5.Width = 191;
            }
        }
        private void btnUser66_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser1.Width = 56;
            panelUser7.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser66.Text == "1  Add User")
            {
                A = 6;
                panelAddUser.Visible = true;
                panelUser66.Width = 191;
            }
            else
            {
                A = 6;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser66.Width = 191;
            }
        }
        private void btnUser7_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser1.Width = 56;
            //panelUser8.Width = 56;
            if (btnUser7.Text == "1  Add User")
            {
                A = 7;
                panelAddUser.Visible = true;
                panelUser7.Width = 191;
            }
            else
            {
                A = 7;
                panelAddUser.Visible = false;
                groupBoxDetails.Visible = true;
                panelUser7.Width = 191;
            }
        }

        private void btnUser8_Click(object sender, EventArgs e)
        {
            panelUser2.Width = 56;
            panelUser3.Width = 56;
            panelUser4.Width = 56;
            panelUser5.Width = 56;
            panelUser66.Width = 56;
            panelUser7.Width = 56;
            panelUser1.Width = 56;
           
        }

        //=================================================================================END OF ADD USER BUTTON LOGIC-------------------------------------------------------------------



        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelSelection.Width==118)
            {
                panelSelection.Width = 34;
            }
            else
            {
                panelSelection.Width = 118;
            }

        }
        private void btnPanelDetailsAddUser_Click(object sender, EventArgs e)
        {
           
            this.btnUser1.Text = "1  Add User";
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            btnUser1.Text = "1  Add User";
        }

        private void btnUser1_TextChanged(object sender, EventArgs e)
        {
            btnUser1.Text = "1  " + txtName.ToString();
        }

          

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void panelSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       
        }

        
       
    
}
