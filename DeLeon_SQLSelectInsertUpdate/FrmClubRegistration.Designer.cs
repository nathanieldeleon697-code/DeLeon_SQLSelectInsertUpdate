namespace DeLeon_SQLSelectInsertUpdate
{
    partial class FrmClubRegistration
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.grpRegistration = new System.Windows.Forms.GroupBox();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpRegistration.SuspendLayout();
            this.grpMembers.SuspendLayout();
            this.SuspendLayout();
            // grpRegistration
            this.grpRegistration.Location = new System.Drawing.Point(12, 10);
            this.grpRegistration.Size = new System.Drawing.Size(710, 205);
            this.grpRegistration.Name = "grpRegistration";
            this.grpRegistration.TabIndex = 0;
            this.grpRegistration.Text = "";
            this.Controls.Add(this.grpRegistration);
            // grpMembers
            this.grpMembers.Location = new System.Drawing.Point(12, 226);
            this.grpMembers.Size = new System.Drawing.Size(830, 248);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.TabIndex = 1;
            this.grpMembers.Text = "List Of Club Members";
            this.Controls.Add(this.grpMembers);
            // lblStudentId
            this.lblStudentId.Location = new System.Drawing.Point(20, 28);
            this.lblStudentId.Size = new System.Drawing.Size(185, 20);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Student ID:";
            this.grpRegistration.Controls.Add(this.lblStudentId);
            // txtStudentId
            this.txtStudentId.Location = new System.Drawing.Point(20, 49);
            this.txtStudentId.Size = new System.Drawing.Size(185, 26);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.TabIndex = 3;
            this.txtStudentId.MaxLength = 19;
            this.grpRegistration.Controls.Add(this.txtStudentId);
            // lblProgram
            this.lblProgram.Location = new System.Drawing.Point(464, 28);
            this.lblProgram.Size = new System.Drawing.Size(225, 20);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program:";
            this.grpRegistration.Controls.Add(this.lblProgram);
            // cmbProgram
            this.cmbProgram.Location = new System.Drawing.Point(464, 49);
            this.cmbProgram.Size = new System.Drawing.Size(225, 26);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.TabIndex = 5;
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Information Systems", "BS Business Administration", "BS Accountancy", "BS Hospitality Management", "BS Tourism Management" });
            this.grpRegistration.Controls.Add(this.cmbProgram);
            // lblLastName
            this.lblLastName.Location = new System.Drawing.Point(20, 85);
            this.lblLastName.Size = new System.Drawing.Size(200, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last name:";
            this.grpRegistration.Controls.Add(this.lblLastName);
            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(20, 106);
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.TabIndex = 7;
            this.txtLastName.MaxLength = 50;
            this.grpRegistration.Controls.Add(this.txtLastName);
            // lblFirstName
            this.lblFirstName.Location = new System.Drawing.Point(242, 85);
            this.lblFirstName.Size = new System.Drawing.Size(200, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            this.grpRegistration.Controls.Add(this.lblFirstName);
            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(242, 106);
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.MaxLength = 50;
            this.grpRegistration.Controls.Add(this.txtFirstName);
            // lblMiddleName
            this.lblMiddleName.Location = new System.Drawing.Point(464, 85);
            this.lblMiddleName.Size = new System.Drawing.Size(200, 20);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.TabIndex = 10;
            this.lblMiddleName.Text = "Middle name:";
            this.grpRegistration.Controls.Add(this.lblMiddleName);
            // txtMiddleName
            this.txtMiddleName.Location = new System.Drawing.Point(464, 106);
            this.txtMiddleName.Size = new System.Drawing.Size(200, 26);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.TabIndex = 11;
            this.txtMiddleName.MaxLength = 50;
            this.grpRegistration.Controls.Add(this.txtMiddleName);
            // lblAge
            this.lblAge.Location = new System.Drawing.Point(20, 142);
            this.lblAge.Size = new System.Drawing.Size(130, 20);
            this.lblAge.Name = "lblAge";
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            this.grpRegistration.Controls.Add(this.lblAge);
            // txtAge
            this.txtAge.Location = new System.Drawing.Point(20, 163);
            this.txtAge.Size = new System.Drawing.Size(130, 26);
            this.txtAge.Name = "txtAge";
            this.txtAge.TabIndex = 13;
            this.txtAge.MaxLength = 3;
            this.grpRegistration.Controls.Add(this.txtAge);
            // lblGender
            this.lblGender.Location = new System.Drawing.Point(242, 142);
            this.lblGender.Size = new System.Drawing.Size(162, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            this.grpRegistration.Controls.Add(this.lblGender);
            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(242, 163);
            this.cmbGender.Size = new System.Drawing.Size(162, 26);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.TabIndex = 15;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            this.grpRegistration.Controls.Add(this.cmbGender);
            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(734, 20);
            this.btnRegister.Size = new System.Drawing.Size(108, 40);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.Enabled = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.Controls.Add(this.btnRegister);
            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(734, 68);
            this.btnUpdate.Size = new System.Drawing.Size(108, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.Controls.Add(this.btnUpdate);
            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(722, 28);
            this.btnRefresh.Size = new System.Drawing.Size(96, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.grpMembers.Controls.Add(this.btnRefresh);
            // dataGridView
            this.dataGridView.Location = new System.Drawing.Point(8, 28);
            this.dataGridView.Size = new System.Drawing.Size(700, 208);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.TabIndex = 19;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grpMembers.Controls.Add(this.dataGridView);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(854, 486);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClubRegistration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpRegistration.ResumeLayout(false);
            this.grpRegistration.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.GroupBox grpRegistration;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
