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

namespace Isaac_SAP_ProjectAssignment
{
    public partial class Login : Form
    {

        SqlConnection conn = new SqlConnection(@Program.ConnectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Accounts where Username='" + username + "'and Password='" + password + "'";
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                MessageBox.Show("Incorrect Username or Password", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                reader.Close();
                return;
            }
            else
            {
                bool isAdmin = reader.GetBoolean(6);

                if (isAdmin == true)
                {
                    // admin login
                    int userid = reader.GetInt32(0);
                    string name = reader.GetString(3);


                    MessageBox.Show("Welcome, " + name + ".", "Administrator Login");
                    this.Hide();
                    AdMainForm form = new AdMainForm(username, userid);
                    conn.Close();
                    reader.Close();
                    form.ShowDialog();
                    this.Show();

                }
                else
                {
                    // customer login
                    int userid = reader.GetInt32(0);
                    string name = reader.GetString(3);
                    string addr = reader.GetString(5);
                    int num = reader.GetInt32(4);
                    string passw = reader.GetString(2);

                    MessageBox.Show("Welcome, " + name + ".", "Customer Login");
                    this.Hide();
                    CustMainForm form = new CustMainForm(username, userid);
                    conn.Close();
                    reader.Close();
                    form.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.ShowDialog(); //pauses until Register Form closes
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            About form = new About();
            form.ShowDialog(); //pauses until Register Form closes
            this.Show();
        }
    }
}
