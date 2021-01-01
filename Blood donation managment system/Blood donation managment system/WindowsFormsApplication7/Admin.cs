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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent(); listboxdata();

            try
            {
                database.con.Open();
                SqlCommand csd = new SqlCommand("select * from blood", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    comboBox1BG.Items.Add(srr["Blood_Type"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (userID.Text.Contains(" ") || userPASS.Text.Contains(" "))
            {
                errorProvider1.SetError(userID, "No spaces");
                errorProvider1.SetError(userPASS, "No spaces");
            }
            else
            {
                if (name_.Text == String.Empty | userID.Text == String.Empty | userPASS.Text == String.Empty | contactno.Text == String.Empty | dateofbirth.Text == String.Empty | gender.Text == String.Empty | comboBox1BG.Text == String.Empty | CNIC.Text == String.Empty | type_.Text == String.Empty)
                {
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    if (name_.Text != String.Empty && userID.Text != String.Empty && userPASS.Text != String.Empty && contactno.Text != String.Empty && dateofbirth.Text != String.Empty && gender.Text != String.Empty && comboBox1BG.Text != String.Empty && CNIC.Text != String.Empty && type_.Text != String.Empty)
                    {
                        database.con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select * From Employee where E_Username ='" + userID.Text + "'", database.con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Username Already Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            database.con.Close();
                        }
                        else
                        {
                            try
                            {
                                signup data = new signup(name_.Text, userID.Text, userPASS.Text, gender.Text, contactno.Text, dateofbirth.Text);
                                SqlCommand scmd = new SqlCommand("insert into Employee values('" + data.name + "','" + data.username + "','" + data.password + "','" + data.gender + "','" + data.contactNo + "','" + comboBox1BG.Text + "','" + data.DOB + "','" + CNIC.Text + "','"+ type_.Text+"')", database.con);
                                int o = scmd.ExecuteNonQuery();
                                MessageBox.Show("Sign Up Process Complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                database.con.Close();
                                name_.Text = "";
                                userID.Text = "";
                                userPASS.Text = "";
                                gender.Text = "";
                                contactno.Text = "";
                                dateofbirth.Text = "";
                                comboBox1BG.Text = "";
                                CNIC.Text = "";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.con.Close(); listboxdata();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name_.Text = "";
            userID.Text = "";
            userPASS.Text = "";
            gender.Text = "";
            contactno.Text = "";
            dateofbirth.Text = "";
            comboBox1BG.Text = "";
            CNIC.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (userID.Text.Contains(" ") || userPASS.Text.Contains(" "))
            {
                errorProvider1.SetError(userID, "No spaces");
                errorProvider1.SetError(userPASS, "No spaces");
            }
            else
            {
                errorProvider1.Clear();
                if (name_.Text == String.Empty | userID.Text == String.Empty | userPASS.Text == String.Empty | contactno.Text == String.Empty | dateofbirth.Text == String.Empty | gender.Text == String.Empty | comboBox1BG.Text == String.Empty | CNIC.Text == String.Empty | type_.Text == String.Empty)
                {
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    if (name_.Text != String.Empty && userID.Text != String.Empty && userPASS.Text != String.Empty && contactno.Text != String.Empty && dateofbirth.Text != String.Empty && gender.Text != String.Empty && comboBox1BG.Text != String.Empty && CNIC.Text != String.Empty && type_.Text != String.Empty)
                    {
                        try
                            {
                                signup data = new signup(name_.Text, userID.Text, userPASS.Text, gender.Text, contactno.Text, dateofbirth.Text);
                                SqlCommand scmd = new SqlCommand("update Employee set E_name='" + data.name + "',E_username='" + data.username + "',E_password='" + data.password + "',Gender='" + data.gender + "',contactNo='" + data.contactNo + "',Blood_Group='" + comboBox1BG.Text + "',DOB='" + data.DOB + "',CNIC='" + CNIC.Text + "',Type='" + type_.Text + "' where E_id='" + listBox1.SelectedItem+"'", database.con);
                            database.con.Open();
                            int o = scmd.ExecuteNonQuery();
                                MessageBox.Show("Account Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            database.con.Close();
                                name_.Text = "";
                                userID.Text = "";
                                userPASS.Text = "";
                                gender.Text = "";
                                contactno.Text = "";
                                dateofbirth.Text = "";
                                comboBox1BG.Text = "";
                                CNIC.Text = "";
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.con.Close(); listboxdata();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    database.con.Open();
                    SqlCommand scmd = new SqlCommand("Delete from Employee where E_id='" + listBox1.SelectedItem + "'", database.con);
                    scmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.con.Close(); listboxdata();
                }
            }
            else if (dr == DialogResult.No) { }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("select * from Employee where E_id = '" + listBox1.SelectedItem + "'", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    userID.Text = sd["E_username"].ToString();
                    userPASS.Text = sd["E_password"].ToString();
                    gender.Text = sd["Gender"].ToString();
                    contactno.Text = sd["contactno"].ToString();
                    dateofbirth.Text = sd["DOB"].ToString();
                    name_.Text= sd["E_Name"].ToString();
                    comboBox1BG.Text = sd["Blood_Group"].ToString();
                    CNIC.Text= sd["CNIC"].ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f1 = new Form2();
            f1.Show();
        }
        public void listboxdata()
        {
            try
            {
                listBox1.Items.Clear();
                SqlCommand sc = new SqlCommand("select * from Employee", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    listBox1.Items.Add(sd["E_id"]);
                }
                database.con.Close();
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

        private void userID_Leave(object sender, EventArgs e)
        {
            if (userID.Text.Contains(" ") || userPASS.Text.Contains(" "))
            {
                errorProvider1.SetError(userID, "No spaces");
                errorProvider1.SetError(userPASS, "No spaces");
            }
            else
            { errorProvider1.Clear(); }
            }

        private void userPASS_Leave(object sender, EventArgs e)
        {
            if (userID.Text.Contains(" ") || userPASS.Text.Contains(" "))
            {
                errorProvider1.SetError(userID, "No spaces");
                errorProvider1.SetError(userPASS, "No spaces");
            }
            else
            { errorProvider1.Clear(); }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
} 