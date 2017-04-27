using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SIM
{
    public partial class UserControlFaculty : UserControl
    {
        FacultyEntities facultyEntities;
        int delete = 0, update = 0, added = 0, check = 0;
        public UserControlFaculty()
        {
            InitializeComponent();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            panelStudentAdd.Visible = false;
            panelStudentAdd.Enabled = false;
            dataGridView1.Enabled = true;
            btn_F_AddStudentExtand.Visible = false;
            labelDBstatus.Text = "Database is currently active";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection conn = new SqlConnection(source))
                //{
                //conn.Open();
                panelStudentAdd.Visible = true;
                panelStudentAdd.Enabled = true;
                dataGridView1.Enabled = false;
                labelDBstatus.Text = "Database is currently inactive";
                btn_F_Add.Enabled = true;
                btn_F_Add.Visible = true;
                btn_F_AddStudentExtand.Visible = true;
                txtId.Focus();
                
                Faculty f = new Faculty();
                facultyEntities.Faculties.Add(f);
                facultyBindingSource.Add(f);
                facultyBindingSource.MoveLast();
                labelDOB.Visible = true;

                /* these setting are used because after pressing edit button (situated at the bottom of the dataGridView1) all below text box become disabled.
                 and hence new entry will not take value in these text boxes, so to make it usable again we need to enable these boxes again.*/
                txtId.Enabled = true;
                txt_F_Name.Enabled = true;
                txt_F_Father.Enabled = true;
                txtMother.Enabled = true;
                txt_F_DOB.Enabled = true;
                btn_F_Add.Visible = true;
                btn_F_Update.Visible = false;
                // }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddStudentExtand_Click(object sender, EventArgs e)
        {

        }
        private void btnAddStudentShort_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPic_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txt_F_Name.Text == "" || txt_F_Father.Text == "" || txtMother.Text == "" || txt_F_DOB.Text == "")
            {
                MessageBox.Show("Fields marked with ( * ) are compulsary", "Field Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    facultyBindingSource.EndEdit();
                    facultyEntities.SaveChangesAsync();
                    added++;
                    txt_F_CounterAdd.Text = added.ToString();
                    ///panelStatus.Enabled = true;
                    panelStatus.Enabled = true;
                    panelStatus.Visible = true;
                    labelAdd.Visible = true;
                    btn_F_Update.Enabled = false;
                    btn_F_Update.Visible = false;
                    //dataGridView1.Enabled = true;


                    txtId.Focus();
                    Faculty g = new Faculty();
                    facultyEntities.Faculties.Add(g);
                    facultyBindingSource.Add(g);
                    facultyBindingSource.MoveLast();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     facultyBindingSource.ResetBindings(false);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Tenroll = txtId.Text;
            try
            {
                int check = 0;
                facultyBindingSource.EndEdit();
                facultyEntities.SaveChangesAsync();
                panelStatus.Enabled = true;
                panelStatus.Visible = true;
                labelUpdate.Visible = true;

                if (Tenroll == txtId.Text)
                {
                    check++;
                }
                if (check == 1)
                {
                    update++;
                    txt_F_CounterUpdate.Text = update.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                facultyBindingSource.ResetBindings(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            facultyBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in facultyEntities.ChangeTracker.Entries())
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

        }

        private void btn_loadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldg = new OpenFileDialog();
            fldg.Filter = "JPG(*.jpg)|*.jpg|PNg(*.png)|*.png|All Files(*.*)|*.*";
            if (fldg.ShowDialog() == DialogResult.OK)
            {
                string imagePath = fldg.FileName.ToString();
                pBoxStudPic.ImageLocation = imagePath;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                btn_F_AddStudentExtand.Visible = false;
                panelStudent.Visible = false;
                panelStudent.Visible = true;
                //Students = new StudentEntities();
                facultyBindingSource.DataSource = facultyEntities.Faculties.ToList();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                try
                {
                    panelStudentAdd.Enabled = true;
                    panelStudentAdd.Visible = true;
                    txtId.Enabled = false;
                    txt_F_Name.Enabled = false;
                    txt_F_Father.Enabled = false;
                    txtMother.Enabled = false;
                    txt_F_DOB.Enabled = false;
                    btn_F_Update.Enabled = true;
                    btn_F_Update.Visible = true;
                    btn_F_Add.Enabled = false;
                    btn_F_Add.Visible = false;
                    facultyEntities.Faculties.Find(facultyBindingSource.Current as Student);
                    txtId.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_ext_add_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txt_F_Name.Text == "" || txt_F_Father.Text == "" || txtMother.Text == "" || txt_F_DOB.Text == "")
            {
                MessageBox.Show("Fields marked with ( * ) are compulsary", "Field Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    facultyBindingSource.EndEdit();
                    facultyEntities.SaveChangesAsync();
                    added++;
                    txt_F_CounterAdd.Text = added.ToString();
                    ///panelStatus.Enabled = true;
                    panelStatus.Enabled = true;
                    panelStatus.Visible = true;
                    labelAdd.Visible = true;
                    btn_F_Update.Enabled = false;
                    btn_F_Update.Visible = false;
                    //dataGridView1.Enabled = true;


                    txtId.Focus();
                    Faculty g = new Faculty();
                    facultyEntities.Faculties.Add(g);
                    facultyBindingSource.Add(g);
                    facultyBindingSource.MoveLast();



                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    facultyBindingSource.ResetBindings(false);
                }
            }
        }

        private void btn_exe_update_Click(object sender, EventArgs e)
        {
            string Tenroll = txtId.Text;
            try
            {
                int check = 0;
                facultyBindingSource.EndEdit();
                facultyEntities.SaveChangesAsync();
                panelStatus.Enabled = true;
                panelStatus.Visible = true;
                labelUpdate.Visible = true;

                if (Tenroll == txtId.Text)
                {
                    check++;
                }
                if (check == 1)
                {
                    update++;
                    txt_F_CounterUpdate.Text = update.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                facultyBindingSource.ResetBindings(false);
            }
        }

        private void btn_ext_cancel_Click(object sender, EventArgs e)
        {
            facultyBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in facultyEntities.ChangeTracker.Entries())
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Enabled == true)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        facultyEntities.Faculties.Remove(facultyBindingSource.Current as Faculty);
                         facultyBindingSource.RemoveCurrent();
                         facultyBindingSource.EndEdit();
                         facultyEntities.SaveChanges();
                        panelStatus.Enabled = true;
                        panelStatus.Visible = true;
                        labelDel.Visible = true;
                        //labelDelete.Visible = true;

                        delete++;
                        txt_F_CoumterDelete.Text = delete.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         facultyBindingSource.ResetBindings(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void UserControlFaculty_Load(object sender, EventArgs e)
        {
           
            
           
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
                            facultyEntities.Faculties.Remove(facultyBindingSource.Current as Faculty);
                            facultyBindingSource.RemoveCurrent();
                            facultyBindingSource.EndEdit();
                            facultyEntities.SaveChanges();


                            panelStatus.Enabled = true;
                            panelStatus.Visible = true;
                            delete++;
                            txt_F_CoumterDelete.Text = delete.ToString();
                            labelDel.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Could not inserted into batabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            facultyBindingSource.ResetBindings(false);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("First Active the database\nBy pressing:-\n    1.Refresh button\n    2.Cancel button in Add student form  ", "Database Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
