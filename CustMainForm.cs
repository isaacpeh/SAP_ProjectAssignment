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
    public partial class CustMainForm : Form
    {
        SqlConnection conn = new SqlConnection(@Program.ConnectionString);

        // attributes;
        int id;
        string username;
        string passw;
        string name;
        int num;
        string addr;

        public CustMainForm()
        {
            InitializeComponent();
        }

        public CustMainForm(string nm, int userid)
        {
            InitializeComponent();
            username = nm;
            id = userid;
            readUserInfo();
        }

        private void CustMainForm_Load(object sender, EventArgs e)
        {

            this.dgvProcessing.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvAccecpted.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            lblUser.Text = username;
            txtPick.Text = addr;
            numWeight.Value = 0;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnLog_Click(object sender, EventArgs e) //left panel LogOut
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

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

        private void btnRequest_Click(object sender, EventArgs e) //left panel Request Delivery
        {
            panelProfile.Visible = false;
            panelRequest.Visible = true;
            panelView.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            readUserInfo();
            txtPick.Text = addr;
            numWeight.Value = 0;
        }

        private void btnView_Click(object sender, EventArgs e) //left panel View Orders
        {
            tabControl1.SelectedIndex = 0;
            panelProfile.Visible = false;
            panelView.Visible = true;
            panelRequest.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            displayData();
        }

        private void btnProfile_Click(object sender, EventArgs e) //left panel Profile
        {
            panelProfile.Visible = true;
            panelView.Visible = false;
            panelRequest.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            readUserInfo();

            txtProfileUser.Text = username;
            txtProfileName.Text = name;
            txtProfilePass.Text = passw;
            txtProfileAddr.Text = addr;
            txtProfileNum.Text = Convert.ToString(num);
            txtProfileRetype.Text = "";
        }


        // ----------------------------------------------------------------------------------------------- //
        // Request Delivery Controls

        private void btnReset_Click(object sender, EventArgs e) // Request Delivery control
        {
            txtDescription.Text = "";
            txtNotes.Text = "";
            txtNumber.Text = "";
            txtPick.Text = addr;
            txtReceive.Text = "";
            numWeight.Value = 0;
        }

        private void btnSend_Click(object sender, EventArgs e) // Request Delivery control
        {
            if (txtDescription.Text.Trim().Length == 0 || txtNumber.Text.Trim().Length == 0 || txtPick.Text.Trim().Length == 0 ||
                txtReceive.Text.Trim().Length == 0 || numWeight.Value <= 0)
            {
                MessageBox.Show("Please fill in all required fields", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string description = txtDescription.Text.Trim();
                string number = txtNumber.Text.Trim();
                string pick = txtPick.Text.Trim();
                string receive = txtReceive.Text.Trim();
                int weight = Convert.ToInt32(numWeight.Value);
                string status = "Pending";
                string notes = txtNotes.Text.Trim();
                DateTime date = DateTime.Now;

                conn.Open();
                string query = "insert into Orders (CustomerId, Item_name, Item_weight, Sender_address, Receiver_address, Receiver_number, Notes, Date, Status ) values(@a, @b, @c, @d, @e, @f, @g, @h, @i)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", description);
                cmd.Parameters.AddWithValue("@c", weight);
                cmd.Parameters.AddWithValue("@d", pick);
                cmd.Parameters.AddWithValue("@e", receive);
                cmd.Parameters.AddWithValue("@f", number);
                cmd.Parameters.AddWithValue("@g", notes);
                cmd.Parameters.AddWithValue("@h", date);
                cmd.Parameters.AddWithValue("@i", status);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Delivery successfully requested!", "EasyParcel");
                btnReset_Click(null, null);
                displayData();
            }
        }


        // ----------------------------------------------------------------------------------------------- //
        // View Requests Controls

        private void btnDelete_Click(object sender, EventArgs e) // View Requests control
        {
            if (dgvProcessing.Rows.Count == 0)
            {
                MessageBox.Show("No requests available", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //int index = dgvProcessing.SelectedRows[0].Index;
                var num = dgvProcessing.SelectedRows[0].Cells[0].Value;
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

        private void btnEdit_Click(object sender, EventArgs e) // View Requests control
        {

            if (dgvProcessing.Rows.Count == 0)
            {
                MessageBox.Show("No requests available", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int index = dgvProcessing.SelectedRows[0].Index;
                var num = dgvProcessing.SelectedRows[0].Cells[0].Value;
                int id_order = (int)num;

                if (txtEditDescription.Text.Trim().Length == 0 || txtEditNum.Text.Trim().Length == 0 || txtEditPick.Text.Trim().Length == 0 ||
                    txtEditReceiver.Text.Trim().Length == 0 || numEditWeight.Value <= 0)
                {
                    MessageBox.Show("Please fill in all required fields", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string description = txtEditDescription.Text.Trim();
                int weight = Convert.ToInt32(numEditWeight.Value);
                string pick = txtEditPick.Text.Trim();
                string receive = txtEditReceiver.Text.Trim();
                string number = txtEditNum.Text.Trim();
                string notes = txtEditNotes.Text.Trim();

                conn.Open();
                string query = "update Orders set CustomerId=@a, Item_name=@b, Item_weight=@c, Sender_address=@d, Receiver_address=@e, Receiver_number=@f, Notes=@g where Id_Order=" + num;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", description);
                cmd.Parameters.AddWithValue("@c", weight);
                cmd.Parameters.AddWithValue("@d", pick);
                cmd.Parameters.AddWithValue("@e", receive);
                cmd.Parameters.AddWithValue("@f", number);
                cmd.Parameters.AddWithValue("@g", notes);

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

        private void tabControl1_Selected(object sender, TabControlEventArgs e) // View Requests control
        {
            if (tabControl1.SelectedIndex == 1) //Accecpted tab
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.BackColor = System.Drawing.Color.Gray;
                btnEdit.BackColor = System.Drawing.Color.Gray;
                txtEditNotes.Enabled = false;
                txtEditNum.Enabled = false;
                txtEditPick.Enabled = false;
                txtEditReceiver.Enabled = false;
                txtEditNotes.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.BackColor = System.Drawing.Color.LightCoral;
                btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
                txtEditNotes.Enabled = true;
                txtEditNum.Enabled = true;
                txtEditPick.Enabled = true;
                txtEditReceiver.Enabled = true;
                txtEditNotes.Enabled = true;
            }
        }

        private void dgvProcessing_SelectionChanged(object sender, EventArgs e) // View Requests control
        {
            if (dgvProcessing.SelectedRows.Count == 0)
            {
                txtEditDescription.Text = "";
                numEditWeight.Value = 0;
                txtEditPick.Text = "";
                txtEditReceiver.Text = "";
                txtEditNum.Text = "";
                txtEditNotes.Text = "";
                return;
            }
            else
            {
                string name = (string)dgvProcessing.SelectedRows[0].Cells[2].Value;
                int weight = (int)dgvProcessing.SelectedRows[0].Cells[3].Value;
                string pick = (string)dgvProcessing.SelectedRows[0].Cells[4].Value;
                string receive = (string)dgvProcessing.SelectedRows[0].Cells[5].Value;
                int num = (int)dgvProcessing.SelectedRows[0].Cells[6].Value;
                string note = (string)dgvProcessing.SelectedRows[0].Cells[7].Value;

                txtEditDescription.Text = name;
                numEditWeight.Value = Convert.ToInt32(weight);
                txtEditPick.Text = pick;
                txtEditReceiver.Text = receive;
                txtEditNum.Text = Convert.ToString(num);
                txtEditNotes.Text = note;
            }

        }

        // ------------------------------------------------------------------------------------------------ //
        // Profile Control

        private void btnProfileSave_Click(object sender, EventArgs e) // Profile Control
        {
            if (txtProfileUser.Text.Trim().Length == 0 || txtProfileName.Text.Trim().Length == 0 || txtProfilePass.Text.Trim().Length == 0 ||
                txtProfileRetype.Text.Trim().Length == 0 || txtProfileNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all required fields", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtProfilePass.Text != txtProfileRetype.Text)
            {
                MessageBox.Show("Passwords do not match", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                string upName = txtProfileName.Text.Trim();
                string upUserNm = txtProfileUser.Text.Trim();
                string upPass = txtProfilePass.Text.Trim();
                int upNum = Convert.ToInt32(txtProfileNum.Text.Trim());
                string upAddr = txtProfileAddr.Text.Trim();

                conn.Open();

                string query = "update Accounts set Username=@a, Name=@b, Password=@c, Number=@d, Address=@e where Id_Account=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@a", upUserNm);
                cmd.Parameters.AddWithValue("@b", upName);
                cmd.Parameters.AddWithValue("@c", upPass);
                cmd.Parameters.AddWithValue("@d", upNum);
                cmd.Parameters.AddWithValue("@e", upAddr);

                cmd.ExecuteNonQuery();
                conn.Close();
                readUserInfo();
                btnProfile_Click(null, null);

                MessageBox.Show("Profile successfully saved!", "EasyParcel");

                conn.Close();
            }
        }


        // ------------------------------------------------------------------------------------------------ //
        // Other Stuff

        private void txtEditNum_KeyPress(object sender, KeyPressEventArgs e) // prevent alphabet keypress
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e) // prevent alphabet keypress
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void displayData() // datagridview display data
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Orders where CustomerId=" + id + " and Status='Pending'";
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProcessing.DataSource = dt;
            columnProcessingModify();

            SqlCommand cmd2 = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Orders where CustomerId=" + id + " and NOT Status='Pending'";
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvAccecpted.DataSource = dt2;
            columnAccecptedModify();

            dgvProcessing.ClearSelection();
            conn.Close();
        }

        private void columnProcessingModify() // datagridview column remove and rename
        {
            this.dgvProcessing.Columns["CustomerId"].Visible = false;
            this.dgvProcessing.Columns["Id_Order"].Visible = false;
            dgvProcessing.Columns["Item_name"].HeaderText = "Item";
            dgvProcessing.Columns["Item_weight"].HeaderText = "Weight";
            dgvProcessing.Columns["Sender_address"].HeaderText = "Pick-Up Address";
            dgvProcessing.Columns["Receiver_address"].HeaderText = "Receiver's Address";
            dgvProcessing.Columns["Receiver_number"].HeaderText = "Receiver's Number";
            dgvProcessing.Columns["Notes"].HeaderText = "Additional Notes";
            dgvProcessing.Columns["Date"].HeaderText = "Date & Time Ordered";
            dgvProcessing.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dgvProcessing.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void columnAccecptedModify() // datagridview column remove and rename
        {
            this.dgvAccecpted.Columns["CustomerId"].Visible = false;
            this.dgvAccecpted.Columns["Id_Order"].Visible = false;
            dgvAccecpted.Columns["Item_name"].HeaderText = "Item";
            dgvAccecpted.Columns["Item_weight"].HeaderText = "Weight";
            dgvAccecpted.Columns["Sender_address"].HeaderText = "Pick-Up Address";
            dgvAccecpted.Columns["Receiver_address"].HeaderText = "Receiver's Address";
            dgvAccecpted.Columns["Receiver_number"].HeaderText = "Receiver's Number";
            dgvAccecpted.Columns["Notes"].HeaderText = "Additional Notes";
            dgvAccecpted.Columns["Date"].HeaderText = "Date & Time Ordered";
            dgvAccecpted.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvAccecpted.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void readUserInfo() // reader
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Accounts where Id_Account=" + id;
            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                username = reader.GetString(1);
                passw = reader.GetString(2);
                name = reader.GetString(3);
                num = reader.GetInt32(4);
                addr = reader.GetString(5);

                conn.Close();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Error: No Value", "EasyParcel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

    }
}
