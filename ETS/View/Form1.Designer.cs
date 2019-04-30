namespace View
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxAddEmployee = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.dtbUpdateDob = new System.Windows.Forms.DateTimePicker();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxSelectId = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSelectId = new System.Windows.Forms.TextBox();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEmailSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEmailSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbxEmployeeList = new System.Windows.Forms.GroupBox();
            this.lstEmployeeList = new System.Windows.Forms.ListBox();
            this.gbxWorkingHours = new System.Windows.Forms.GroupBox();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtbWorkDate = new System.Windows.Forms.DateTimePicker();
            this.btnRecordHours = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtIdDisplay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.gbxAddEmployee.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbxSelectId.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.gbxEmployeeList.SuspendLayout();
            this.gbxWorkingHours.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddEmployee
            // 
            this.gbxAddEmployee.BackColor = System.Drawing.Color.GhostWhite;
            this.gbxAddEmployee.Controls.Add(this.dtpDOB);
            this.gbxAddEmployee.Controls.Add(this.label5);
            this.gbxAddEmployee.Controls.Add(this.label4);
            this.gbxAddEmployee.Controls.Add(this.label3);
            this.gbxAddEmployee.Controls.Add(this.txtEmail);
            this.gbxAddEmployee.Controls.Add(this.txtPhone);
            this.gbxAddEmployee.Controls.Add(this.label2);
            this.gbxAddEmployee.Controls.Add(this.label1);
            this.gbxAddEmployee.Controls.Add(this.txtLastName);
            this.gbxAddEmployee.Controls.Add(this.txtFirstName);
            this.gbxAddEmployee.Controls.Add(this.btnAdd);
            this.gbxAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddEmployee.Location = new System.Drawing.Point(32, 16);
            this.gbxAddEmployee.Name = "gbxAddEmployee";
            this.gbxAddEmployee.Size = new System.Drawing.Size(326, 268);
            this.gbxAddEmployee.TabIndex = 1;
            this.gbxAddEmployee.TabStop = false;
            this.gbxAddEmployee.Text = "Add Employee";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(124, 104);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(172, 26);
            this.dtpDOB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(124, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(124, 173);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(124, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(124, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(124, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.GhostWhite;
            this.gbxUpdate.Controls.Add(this.dtbUpdateDob);
            this.gbxUpdate.Controls.Add(this.txtEmpId);
            this.gbxUpdate.Controls.Add(this.label11);
            this.gbxUpdate.Controls.Add(this.label6);
            this.gbxUpdate.Controls.Add(this.label7);
            this.gbxUpdate.Controls.Add(this.label8);
            this.gbxUpdate.Controls.Add(this.txtUpdateFirstName);
            this.gbxUpdate.Controls.Add(this.txtUpdateLastName);
            this.gbxUpdate.Controls.Add(this.label9);
            this.gbxUpdate.Controls.Add(this.label10);
            this.gbxUpdate.Controls.Add(this.txtUpdateEmail);
            this.gbxUpdate.Controls.Add(this.txtUpdatePhone);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(17, 73);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(352, 270);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Employee";
            // 
            // dtbUpdateDob
            // 
            this.dtbUpdateDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbUpdateDob.Location = new System.Drawing.Point(134, 116);
            this.dtbUpdateDob.Name = "dtbUpdateDob";
            this.dtbUpdateDob.Size = new System.Drawing.Size(162, 26);
            this.dtbUpdateDob.TabIndex = 14;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(134, 25);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(162, 26);
            this.txtEmpId.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFirstName.Location = new System.Drawing.Point(134, 57);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(162, 22);
            this.txtUpdateFirstName.TabIndex = 8;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLastName.Location = new System.Drawing.Point(134, 89);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(162, 22);
            this.txtUpdateLastName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "First Name";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmail.Location = new System.Drawing.Point(134, 148);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(162, 22);
            this.txtUpdateEmail.TabIndex = 11;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(134, 176);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(162, 22);
            this.txtUpdatePhone.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(134, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Enabled = false;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(448, 272);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 427);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxAddEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxSelectId);
            this.tabPage2.Controls.Add(this.gbxUpdate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxSelectId
            // 
            this.gbxSelectId.Controls.Add(this.label12);
            this.gbxSelectId.Controls.Add(this.txtSelectId);
            this.gbxSelectId.Controls.Add(this.btnSearchId);
            this.gbxSelectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectId.Location = new System.Drawing.Point(17, 6);
            this.gbxSelectId.Name = "gbxSelectId";
            this.gbxSelectId.Size = new System.Drawing.Size(352, 61);
            this.gbxSelectId.TabIndex = 2;
            this.gbxSelectId.TabStop = false;
            this.gbxSelectId.Text = "Search Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Employee ID";
            // 
            // txtSelectId
            // 
            this.txtSelectId.Location = new System.Drawing.Point(134, 21);
            this.txtSelectId.Name = "txtSelectId";
            this.txtSelectId.Size = new System.Drawing.Size(120, 26);
            this.txtSelectId.TabIndex = 1;
            // 
            // btnSearchId
            // 
            this.btnSearchId.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchId.FlatAppearance.BorderSize = 0;
            this.btnSearchId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchId.ForeColor = System.Drawing.Color.White;
            this.btnSearchId.Location = new System.Drawing.Point(260, 19);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(75, 28);
            this.btnSearchId.TabIndex = 0;
            this.btnSearchId.Text = "Submit";
            this.btnSearchId.UseVisualStyleBackColor = false;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.txtEmailSearch);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnEmailSearch);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Employees";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(538, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtEmailSearch
            // 
            this.txtEmailSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSearch.Location = new System.Drawing.Point(210, 9);
            this.txtEmailSearch.Name = "txtEmailSearch";
            this.txtEmailSearch.Size = new System.Drawing.Size(312, 26);
            this.txtEmailSearch.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Enter Employee Email";
            // 
            // btnEmailSearch
            // 
            this.btnEmailSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmailSearch.FlatAppearance.BorderSize = 0;
            this.btnEmailSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailSearch.ForeColor = System.Drawing.Color.White;
            this.btnEmailSearch.Location = new System.Drawing.Point(538, 8);
            this.btnEmailSearch.Name = "btnEmailSearch";
            this.btnEmailSearch.Size = new System.Drawing.Size(75, 29);
            this.btnEmailSearch.TabIndex = 1;
            this.btnEmailSearch.Text = "Submit";
            this.btnEmailSearch.UseVisualStyleBackColor = false;
            this.btnEmailSearch.Click += new System.EventHandler(this.btnEmailSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRefreshList);
            this.tabPage4.Controls.Add(this.gbxEmployeeList);
            this.tabPage4.Controls.Add(this.gbxWorkingHours);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(672, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Record Hours";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbxEmployeeList
            // 
            this.gbxEmployeeList.Controls.Add(this.lstEmployeeList);
            this.gbxEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployeeList.Location = new System.Drawing.Point(17, 24);
            this.gbxEmployeeList.Name = "gbxEmployeeList";
            this.gbxEmployeeList.Size = new System.Drawing.Size(273, 295);
            this.gbxEmployeeList.TabIndex = 2;
            this.gbxEmployeeList.TabStop = false;
            this.gbxEmployeeList.Text = "List of Employees";
            // 
            // lstEmployeeList
            // 
            this.lstEmployeeList.FormattingEnabled = true;
            this.lstEmployeeList.ItemHeight = 20;
            this.lstEmployeeList.Location = new System.Drawing.Point(6, 22);
            this.lstEmployeeList.Name = "lstEmployeeList";
            this.lstEmployeeList.Size = new System.Drawing.Size(261, 264);
            this.lstEmployeeList.TabIndex = 0;
            this.lstEmployeeList.SelectedIndexChanged += new System.EventHandler(this.lstEmployeeList_SelectedIndexChanged);
            // 
            // gbxWorkingHours
            // 
            this.gbxWorkingHours.Controls.Add(this.txtIdEmp);
            this.gbxWorkingHours.Controls.Add(this.label16);
            this.gbxWorkingHours.Controls.Add(this.dtbWorkDate);
            this.gbxWorkingHours.Controls.Add(this.btnRecordHours);
            this.gbxWorkingHours.Controls.Add(this.txtHours);
            this.gbxWorkingHours.Controls.Add(this.label15);
            this.gbxWorkingHours.Controls.Add(this.label14);
            this.gbxWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxWorkingHours.Location = new System.Drawing.Point(372, 24);
            this.gbxWorkingHours.Name = "gbxWorkingHours";
            this.gbxWorkingHours.Size = new System.Drawing.Size(238, 295);
            this.gbxWorkingHours.TabIndex = 1;
            this.gbxWorkingHours.TabStop = false;
            this.gbxWorkingHours.Text = "Working Hours";
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Location = new System.Drawing.Point(10, 64);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(200, 26);
            this.txtIdEmp.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Employee Id";
            // 
            // dtbWorkDate
            // 
            this.dtbWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbWorkDate.Location = new System.Drawing.Point(10, 122);
            this.dtbWorkDate.Name = "dtbWorkDate";
            this.dtbWorkDate.Size = new System.Drawing.Size(200, 26);
            this.dtbWorkDate.TabIndex = 6;
            // 
            // btnRecordHours
            // 
            this.btnRecordHours.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecordHours.FlatAppearance.BorderSize = 0;
            this.btnRecordHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordHours.ForeColor = System.Drawing.Color.White;
            this.btnRecordHours.Location = new System.Drawing.Point(10, 226);
            this.btnRecordHours.Name = "btnRecordHours";
            this.btnRecordHours.Size = new System.Drawing.Size(131, 30);
            this.btnRecordHours.TabIndex = 5;
            this.btnRecordHours.Text = "Record Hours";
            this.btnRecordHours.UseVisualStyleBackColor = false;
            this.btnRecordHours.Click += new System.EventHandler(this.btnRecordHours_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(10, 185);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(196, 26);
            this.txtHours.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Hours";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Work Date";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(672, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Display Work Hours";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.lblTotalHours);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.txtIdDisplay);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Wo";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(149, 77);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 20);
            this.lblEmployeeName.TabIndex = 7;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(149, 122);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(0, 20);
            this.lblTotalHours.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Total Hours:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(259, 26);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(120, 33);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Hours";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtIdDisplay
            // 
            this.txtIdDisplay.Location = new System.Drawing.Point(153, 29);
            this.txtIdDisplay.Name = "txtIdDisplay";
            this.txtIdDisplay.Size = new System.Drawing.Size(100, 26);
            this.txtIdDisplay.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Employee Id:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Employee Name:";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefreshList.FlatAppearance.BorderSize = 0;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.ForeColor = System.Drawing.Color.White;
            this.btnRefreshList.Location = new System.Drawing.Point(17, 325);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(273, 30);
            this.btnRefreshList.TabIndex = 6;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAddEmployee.ResumeLayout(false);
            this.gbxAddEmployee.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbxSelectId.ResumeLayout(false);
            this.gbxSelectId.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.gbxEmployeeList.ResumeLayout(false);
            this.gbxWorkingHours.ResumeLayout(false);
            this.gbxWorkingHours.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAddEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxSelectId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSelectId;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.TextBox txtEmailSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEmailSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbxEmployeeList;
        private System.Windows.Forms.ListBox lstEmployeeList;
        private System.Windows.Forms.GroupBox gbxWorkingHours;
        private System.Windows.Forms.DateTimePicker dtbWorkDate;
        private System.Windows.Forms.Button btnRecordHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtIdDisplay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.DateTimePicker dtbUpdateDob;
        private System.Windows.Forms.Button btnRefreshList;
    }
}

