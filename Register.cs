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
    public partial class Register : Form
    {
        SqlConnection conn = new SqlConnection(Program.ConnectionString);

        public Register()
        {
            InitializeComponent();
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e) //txtMobile only numbers
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //no empty field
            if (txtUsername.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0 || txtName.Text.Trim().Length == 0 ||
                txtMobile.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all required fields", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //password does not match
            else if (txtPassword.Text.Trim() != txtRetype.Text)
            {
                MessageBox.Show("Passwords do not match", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //password matches
            else
            {
                string name = txtName.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string mobile = txtMobile.Text.Trim();
                string address = txtAddress.Text.Trim();
                var isAdmin = 0;

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Accounts where Username='" + username + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                bool user_exist = true;

                if (reader.Read() == false)
                {
                    user_exist = false;
                }
                else
                {
                    MessageBox.Show("Username " + username + " already taken.", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();

                if (user_exist == false)
                {

                    if (cbAdmin.Checked) { isAdmin = 1; }
                    SqlCommand add_cmd = conn.CreateCommand();
                    add_cmd.CommandType = CommandType.Text;
                    add_cmd.CommandText = "insert into Accounts values('" + username + "','" + password + "','" + name + "','" +
                        mobile + "','" + address + "','" + isAdmin + "')";
                    add_cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!", "EasyParcel");
                    conn.Close();
                    this.Close();
                }
                conn.Close();
            }
        }
    }
}
