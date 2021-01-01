using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            type.Text = "("+Form1.MyProperty+")";
            uName.Text = Form1.username;
                 try
            {
                database.con.Open();
                SqlCommand csd = new SqlCommand("select * from Employee where E_username='" + uName.Text + "'", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    id_display.Text = srr["E_id"].ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.con.Close();
            }

            try
            {
                database.con.Open();
                SqlCommand csd = new SqlCommand("select * from blood", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    comboBox1.Items.Add(srr["Blood_Type"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.con.Close();
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Logout", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (dr == DialogResult.No)
            {
            }
        }

        private void ClearAll_btn_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Logout", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (dr == DialogResult.No)
            {
            }
            }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donor_Form d = new Donor_Form();
            d.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void removeDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveDonor rd = new RemoveDonor();
            rd.Show();

        }

        private void addDonationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonationForm df = new DonationForm();
            df.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory i = new Inventory();
            i.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Donor_donated.Checked == true)
            {
                if (radioButName.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation where Name='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
                else if (radioButBloodG.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation where Blood_Group='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
            }
            else if (All_donor.Checked==true)
            {
                if (radioButName.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor where D_Name='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
                else if (radioButBloodG.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor where Blood_Group='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
            }
            else if (EmployeedonatedRadio.Checked == true)
            {
                if (radioButName.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D where E_Name='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
                else if (radioButBloodG.Checked == true)
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D  where BloodGroup='" + comboBox1.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        database.con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("All Donor or Donor Donated or Employee Donated not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Donor_donated.Checked == true)
            {
                    try
                    {
                    database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation where Date='" + dateTimePicker_search.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    database.con.Close();
                    }
            }
            else if (All_donor.Checked == true)
            {
                    try
                    {
                    database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor where Previous_D_Date='" + dateTimePicker_search.Text + "'", database.con);
                        DataTable d = new DataTable();
                        csd.Fill(d);
                        dataGridView_search.DataSource = d;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    database.con.Close();
                    }
            }
            else if (EmployeedonatedRadio.Checked == true)
            {
                try
                {
                    database.con.Open();
                    SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D where Date='" + dateTimePicker_search.Text + "'", database.con);
                    DataTable d = new DataTable();
                    csd.Fill(d);
                    dataGridView_search.DataSource = d;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.con.Close();
                }
            }
            else
            {
                MessageBox.Show("All Donor or Donor Donated or Employee Donated not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword c = new ChangePassword();
            c.Show();

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            INFO i = new INFO();
            i.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = Form1.MyProperty;
            if (username == "Admin") { 
            this.Hide();
            Admin i = new Admin();
            i.Show();
            }
            else
            {
                MessageBox.Show("Admin Allowed Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

