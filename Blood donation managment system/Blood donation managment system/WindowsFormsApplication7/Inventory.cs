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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("fill search box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.Text == "All")
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D", database.con);
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
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation", database.con);
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
                else
                {
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Employee_D where BloodGroup='" + comboBox1.Text.Trim() + "'", database.con);
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
                    try
                    {
                        database.con.Open();
                        SqlDataAdapter csd = new SqlDataAdapter("select * from Donor_Donation where Blood_Group='" + comboBox1.Text.Trim() + "'", database.con);
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
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
