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
   
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();
           string uName = Form1.username;
            try
            {
                database.con.Open();
                SqlCommand csd = new SqlCommand("select * from Employee where E_username='" + uName + "'", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    textBoxID.Text = srr["E_id"].ToString();
                    name_.Text = srr["E_Name"].ToString();
                    userID.Text = srr["E_username"].ToString();
                    gender.Text = srr["Gender"].ToString();
                    contactno.Text = srr["ContactNo"].ToString();
                    dateofbirth.Text = srr["DOB"].ToString();
                    comboBox1BG.Text = srr["Blood_Group"].ToString();
                    CNIC.Text = srr["CNIC"].ToString();
                    type_.Text = srr["Type"].ToString();
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
            this.Close();
            Form2 f = new Form2();
            f.Show();

        }

        private void INFO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name_.Enabled != true) {
                name_.Enabled = true;
                gender.Enabled = true;
                contactno.Enabled = true;
                dateofbirth.Enabled = true;
                comboBox1BG.Enabled = true;
                CNIC.Enabled = true;
            }else if (name_.Enabled == true) {
                name_.Enabled = false;
                gender.Enabled = false;
                contactno.Enabled = false;
                dateofbirth.Enabled = false;
                comboBox1BG.Enabled = false;
                CNIC.Enabled = false;
            
                    if (name_.Text == String.Empty | userID.Text == String.Empty | contactno.Text == String.Empty | dateofbirth.Text == String.Empty | gender.Text == String.Empty | comboBox1BG.Text == String.Empty | CNIC.Text == String.Empty)
                    {
                        MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                    if (name_.Text != String.Empty && userID.Text != String.Empty &&  contactno.Text != String.Empty && dateofbirth.Text != String.Empty && gender.Text != String.Empty && comboBox1BG.Text != String.Empty && CNIC.Text != String.Empty)
                    {
                        try
                        {
                            signup data = new signup(name_.Text, userID.Text, "", gender.Text, contactno.Text, dateofbirth.Text);
                            SqlCommand scmd = new SqlCommand("update Employee set E_name='" + data.name + "',E_username='" + data.username + "',Gender='" + data.gender + "',contactNo='" + data.contactNo + "',Blood_Group='" + comboBox1BG.Text + "',DOB='" + data.DOB + "',CNIC='" + CNIC.Text + "' where E_id='" + int.Parse(textBoxID.Text) + "'", database.con);
                            database.con.Open();
                            int o = scmd.ExecuteNonQuery();
                            MessageBox.Show("Account Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }

