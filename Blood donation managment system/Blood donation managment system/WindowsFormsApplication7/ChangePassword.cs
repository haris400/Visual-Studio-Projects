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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 c = new Form2();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = Form1.username;
            string oldpass = "";
            if (newpasstexbox.Text == string.Empty || retexbox.Text == string.Empty || Oldpasstextbox.Text == string.Empty) {
                MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            try
            {
                    database.con.Open();
                SqlCommand csd = new SqlCommand("select E_password from Employee where E_username='" + user + "'", database.con);
                DataTable d = new DataTable();
                SqlDataReader srr = csd.ExecuteReader();
                while (srr.Read())
                {
                    oldpass = srr["E_password"].ToString();
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
            if (Oldpasstextbox.Text != oldpass)
            {
                MessageBox.Show("Wrong Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(newpasstexbox.Text != retexbox.Text)
                {
                    MessageBox.Show("Wrong Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    if (newpasstexbox.Text == retexbox.Text)
                {
                    try
                    {
                            database.con.Open();
                        SqlCommand csd = new SqlCommand("update Employee set E_password='"+ newpasstexbox.Text + "' where E_username='" + user + "'", database.con);
                        csd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        Form1 f1 = new Form1();
                        f1.Show();
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
