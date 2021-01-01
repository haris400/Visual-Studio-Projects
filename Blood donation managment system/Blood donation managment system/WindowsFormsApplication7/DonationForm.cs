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
    public partial class DonationForm : Form
    {
        public DonationForm()
        {
            InitializeComponent();
            listboxdata();

            try
            {
                database.con.Open();
                SqlCommand csd = new SqlCommand("select * from blood", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    comboBox1BGsearch.Items.Add(srr["Blood_Type"].ToString());
                    comboBox2BloodG.Items.Add(srr["Blood_Type"].ToString());
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1Name.Text = "";
            BAmounbt.ResetText();
            comboBox2BloodG.ResetText();
            comboBox1BGsearch.ResetText();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Select Donor or Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (radioButton1.Checked == true)
            {
                if (textBox1Name.Text != string.Empty && comboBox2BloodG.Text != string.Empty && BAmounbt.Text != string.Empty)
                {
                    try
                    {
                        database.con.Open();
                        SqlCommand csd = new SqlCommand("insert into Employee_D values('" + listBox2.SelectedItem + "','" + textBox1Name.Text + "','" + BAmounbt.Text.ToString() + "','" + DonationDate.Text + "','" + comboBox2BloodG.Text + "')", database.con);
                        csd.ExecuteNonQuery();
                        MessageBox.Show("Info Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1Name.Text = "";
                        BAmounbt.ResetText();
                        comboBox2BloodG.ResetText();
                        DonationDate.ResetText();
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
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(radioButton2.Checked == true) {
                if (textBox1Name.Text != string.Empty && comboBox2BloodG.Text != string.Empty && BAmounbt.Text != string.Empty)
                {
                    try
                    {
                        database.con.Open();
                        SqlCommand csd = new SqlCommand("insert into Donor_Donation values('" + listBox1.SelectedItem+ "','" + textBox1Name.Text + "','" + comboBox2BloodG.Text + "','" + BAmounbt.Text.ToString() + "','" + DonationDate.Text + "')", database.con);
                        csd.ExecuteNonQuery();
                        MessageBox.Show("Info Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1Name.Text = "";
                        BAmounbt.ResetText();
                        comboBox2BloodG.ResetText();
                        DonationDate.ResetText();
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
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Select Donor or Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radioButton1.Checked == true)
            {
                try
                {
                    database.con.Open();
                    SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D where bloodgroup='" + comboBox1BGsearch.Text + "'", database.con);
                    DataTable d = new DataTable();
                    csd.Fill(d);
                    dataGridView1.DataSource = d;
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
            else if (radioButton2.Checked == true)
            {
                try
                {
                    database.con.Open();
                    SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation where blood_group='" + comboBox1BGsearch.Text + "'", database.con);
                    DataTable d = new DataTable();
                    csd.Fill(d);
                    dataGridView1.DataSource = d;
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

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void DonationForm_Load(object sender, EventArgs e)
        {

        }
        public void listboxdata()
        {
            try
            {
                listBox2.Items.Clear();
                SqlCommand sc = new SqlCommand("select * from Employee ", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    listBox2.Items.Add(sd["E_id"]);
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
                listBox1.Items.Clear();
                SqlCommand sc = new SqlCommand("select * from Donor ", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    listBox1.Items.Add(sd["D_id"]);
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

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("select * from Donor where D_id = '" + listBox1.SelectedItem+ "'", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    textBox1Name.Text= sd["D_Name"].ToString();
                    comboBox2BloodG.Text = sd["Blood_Group"].ToString();
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

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("select * from Employee where E_id = '" + listBox2.SelectedItem + "'", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    textBox1Name.Text = sd["E_Name"].ToString();
                    comboBox2BloodG.Text = sd["Blood_Group"].ToString();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Select Donor or Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Warning );
            if (dr == DialogResult.Yes) {
                if (radioButton1.Checked == true)
                {
                        database.con.Open();
                    try
                    {
                        SqlCommand csd = new SqlCommand("Delete from Employee_D where E_id='" + listBox2.SelectedItem + "'", database.con);
                        csd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                            database.con.Close();
                            listboxdata();
                        }
                }
                else if (radioButton2.Checked == true)
                    {
                        database.con.Open();
                        try
                    {
                        SqlCommand csd = new SqlCommand("Delete from Donor_Donation where Donor_id='" + listBox1.SelectedItem + "'", database.con);
                        csd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                            database.con.Close();
                            listboxdata();
                        }
                }
                else if(dr == DialogResult.No)
                {
                   
                }
            }
            }
        }
    }
}
