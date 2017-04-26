using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
//using Sim;
//using System.Windows.Forms;








/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                            NAMESPACE AND FORM 1 SETTING(CLOSING, MINIMIZING)

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

namespace SIM
{
    //string source = "data source = SATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";

    public partial class Form1 : Form
    {
        //string source = "data source = SATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";
        int delete = 0, update = 0, added = 0, check = 0; //this golbel variable is counter for update,delete and add button. and these are reset to ( 0 ) when ok button of panelStatus is pressed

        bool ActiveStatus,Admin;
        string userId, Password;
        //geuStudentEntities studentEntities;
        StudentEntities studentEntities;
        public Form1(string userid,string Password ,bool ActiveStatus,bool Admin)
        {
            this.ActiveStatus = ActiveStatus;
            userId = userid;
            this.Password = Password;
            this.Admin = Admin;
            InitializeComponent();

            string source = "data source = KUMARSATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";
           

            try
            {
                using (SqlConnection conn = new SqlConnection(source))
                {
                    SqlCommand cmd = new SqlCommand(" select * from LoginTabel where UserId= '" + userid + "' ", conn);
                    SqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string name = dr.GetString(3);
                        labelProfile.Text = name;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroe while retiving name from datbase\n\n"+ex.Message);
            }



           

            /* Login form = new Login();
             form.Show();*/
            /*  //geuEntities test;
              SqlConnection conn = new SqlConnection();
              conn.ConnectionString = "data source = SATYAM\\SQLEXPRESS;database = geu;integrated security = SSPI";
              SqlCommand cmd=new SqlCommand ("select * from gstudent",conn);
              conn.Open();
              SqlDataReader dr = cmd.ExecuteReader();


              BindingSource source = new BindingSource();
              source.DataSource = dr;
              dataGridView1.DataSource = source;
              conn.Close();*/


        }


        /*void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Logout";
            //frm.Text = "Wait Logout";

            Application.Run(frm);
        }*/


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'geuDataSet.gfaculty' table. You can move, or remove it, as needed.
            //  this.gfacultyTableAdapter.Fill(this.geuDataSet.gfaculty);

            /*
            try
            {
                using (SqlConnection conn = new SqlConnection(source))
                {
                    conn.Open();
                    test = new geuEntities();
                    gstudentBindingSource.DataSource = test.gstudents.ToList();
                    dataGridView1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TODO: This line of code loads data into the 'goluDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.goluDataSet.student);

            */

            if (ActiveStatus)
            {
                FormUserVerification frm = new FormUserVerification(userId, Password);
                frm.ShowDialog();
            }
            if (Admin)
            
                btnAmin.Visible = true;
            
            else
                btnAmin.Visible = false;

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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



        private void btnClose_Click_1(object sender, EventArgs e)//This button is situted at the top right corner of form1 to close the application
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



        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }


        //--------------------------------------------------------------------------------END OF NAMESPACE AND FORM 1 LOAD--------------------------------------------------------------------------------------







        /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                                       
                                                                                       ALL BUTTON COLOUR FUNCTION AND SOME OTHER FUNCTION USSED IN PROGRAMM

        ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                public Color MenuButtonColor(Button X)
                {
                    btnStudent.BackColor = Color.Black;
                    btnStaff.BackColor = Color.Black;
                    btnFaculty.BackColor = Color.Black;
                    return Color.Red;
                }

                public Color SearchButtonColor()
                {
                    btnNew.BackColor = Color.Black;
                    btnfilter.BackColor = Color.Black;
                    return Color.Blue;
                }

                public Color MenuShareColor()
                {
                    btnEmail.BackColor = Color.Black;
                    btnWhatsApp.BackColor = Color.Black;
                    btnMessage.BackColor = Color.Black;
                    return Color.Blue;
                }

        public bool EmailValidationCheck(string email)
        {
            bool validate = false;
            int status1 = 0;
            int status2 = 0;
            /*foreach (char ch in email)
            {
                if (ch == '@')
                    status1=1;
                else if (ch == '.')
                    status2++;
                else if

            }*/


            return (validate);
        }
        //-----------------------------------------------END OF  ALL USER-DEFINE FUNCTIONS'S DEFINATION USED IN THIS PROGRAM -----------------------------------------------------------------------------------------






        /*//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         *                                                                          
         *                                                                          MAIN STUDENT PANEL
    ===========================================================================================================================================================================================*/


