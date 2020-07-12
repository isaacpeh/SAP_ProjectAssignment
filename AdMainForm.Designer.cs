namespace Isaac_SAP_ProjectAssignment
{
    partial class AdMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdMainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.rblCompleted = new System.Windows.Forms.RadioButton();
            this.rblAccecpted = new System.Windows.Forms.RadioButton();
            this.rblPending = new System.Windows.Forms.RadioButton();
            this.rblAll = new System.Windows.Forms.RadioButton();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.btnReqSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReqStatus = new System.Windows.Forms.ComboBox();
            this.btnReqDelete = new System.Windows.Forms.Button();
            this.btnReqSave = new System.Windows.Forms.Button();
            this.btnReqClear = new System.Windows.Forms.Button();
            this.txtReqUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Isaac_SAP_ProjectAssignment.Database1DataSet();
            this.accountsTableAdapter1 = new Isaac_SAP_ProjectAssignment.Database1DataSetTableAdapters.AccountsTableAdapter();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnAccDelete = new System.Windows.Forms.Button();
            this.rblAccAdmin = new System.Windows.Forms.RadioButton();
            this.rblCustomer = new System.Windows.Forms.RadioButton();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.btnAccReset = new System.Windows.Forms.Button();
            this.txtAccUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panelRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(148, 356);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 142);
            this.panel3.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(148, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 142);
            this.panel2.TabIndex = 28;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLog.Location = new System.Drawing.Point(0, 356);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(152, 142);
            this.btnLog.TabIndex = 33;
            this.btnLog.Text = "Log Out";
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightCoral;
            this.label10.Location = new System.Drawing.Point(23, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Administrator Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(7, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 31);
            this.label9.TabIndex = 31;
            this.label9.Text = "EasyParcel";
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.Location = new System.Drawing.Point(0, 214);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(152, 142);
            this.btnAccount.TabIndex = 29;
            this.btnAccount.Text = "Account Management";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(148, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 142);
            this.panel1.TabIndex = 25;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRequest.Location = new System.Drawing.Point(0, 78);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(152, 142);
            this.btnRequest.TabIndex = 24;
            this.btnRequest.Text = "Request Management";
            this.btnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(134)))));
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 521);
            this.label2.TabIndex = 23;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Logged on as :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUser.Location = new System.Drawing.Point(270, 24);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 17);
            this.lblUser.TabIndex = 35;
            this.lblUser.Text = "label2";
            // 
            // panelRequest
            // 
            this.panelRequest.Controls.Add(this.rblCompleted);
            this.panelRequest.Controls.Add(this.rblAccecpted);
            this.panelRequest.Controls.Add(this.rblPending);
            this.panelRequest.Controls.Add(this.rblAll);
            this.panelRequest.Controls.Add(this.dgvRequest);
            this.panelRequest.Controls.Add(this.btnReqSearch);
            this.panelRequest.Controls.Add(this.label4);
            this.panelRequest.Controls.Add(this.cbReqStatus);
            this.panelRequest.Controls.Add(this.btnReqDelete);
            this.panelRequest.Controls.Add(this.btnReqSave);
            this.panelRequest.Controls.Add(this.btnReqClear);
            this.panelRequest.Controls.Add(this.txtReqUser);
            this.panelRequest.Controls.Add(this.label3);
            this.panelRequest.Location = new System.Drawing.Point(166, 62);
            this.panelRequest.Margin = new System.Windows.Forms.Padding(2);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(816, 426);
            this.panelRequest.TabIndex = 36;
            // 
            // rblCompleted
            // 
            this.rblCompleted.AutoSize = true;
            this.rblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblCompleted.Location = new System.Drawing.Point(121, 102);
            this.rblCompleted.Name = "rblCompleted";
            this.rblCompleted.Size = new System.Drawing.Size(92, 20);
            this.rblCompleted.TabIndex = 16;
            this.rblCompleted.Text = "Completed";
            this.rblCompleted.UseVisualStyleBackColor = true;
            // 
            // rblAccecpted
            // 
            this.rblAccecpted.AutoSize = true;
            this.rblAccecpted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblAccecpted.Location = new System.Drawing.Point(21, 102);
            this.rblAccecpted.Name = "rblAccecpted";
            this.rblAccecpted.Size = new System.Drawing.Size(91, 20);
            this.rblAccecpted.TabIndex = 15;
            this.rblAccecpted.Text = "Accecpted";
            this.rblAccecpted.UseVisualStyleBackColor = true;
            // 
            // rblPending
            // 
            this.rblPending.AutoSize = true;
            this.rblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblPending.Location = new System.Drawing.Point(121, 76);
            this.rblPending.Name = "rblPending";
            this.rblPending.Size = new System.Drawing.Size(76, 20);
            this.rblPending.TabIndex = 14;
            this.rblPending.Text = "Pending";
            this.rblPending.UseVisualStyleBackColor = true;
            // 
            // rblAll
            // 
            this.rblAll.AutoSize = true;
            this.rblAll.Checked = true;
            this.rblAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblAll.Location = new System.Drawing.Point(21, 76);
            this.rblAll.Name = "rblAll";
            this.rblAll.Size = new System.Drawing.Size(41, 20);
            this.rblAll.TabIndex = 13;
            this.rblAll.TabStop = true;
            this.rblAll.Text = "All";
            this.rblAll.UseVisualStyleBackColor = true;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRequest.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(230, 19);
            this.dgvRequest.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.RowTemplate.Height = 24;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(584, 405);
            this.dgvRequest.TabIndex = 12;
            // 
            // btnReqSearch
            // 
            this.btnReqSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReqSearch.FlatAppearance.BorderSize = 0;
            this.btnReqSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqSearch.Location = new System.Drawing.Point(20, 140);
            this.btnReqSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnReqSearch.Name = "btnReqSearch";
            this.btnReqSearch.Size = new System.Drawing.Size(189, 25);
            this.btnReqSearch.TabIndex = 11;
            this.btnReqSearch.Text = "Search";
            this.btnReqSearch.UseVisualStyleBackColor = false;
            this.btnReqSearch.Click += new System.EventHandler(this.btnReqSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change Status";
            // 
            // cbReqStatus
            // 
            this.cbReqStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReqStatus.FormattingEnabled = true;
            this.cbReqStatus.Items.AddRange(new object[] {
            "Pending",
            "Accecpted",
            "Completed"});
            this.cbReqStatus.Location = new System.Drawing.Point(20, 233);
            this.cbReqStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbReqStatus.Name = "cbReqStatus";
            this.cbReqStatus.Size = new System.Drawing.Size(190, 25);
            this.cbReqStatus.TabIndex = 9;
            this.cbReqStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbReqStatus_KeyPress);
            // 
            // btnReqDelete
            // 
            this.btnReqDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnReqDelete.FlatAppearance.BorderSize = 0;
            this.btnReqDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqDelete.Location = new System.Drawing.Point(21, 390);
            this.btnReqDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnReqDelete.Name = "btnReqDelete";
            this.btnReqDelete.Size = new System.Drawing.Size(189, 34);
            this.btnReqDelete.TabIndex = 8;
            this.btnReqDelete.Text = "Delete Request";
            this.btnReqDelete.UseVisualStyleBackColor = false;
            this.btnReqDelete.Click += new System.EventHandler(this.btnReqDelete_Click);
            // 
            // btnReqSave
            // 
            this.btnReqSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReqSave.FlatAppearance.BorderSize = 0;
            this.btnReqSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqSave.Location = new System.Drawing.Point(21, 352);
            this.btnReqSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnReqSave.Name = "btnReqSave";
            this.btnReqSave.Size = new System.Drawing.Size(189, 34);
            this.btnReqSave.TabIndex = 7;
            this.btnReqSave.Text = "Save Status";
            this.btnReqSave.UseVisualStyleBackColor = false;
            this.btnReqSave.Click += new System.EventHandler(this.btnReqSave_Click);
            // 
            // btnReqClear
            // 
            this.btnReqClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReqClear.FlatAppearance.BorderSize = 0;
            this.btnReqClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqClear.Location = new System.Drawing.Point(20, 172);
            this.btnReqClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnReqClear.Name = "btnReqClear";
            this.btnReqClear.Size = new System.Drawing.Size(189, 25);
            this.btnReqClear.TabIndex = 6;
            this.btnReqClear.Text = "Reset Filters";
            this.btnReqClear.UseVisualStyleBackColor = false;
            this.btnReqClear.Click += new System.EventHandler(this.btnReqClear_Click);
            // 
            // txtReqUser
            // 
            this.txtReqUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqUser.Location = new System.Drawing.Point(20, 36);
            this.txtReqUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtReqUser.MaxLength = 50;
            this.txtReqUser.Name = "txtReqUser";
            this.txtReqUser.Size = new System.Drawing.Size(190, 23);
            this.txtReqUser.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search by Username (optional)";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter1
            // 
            this.accountsTableAdapter1.ClearBeforeFill = true;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnAccDelete);
            this.panelAccount.Controls.Add(this.rblAccAdmin);
            this.panelAccount.Controls.Add(this.rblCustomer);
            this.panelAccount.Controls.Add(this.btnAccSearch);
            this.panelAccount.Controls.Add(this.btnAccReset);
            this.panelAccount.Controls.Add(this.txtAccUsername);
            this.panelAccount.Controls.Add(this.label5);
            this.panelAccount.Controls.Add(this.dgvAccount);
            this.panelAccount.Location = new System.Drawing.Point(166, 62);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(816, 426);
            this.panelAccount.TabIndex = 17;
            // 
            // btnAccDelete
            // 
            this.btnAccDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnAccDelete.FlatAppearance.BorderSize = 0;
            this.btnAccDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccDelete.Location = new System.Drawing.Point(22, 390);
            this.btnAccDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccDelete.Name = "btnAccDelete";
            this.btnAccDelete.Size = new System.Drawing.Size(189, 34);
            this.btnAccDelete.TabIndex = 21;
            this.btnAccDelete.Text = "Delete Account";
            this.btnAccDelete.UseVisualStyleBackColor = false;
            this.btnAccDelete.Click += new System.EventHandler(this.btnAccDelete_Click);
            // 
            // rblAccAdmin
            // 
            this.rblAccAdmin.AutoSize = true;
            this.rblAccAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblAccAdmin.Location = new System.Drawing.Point(109, 76);
            this.rblAccAdmin.Name = "rblAccAdmin";
            this.rblAccAdmin.Size = new System.Drawing.Size(104, 20);
            this.rblAccAdmin.TabIndex = 20;
            this.rblAccAdmin.Text = "Administrator";
            this.rblAccAdmin.UseVisualStyleBackColor = true;
            // 
            // rblCustomer
            // 
            this.rblCustomer.AutoSize = true;
            this.rblCustomer.Checked = true;
            this.rblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblCustomer.Location = new System.Drawing.Point(21, 76);
            this.rblCustomer.Name = "rblCustomer";
            this.rblCustomer.Size = new System.Drawing.Size(83, 20);
            this.rblCustomer.TabIndex = 19;
            this.rblCustomer.TabStop = true;
            this.rblCustomer.Text = "Customer";
            this.rblCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccSearch.FlatAppearance.BorderSize = 0;
            this.btnAccSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccSearch.Location = new System.Drawing.Point(21, 120);
            this.btnAccSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(189, 25);
            this.btnAccSearch.TabIndex = 18;
            this.btnAccSearch.Text = "Search";
            this.btnAccSearch.UseVisualStyleBackColor = false;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // btnAccReset
            // 
            this.btnAccReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccReset.FlatAppearance.BorderSize = 0;
            this.btnAccReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccReset.Location = new System.Drawing.Point(21, 152);
            this.btnAccReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccReset.Name = "btnAccReset";
            this.btnAccReset.Size = new System.Drawing.Size(189, 25);
            this.btnAccReset.TabIndex = 17;
            this.btnAccReset.Text = "Reset Filters";
            this.btnAccReset.UseVisualStyleBackColor = false;
            this.btnAccReset.Click += new System.EventHandler(this.btnAccReset_Click);
            // 
            // txtAccUsername
            // 
            this.txtAccUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccUsername.Location = new System.Drawing.Point(21, 36);
            this.txtAccUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccUsername.MaxLength = 50;
            this.txtAccUsername.Name = "txtAccUsername";
            this.txtAccUsername.Size = new System.Drawing.Size(190, 23);
            this.txtAccUsername.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search Username (optional)";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(230, 19);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(584, 405);
            this.dgvAccount.TabIndex = 13;
            // 
            // AdMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 497);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panelRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request / Account Management";
            this.Load += new System.EventHandler(this.AdMainForm_Load);
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelRequest;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.AccountsTableAdapter accountsTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReqStatus;
        private System.Windows.Forms.Button btnReqDelete;
        private System.Windows.Forms.Button btnReqSave;
        private System.Windows.Forms.Button btnReqClear;
        private System.Windows.Forms.TextBox txtReqUser;
        private System.Windows.Forms.Button btnReqSearch;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.RadioButton rblCompleted;
        private System.Windows.Forms.RadioButton rblAccecpted;
        private System.Windows.Forms.RadioButton rblPending;
        private System.Windows.Forms.RadioButton rblAll;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnAccDelete;
        private System.Windows.Forms.RadioButton rblAccAdmin;
        private System.Windows.Forms.RadioButton rblCustomer;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Button btnAccReset;
        private System.Windows.Forms.TextBox txtAccUsername;
        private System.Windows.Forms.Label label5;
    }
}