using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public static string MyProperty = "", username="";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
                try
                {
                    // connecting to validate the username and password form Login Screen..
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From Employee where E_Username ='" + textBoxUser.Text + "' and E_Password = '" + textBoxpass.Text + "' ", database.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                     MyProperty = dt.Rows[0]["Type"].ToString();
                    // MyProperty = "Admin";
                    username = dt.Rows[0]["E_username"].ToString();
                    Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                        database.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        database.con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
        

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a =new About();
            a.Show();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

      
    }
}
