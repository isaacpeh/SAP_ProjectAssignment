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
    public partial class AdMainForm : Form
    {
        SqlConnection conn = new SqlConnection(@Program.ConnectionString);
        string username;
        int userid;
        string query;
        string query2;

        public AdMainForm()
        {
            InitializeComponent();
        }

        public AdMainForm(string nm, int id)
        {
            InitializeComponent();
            username = nm;
            userid = id;
        }

        private void AdMainForm_Load(object sender, EventArgs e)
        {
            panelAccount.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            lblUser.Text = username;
            cbReqStatus.SelectedIndex = 0;
            query = "SELECT o.*,  a.Username " +
                    "FROM [Orders] o " +
                    "JOIN Accounts a " +
                    "ON o.CustomerId = a.Id_Account";

            this.dgvRequest.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvAccount.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            displayData();
        }

        private void btnRequest_Click(object sender, EventArgs e) // left panel Request Management
        {
            panelRequest.Visible = true;
            panelAccount.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            cbReqStatus.SelectedIndex = 0;
            query = "SELECT o.*,  a.Username " +
                    "FROM [Orders] o " +
                    "JOIN Accounts a " +
                    "ON o.CustomerId = a.Id_Account";

            btnAccReset_Click(null, null);
        }

        private void btnAccount_Click(object sender, EventArgs e) // left panel Account Management
        {
            panelAccount.Visible = true;
            panelRequest.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel1.Visible = false;

            query2 = "Select Id_Account, Username, Number from Accounts WHERE isAdmin=0";

            btnAccReset_Click(null, null);
        }

        private void btnLog_Click(object sender, EventArgs e) // left panel LogOut
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel1.Visible = false;

            DialogResult confirm = MessageBox.Show("Are you sure you want to log off?", "EasyParcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        // ----------------------------------------------------------------------------------------------- //
        // Request Management Controls

        private void btnReqSearch_Click(object sender, EventArgs e) // Request Management Control
        {
            if (txtReqUser.Text.Trim().Length == 0)
            {
                if (rblAll.Checked)
                    query = "SELECT o.*,  a.Username " +
                   "FROM [Orders] o " +
                   "JOIN Accounts a " +
                   "ON o.CustomerId = a.Id_Account";
                if (rblPending.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Pending'";
                }
                if (rblAccecpted.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Accecpted'";
                }
                if (rblCompleted.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Completed'";
                }
            }
            else
            {
                if (rblAll.Checked)
                    query = "SELECT o.*,  a.Username " +
                   "FROM [Orders] o " +
                   "JOIN Accounts a " +
                   "ON o.CustomerId = a.Id_Account " +
                   "WHERE a.Username ='" + txtReqUser.Text.Trim() + "'";
                if (rblPending.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Pending' " +
                       "AND a.Username ='" + txtReqUser.Text.Trim() + "'";
                }
                if (rblAccecpted.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Accecpted' " +
                       "AND a.Username ='" + txtReqUser.Text.Trim() + "'";
                }
                if (rblCompleted.Checked)
                {
                    query = "SELECT o.*,  a.Username " +
                       "FROM [Orders] o " +
                       "JOIN Accounts a " +
                       "ON o.CustomerId = a.Id_Account " +
                       "WHERE o.Status ='Completed' " +
                       "AND a.Username ='" + txtReqUser.Text.Trim() + "'";
                }
            }
            displayData();
        }

        private void btnReqClear_Click(object sender, EventArgs e) // Request Management Control
        {
            rblAll.Checked = true;
            txtReqUser.Text = "";
            btnReqSearch_Click(null, null);
        }

        private void btnReqDelete_Click(object sender, EventArgs e) // Request Management Control
        {
            if (dgvRequest.Rows.Count == 0)
            {
                MessageBox.Show("No requests available", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int index = dgvRequest.SelectedRows[0].Index;
                var num = dgvRequest.SelectedRows[0].Cells[0].Value;
                int id_order = (int)num;

                DialogResult confirm = MessageBox.Show("Delete request?", "EasyParcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Orders where Id_Order=" + id_order;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    displayData();
                }
                else
                {
                    return;
                }
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select request to delete", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReqSave_Click(object sender, EventArgs e) // Request Management Control
        {
            if (dgvRequest.Rows.Count == 0)
            {
                MessageBox.Show("No requests available", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int index = dgvRequest.SelectedRows[0].Index;
                var num = dgvRequest.SelectedRows[0].Cells[0].Value;
                int id_order = (int)num;

                string status = cbReqStatus.Text.ToString();


                conn.Open();
                string query = "update Orders set Status=@a where Id_Order=" + num;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@a", status);


                cmd.ExecuteNonQuery();
                conn.Close();
                displayData();
                MessageBox.Show("Request successfully modified", "EasyParcel");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select request to edit", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // ----------------------------------------------------------------------------------------------- //
        // Account Management Controls

        private void btnAccReset_Click(object sender, EventArgs e) // Account Management Control
        {
            rblCustomer.Checked = true;
            txtAccUsername.Text = "";
            btnAccSearch_Click(null, null);
        }

        private void btnAccSearch_Click(object sender, EventArgs e) // Account Management Control
        {
            if (txtAccUsername.Text.Trim().Length == 0)
            {
                if (rblCustomer.Checked)
                    query2 = "Select Id_Account, Username, Number from Accounts WHERE isAdmin=0";

                if (rblAccAdmin.Checked)
                {
                    query2 = "Select Id_Account, Username, Number from Accounts WHERE isAdmin=1";
                }
            }
            else
            {
                if (rblCustomer.Checked)
                    query2 = "Select Id_Account, Username, Number from Accounts WHERE isAdmin=0 AND Username='" + txtAccUsername.Text.Trim() + "'";

                if (rblAccAdmin.Checked)
                {
                    query2 = "Select Id_Account, Username, Number from Accounts WHERE isAdmin=1 AND Username='" + txtAccUsername.Text.Trim() + "'";
                }
            }
            displayData2();
        }

        private void btnAccDelete_Click(object sender, EventArgs e) // Account Management Control
        {
            if (dgvAccount.Rows.Count == 0)
            {
                MessageBox.Show("No accounts available", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int index = dgvAccount.SelectedRows[0].Index;
                var num = dgvAccount.SelectedRows[0].Cells[0].Value;
                int id_account = (int)num;

                DialogResult confirm = MessageBox.Show("Delete account?", "EasyParcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (userid == id_account)
                    {
                        DialogResult loggingout = MessageBox.Show("You will be logged out after deleting account", "EasyParcel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (loggingout == DialogResult.OK)
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "delete from Accounts where Id_Account=" + id_account;
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Accounts where Id_Account=" + id_account;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        displayData2();
                    }
                }
                else
                {
                    return;
                }
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select account to delete", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ----------------------------------------------------------------------------------------------- //
        // Others

        private void cbReqStatus_KeyPress(object sender, KeyPressEventArgs e) // prevent typing in combobox
        {
            e.Handled = true;
        }

        private void displayData() // datagridview Request display data
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvRequest.DataSource = dt;
            columnRequestModify();

            dgvRequest.ClearSelection();
            conn.Close();
        }

        private void displayData2() // datagridview Account display data
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            columnAccountModify();

            dgvAccount.ClearSelection();
            conn.Close();
        }

        private void columnRequestModify() // datagridview Request column remove and rename
        {
            dgvRequest.Columns["Username"].DisplayIndex = 1;
            this.dgvRequest.Columns["CustomerId"].Visible = false;
            dgvRequest.Columns["Id_Order"].HeaderText = "Order ID";
            dgvRequest.Columns["Item_name"].HeaderText = "Item Description";
            dgvRequest.Columns["Item_weight"].HeaderText = "Weight (kg)";
            dgvRequest.Columns["Sender_address"].HeaderText = "Pick-Up Address";
            dgvRequest.Columns["Receiver_address"].HeaderText = "Receiver's Address";
            dgvRequest.Columns["Receiver_number"].HeaderText = "Receiver's Number";
            dgvRequest.Columns["Notes"].HeaderText = "Additional Notes";
            dgvRequest.Columns["Date"].HeaderText = "Date & Time Ordered";
            dgvRequest.Columns["Username"].HeaderText = "User";
            dgvRequest.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgvRequest.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            foreach (DataGridViewRow rows in dgvRequest.Rows)
            {
                if (rows.Cells[9].Value.ToString() == "Pending")
                {
                    rows.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (rows.Cells[9].Value.ToString() == "Accecpted")
                {
                    rows.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else
                {
                    rows.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            foreach (DataGridViewColumn col in dgvRequest.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void columnAccountModify() // datagridview Account column remove and rename
        {
            dgvAccount.Columns["Id_Account"].HeaderText = "Account ID";

            dgvAccount.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgvAccount.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            foreach (DataGridViewColumn col in dgvAccount.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

    }
}