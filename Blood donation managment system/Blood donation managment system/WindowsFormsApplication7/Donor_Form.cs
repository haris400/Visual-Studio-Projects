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
    public partial class Donor_Form : Form
    {
        public Donor_Form()
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
                    BGroup.Items.Add(srr["Blood_Type"].ToString());

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
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_Name.ResetText();
            DOB.ResetText();
            Father_name.ResetText();
            textBox_diseases.ResetText();
            textBox_Address.ResetText();
            BGroup.ResetText();
            CNIC.ResetText();
            PhoneNo.ResetText();
            height.ResetText();
            ID.Text = "ID: ------";
            genderCombo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_Name.Text != string.Empty && Father_name.Text != string.Empty && DOB.Text != string.Empty && CNIC.Text != string.Empty && PhoneNo.Text != string.Empty && genderCombo.Text != string.Empty && textBox_Address.Text != string.Empty && height.Text != string.Empty && textBox_diseases.Text != string.Empty && BGroup.Text != string.Empty && donated_Date.Text != string.Empty)
            {
                try
                {
                    if (Donated_YES_rbtn.Checked == true)
                    {
                        database.con.Open();
                        SqlCommand csd = new SqlCommand("insert into Donor values('" + text_Name.Text + "','" + Father_name.Text + "','" + DOB.Text + "','" + CNIC.Text + "','" + PhoneNo.Text + "','" + genderCombo.Text + "','" + textBox_Address.Text + "','" + height.Text.ToString() + "','" + textBox_diseases.Text + "','" + BGroup.Text + "','" + Donated_YES_rbtn.Text + "','" + donated_Date.Text + "');", database.con);
                        csd.ExecuteNonQuery();
                        database.con.Close();
                        listboxdata();
                        MessageBox.Show("Info Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else {
                        database.con.Open();
                        SqlCommand csd = new SqlCommand("insert into Donor values('" + text_Name.Text + "','" + Father_name.Text + "','" + DOB.Text + "','" + CNIC.Text + "','" + PhoneNo.Text + "','" + genderCombo.Text + "','" + textBox_Address.Text + "','" + height.Text.ToString() + "','" + textBox_diseases.Text + "','" + BGroup.Text + "','" + Donated_NO_rbtn.Text + "','" + donated_Date.Text + "');", database.con);
                        csd.ExecuteNonQuery();
                        database.con.Close();
                        listboxdata();
                        MessageBox.Show("Info Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    text_Name.ResetText();
                    DOB.ResetText();
                    Father_name.ResetText();
                    textBox_diseases.ResetText();
                    textBox_Address.ResetText();
                    BGroup.ResetText();
                    CNIC.ResetText();
                    PhoneNo.ResetText();
                    height.ResetText();
                    ID.Text = "ID: ------";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Donated_YES_rbtn.Checked == true)
                {
                    SqlCommand csd = new SqlCommand("UPDATE Donor set D_name='" + text_Name.Text + "',D_Father_name='" + Father_name.Text + "',DOB='" + DOB.Text + "',CNIC='" + CNIC.Text + "',PhoneNo='" + PhoneNo.Text + "',Gender='" + genderCombo.Text + "',Address='" + textBox_Address.Text + "',Height='" + height.Text.ToString() + "',Disease='" + textBox_diseases.Text + "',Blood_Group='" + BGroup.Text + "',Donated_Before='" + Donated_YES_rbtn.Text + "',Previous_D_Date='" + donated_Date.Text + "' WHERE D_id='" + listBox1.SelectedItem + "'", database.con);
                    database.con.Open();
                    csd.ExecuteNonQuery();
                    MessageBox.Show("Info Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    database.con.Close();
                    listboxdata();
                }
                else {
                    SqlCommand csd = new SqlCommand("UPDATE Donor set D_name='" + text_Name.Text + "',D_Father_name='" + Father_name.Text + "',DOB='" + DOB.Text + "',CNIC='" + CNIC.Text + "',PhoneNo='" + PhoneNo.Text + "',Gender='" + genderCombo.Text + "',Address='" + textBox_Address.Text + "',Height='" + height.Text.ToString() + "',Disease='" + textBox_diseases.Text + "',Blood_Group='" + BGroup.Text + "',Donated_Before='" + Donated_NO_rbtn.Text + "',Previous_D_Date='" + donated_Date.Text + "' WHERE D_id='" + listBox1.SelectedItem + "'", database.con);
                    database.con.Open();
                    csd.ExecuteNonQuery();
                    MessageBox.Show("Info Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    database.con.Close();
                    listboxdata();
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

        public void listboxdata()
        {
            try
            {
                listBox1.Items.Clear();
                SqlCommand sc = new SqlCommand("select * from Donor", database.con);
                database.con.Open();
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    listBox1.Items.Add(sd["D_id"]);
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

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sc = new SqlCommand("select * from Donor where D_id='" + listBox1.SelectedItem+ "'", database.con);
                database.con.Open();

                SqlDataReader sr = sc.ExecuteReader();
                while (sr.Read())
                {
                    ID.Text = "ID: "+sr["D_id"].ToString();
                    text_Name.Text = sr["D_Name"].ToString();
                    DOB.Text = sr["DOB"].ToString();
                    Father_name.Text = sr["D_Father_name"].ToString();
                    BGroup.Text = sr["Blood_Group"].ToString();
                    CNIC.Text = sr["CNIC"].ToString();
                    PhoneNo.Text = sr["PhoneNo"].ToString();
                    height.Text = sr["Height"].ToString();
                     textBox_diseases.Text = sr["Disease"].ToString();
                    textBox_Address.Text = sr["Address"].ToString();
                    genderCombo.Text=sr["Gender"].ToString();
                    if (sr["Donated_Before"].ToString() == "Yes") {
                        Donated_YES_rbtn.Checked = true; 
                    }
                    else
                    {
                        Donated_NO_rbtn.Checked = true;
                    }
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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete Donor "+listBox1.SelectedItem+" record", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {

                    SqlCommand sc = new SqlCommand("delete from Donor where D_id='" + listBox1.SelectedItem + "'", database.con);
                    database.con.Open();
                    sc.ExecuteNonQuery();
                    database.con.Close();
                    listboxdata();
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
            else if (dr == DialogResult.No)
            {
            }
        }

        private void Donor_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