        private void btnStudent_Click(object sender, EventArgs e)// students button on menu panel/menu selection which is dock in left side of window
        {
                   

            btnStudent.BackColor = MenuButtonColor(btnStudent);//here MenubtnColor is a function call which is define @ line no:-  171          

            labelSelect.Visible = false;
            labelSelection.Text = "STUDENT";
            try
            {
                panelStudent.Visible = true;        /*this block of code will only enable and visible the student panel other two panel will disable*/
               /* UserControlFaculty.Visible = false;
                UserControlStaff .Visible = false;*/
                userControlAdmin1.Visible=false;
                panelSearch.Visible = true;

                studentEntities = new StudentEntities();
                studentBindingSource.DataSource = studentEntities.Students.ToList();
                dataGridView1.Enabled = true;
                labelDBstatus.Text = "Database is currently active";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-------------------------------------------******************_____ALL   COMPONENT   AND   LOGIC   OF  STUDENT   FORM____*****************--------------------------------------------------------------------------------------



        
      //------------------ALL COMPONENT OF PANEL SEARCH--------------------------------------------------------------------------

        private void btnfilter_Click(object sender, EventArgs e)//This button will activate the search panel                                                           
        {
            //btnfilter.BackColor = SearchButtonColor();
            panelStudentAdd.Visible = false;
            panelStudentAdd.Enabled = false;
            dataGridView1.Enabled = true;
            btnAddStudentExtand.Visible = false;
            labelDBstatus.Text = "Database is currently active";
        }


    //------------------END  COMPONENT OF PANEL SEARCH--------------------------------------------------------------------------  




        //------------------ALL COMPONENT AND LOGIC OF PANEL Student ADD--------------------------------------------------------------------------     


        private void btnNew_Click_1(object sender, EventArgs e)//This button activate the paneladdStudent add and is used for adding new student in database                                                             
        {
            //btnNew.BackColor = SearchButtonColor();
            try
            {
                //using (SqlConnection conn = new SqlConnection(source))
                //{
                //conn.Open();
                panelStudentAdd.Visible = true;
                panelStudentAdd.Enabled = true;
                dataGridView1.Enabled = false;
                labelDBstatus.Text = "Database is currently inactive";
                btnAdd.Enabled = true;
                btnAdd.Visible = true;
                btnAddStudentExtand.Visible = true;
                txtEnrollNo.Focus();
                    Student g = new Student();
                 studentEntities.Students.Add(g);
                 studentBindingSource.Add(g);
                 studentBindingSource.MoveLast();
                labelDOB.Visible = true;

                /* these setting are used because after pressing edit button (situated at the bottom of the dataGridView1) all below text box become disabled.
                 and hence new entry will not take value in these text boxes, so to make it usable again we need to enable these boxes again.*/
                txtEnrollNo.Enabled = true;
                txtName.Enabled = true;
                txtFather.Enabled = true;
                txtMother.Enabled = true;
                txtDOB.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                // }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
         * this button is used to save the data of new student in database and can be used only when new button is clicked or panelAdd is visible
         * 
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEnrollNo.Text == "" || txtName.Text == "" || txtFather.Text == "" || txtMother.Text == "" || txtDOB.Text == "")
            {
                MessageBox.Show("Fields marked with ( * ) are compulsary", "Field Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    studentBindingSource.EndEdit();                   
                    studentEntities.SaveChangesAsync();
                    added++;
                    txtCounterAdd.Text = added.ToString();
                    ///panelStatus.Enabled = true;
                    panelStatus.Enabled = true;
                    panelStatus.Visible = true;
                    labelAdd.Visible = true;
                    btnUpdate.Enabled = false;
                    btnUpdate.Visible = false;
                    //dataGridView1.Enabled = true;


                     txtEnrollNo.Focus();
                     Student g = new Student();
                     studentEntities.Students.Add(g);
                     studentBindingSource.Add(g);
                     studentBindingSource.MoveLast();
                     


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   /* geuStudentBindingSource.ResetBindings(false);*/
                }
            }
        }


        /*this button is located in panelAddStudent and used to update the student information
         * this only visible when the Edit button (btnEdit ) is clicked which is located under bottom of datagridview
         * */
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Tenroll = txtEnrollNo.Text;
            try
            {
                int check = 0;
               studentBindingSource.EndEdit();
                studentEntities.SaveChangesAsync();
                panelStatus.Enabled = true;
                panelStatus.Visible = true;
                labelUpdate.Visible = true;
              
               if(Tenroll==txtEnrollNo.Text)
                {
                    check++;
                }
                if (check == 1)
                {
                    update++;
                    txtCounterUpdate.Text = update.ToString();
                }
       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            studentBindingSource.ResetBindings(false);
             foreach (DbEntityEntry entry in studentEntities.ChangeTracker.Entries())
             {
                 switch (entry.State)
                 {
                     case EntityState.Added:
                         {
                             entry.State = EntityState.Detached;
                             break;
                         }
                     case EntityState.Modified:
                         {
                             entry.State = EntityState.Unchanged;
                             break;
                         }
                     case EntityState.Deleted:
                         {
                             entry.Reload();
                             break;
                         }
                 }

             }
             panelStudentAdd.Enabled = false;
             panelStudentAdd.Visible = false;
             dataGridView1.Enabled = true;
             labelDBstatus.Text = "Database is currently active";
             //dataGridView1.;
        }


        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldg = new OpenFileDialog();
            fldg.Filter = "JPG(*.jpg)|*.jpg|PNg(*.png)|*.png|All Files(*.*)|*.*";
            if (fldg.ShowDialog() == DialogResult.OK)
            {
                string imagePath = fldg.FileName.ToString();
                pBoxStudPic.ImageLocation = imagePath;
            }
        }

        private void binCamera_Click(object sender, EventArgs e)
        {

        }





        //------------------END OF ALL COMPONENT OF PANEL ADD--------------------------------------------------------------------------



        //------------------ALL THE MISCELLNIOUS COMPONENT--------------------------------------------------------------------------



        private void btnProfile_Click(object sender, EventArgs e)

        {
            if (listBoxProfile.Visible == false)
            {
                listBoxProfile.Enabled = true;
                listBoxProfile.Visible = true;
            }
            else
            {
                listBoxProfile.Enabled = false;
                listBoxProfile.Visible = false;
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            update = 0;
            added = 0;
            delete = 0;
            panelStatus.Enabled = false;
            panelStatus.Visible = false;
        }




        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView1.DataSource = studentBindingSource;
                }
                else
                {
                    var query = from o in studentBindingSource.DataSource as List<Student>
                                where o.EnrollNo == txtSearch.Text || o.Name.Contains(txtSearch.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                try
                {
                    panelStudentAdd.Enabled = true;
                    panelStudentAdd.Visible = true;
                    txtEnrollNo.Enabled = false;
                    txtName.Enabled = false;
                    txtFather.Enabled = false;
                    txtMother.Enabled = false;
                    txtDOB.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnUpdate.Visible = true;
                    btnAdd.Enabled = false;
                    btnAdd.Visible = false;
                    studentEntities.Students.Find(studentBindingSource.Current as Student);
                    txtEnrollNo.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        studentEntities.Students.Remove(studentBindingSource.Current as Student);
                         studentBindingSource.RemoveCurrent();
                         studentBindingSource.EndEdit();
                         studentEntities.SaveChanges();
                        panelStatus.Enabled = true;
                        panelStatus.Visible = true;
                        labelDel.Visible = true;
                        //labelDelete.Visible = true;

                        delete++;
                        txtCoumterDelete.Text = delete.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         studentBindingSource.ResetBindings(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                         try
                         {
                             studentEntities.Students.Remove(studentBindingSource.Current as Student);
                             studentBindingSource.RemoveCurrent();
                             studentBindingSource.EndEdit();
                             studentEntities.SaveChanges();


                             panelStatus.Enabled = true;
                             panelStatus.Visible = true;
                             delete++;
                             txtCoumterDelete.Text = delete.ToString();
                             labelDel.Visible = true;
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             studentBindingSource.ResetBindings(false);
                         }
                    }
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void listBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBoxProfile.SelectedIndex;
            switch (a)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    { break; }
                case 2:
                    { break; }
                case 3:
                    { break; }
                case 4:
                    { break; }
                case 5:
                    {

                        check = 1;
                        Application.Restart();                      

                        break;
                    }
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddStudentExtand.Visible = false;
                panelStudent.Visible = false;
                panelStudent.Visible = true;
                //Students = new StudentEntities();
                studentBindingSource.DataSource = studentEntities.Students.ToList();
                panelStudentAdd.Visible = false;
                dataGridView1.Enabled = true;
                labelDBstatus.Text = "Database is currently active";
                panelStudent.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "mesage");
            }
        }


        //----------------------------------------------END OF MISCELLNIOUS---------------------------------------------------





        //----------------------------------------ALL COMPONENT OF PANEL SELECTION/MENU SELECTION-----------------------------








        private void btnStaff_Click(object sender, EventArgs e)
        {
            btnStaff.BackColor = MenuButtonColor(btnStaff);
            //panelSearch.Visible = false;
            
            panelStudent.Visible = false;
           /* UserControlFaculty.Visible = false;
            UserControlStaff.Visible = true;*/
            labelSelect.Visible = false;
            labelSelection.Text = "STAFF";

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (panelSelection.Width == 35)//&& panelSelection.Height==687)
            {
                for (int i = 35; i <= 113; i+=6)
                {
                    //panelSelection.Width = 97;
                    panelSelection.Width = i;
                }

            }
            else
            {
                for (int i = 113; i >= 35; i-=2)
                {
                    //panelSelection.Width = 97;
                    panelSelection.Width = i;
                }
                //panelSelection.Width = 34;
            }
        }

        //----------------------------------------END OF ALL COMPONENT OF PANEL SELECTION/MENU SELECTION-----------------------------


        //-------------------------------------------******************_____END OF ALL COMPONENT AND LOGIC OF STUDENT FORM____*****************--------------------------------------------------------------------------------------

    
            /////////////////////////////////////////////////////////////THESE ARE AUTO GENERATED METHODS HENCE CANNOT BE REMOVED//////////////////////////////////////////
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCounter_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }*/
        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            listBoxProfile.Enabled = false;
            listBoxProfile.Visible = false;
        }
        private void labelAdd_Click(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void label37_Click(object sender, EventArgs e)
        {

        }       
        private void label38_Click(object sender, EventArgs e)
        {

        }
        private void labelSelection_Click(object sender, EventArgs e)
        {

        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void gfacultyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.whatsAppMode)
            {
                System.Diagnostics.Process.Start("C:\\Users\\satya\\AppData\\Local\\WhatsApp\\app-0.2.3699\\WhatsApp.exe");
            }
            else
            {
                btnWhatsApp.BackColor = MenuShareColor();
                whatsApp frm = new whatsApp();
                frm.Show();
            }
               

        }
        private void whatsApp(int mode)
        {

        }
        private void whatsAppWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.whatsAppMode = true; //this set whatsApp mode=whatsApp web
            Properties.Settings.Default.Save();
        }
        private void whatsAppAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.whatsAppMode = false; //this set whatsApp mode=whatsApp Application
            Properties.Settings.Default.Save();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            btnMessage.BackColor = MenuShareColor();
            /*using (TextMessage frm = new TextMessage())
                frm.Show();*/
            TextMessage frm = new TextMessage();
            frm.Show();
            
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            btnEmail.BackColor = MenuShareColor();
            /*using (Email frm = new Email())
                frm.Show();*/
            Email frm = new Email();
            frm.Show();

        }

        private void btnAddStudentExtand_Click(object sender, EventArgs e)
        {
            panelStudentAdd.Visible = false;
            panelAddStudentExtended.Visible = true;
            /*for (int i = 306; i <=640; i+=25)
            {
                panelAddStudentExtended.Width = i;
            }*/
            btnfilter.Enabled = false;
            btnNew.Enabled = false;
            btnAddStudentExtand.Visible = false;
            //txt_ext_EnrollNo.Text=txtEnrollNo.Text;
        }

        private void btnAddStudentShort_Click(object sender, EventArgs e)
        {
            panelAddStudentExtended.Visible = false;
            panelStudentAdd.Visible = true;
            btnfilter.Enabled = true;
            btnNew.Enabled = true;
            btnAddStudentExtand.Visible = true;
        }

        private void txt_extEmail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cBx_ext_checkAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_ext_checkAddress.Checked)
                txt_ext_Raddress.Text = txt_ext_Paddress.Text;
            else
                txt_ext_Raddress.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(grpBxAdvSearch.Visible == false)
                grpBxAdvSearch.Visible = true;
            else
                grpBxAdvSearch.Visible = false;
        }

        private void btnAmin_Click(object sender, EventArgs e)
        {
            userControlAdmin1.Visible = true;
            panelStudent.Visible = false;
            


        }

        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void pBoxStudPic_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        //======================================================---------------- FACULTY PANEL-------------------==========================================================================================
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            btnFaculty.BackColor = MenuButtonColor(btnFaculty);
            //panelSearch.Visible = false;
            /*panelStudent.Visible = false;
            panelStaff.Visible = false;
            labelSelect.Visible = false;
           
            label92.Text = "FACULTY";
            try
            {
                panelFaculty.Visible = true;
               
                 /*facultyEntities = new geuEntitiesFaculty();
                 gfacultyBindingSource1.DataSource = facultyEntities.gfaculties.ToList();*/
             /*    dataGridViewFaculty.Enabled = true;
                 labelDBstatus.Text = "Database is currently active";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        //======================================================---------------- END OF FACULTY PANEL-------------------==========================================================================================


    }//closing of form


}//closing of namespace
