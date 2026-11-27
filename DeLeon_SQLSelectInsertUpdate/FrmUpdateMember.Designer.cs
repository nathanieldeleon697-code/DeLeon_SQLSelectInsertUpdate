namespace DeLeon_SQLSelectInsertUpdate
{
    partial class FrmUpdateMember
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblStudentId = new System.Windows.Forms.Label();
            this.cmbStudentId = new System.Windows.Forms.ComboBox();
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
            this.lblProgram = new System.Windows.Forms.Label();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblStudentId
            this.lblStudentId.Location = new System.Drawing.Point(18, 16);
            this.lblStudentId.Size = new System.Drawing.Size(240, 20);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            this.Controls.Add(this.lblStudentId);
            // cmbStudentId
            this.cmbStudentId.Location = new System.Drawing.Point(18, 37);
            this.cmbStudentId.Size = new System.Drawing.Size(240, 26);
            this.cmbStudentId.Name = "cmbStudentId";
            this.cmbStudentId.TabIndex = 1;
            this.cmbStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentId.SelectedIndexChanged += new System.EventHandler(this.cmbStudentId_SelectedIndexChanged);
            this.Controls.Add(this.cmbStudentId);
            // lblLastName
            this.lblLastName.Location = new System.Drawing.Point(18, 76);
            this.lblLastName.Size = new System.Drawing.Size(220, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            this.Controls.Add(this.lblLastName);
            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(18, 97);
            this.txtLastName.Size = new System.Drawing.Size(220, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.TabIndex = 3;
            this.txtLastName.MaxLength = 50;
            this.Controls.Add(this.txtLastName);
            // lblFirstName
            this.lblFirstName.Location = new System.Drawing.Point(18, 136);
            this.lblFirstName.Size = new System.Drawing.Size(220, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            this.Controls.Add(this.lblFirstName);
            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(18, 157);
            this.txtFirstName.Size = new System.Drawing.Size(220, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.MaxLength = 50;
            this.Controls.Add(this.txtFirstName);
            // lblMiddleName
            this.lblMiddleName.Location = new System.Drawing.Point(18, 196);
            this.lblMiddleName.Size = new System.Drawing.Size(220, 20);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle name:";
            this.Controls.Add(this.lblMiddleName);
            // txtMiddleName
            this.txtMiddleName.Location = new System.Drawing.Point(18, 217);
            this.txtMiddleName.Size = new System.Drawing.Size(220, 26);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.TabIndex = 7;
            this.txtMiddleName.MaxLength = 50;
            this.Controls.Add(this.txtMiddleName);
            // lblAge
            this.lblAge.Location = new System.Drawing.Point(18, 256);
            this.lblAge.Size = new System.Drawing.Size(140, 20);
            this.lblAge.Name = "lblAge";
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            this.Controls.Add(this.lblAge);
            // txtAge
            this.txtAge.Location = new System.Drawing.Point(18, 277);
            this.txtAge.Size = new System.Drawing.Size(140, 26);
            this.txtAge.Name = "txtAge";
            this.txtAge.TabIndex = 9;
            this.txtAge.MaxLength = 3;
            this.Controls.Add(this.txtAge);
            // lblGender
            this.lblGender.Location = new System.Drawing.Point(18, 316);
            this.lblGender.Size = new System.Drawing.Size(180, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            this.Controls.Add(this.lblGender);
            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(18, 337);
            this.cmbGender.Size = new System.Drawing.Size(180, 26);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.TabIndex = 11;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            this.Controls.Add(this.cmbGender);
            // lblProgram
            this.lblProgram.Location = new System.Drawing.Point(18, 376);
            this.lblProgram.Size = new System.Drawing.Size(240, 20);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.TabIndex = 12;
            this.lblProgram.Text = "Program:";
            this.Controls.Add(this.lblProgram);
            // cmbProgram
            this.cmbProgram.Location = new System.Drawing.Point(18, 397);
            this.cmbProgram.Size = new System.Drawing.Size(240, 26);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.TabIndex = 13;
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Information Systems", "BS Business Administration", "BS Accountancy", "BS Hospitality Management", "BS Tourism Management" });
            this.Controls.Add(this.cmbProgram);
            // btnConfirm
            this.btnConfirm.Location = new System.Drawing.Point(84, 448);
            this.btnConfirm.Size = new System.Drawing.Size(118, 36);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.Controls.Add(this.btnConfirm);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSize = new System.Drawing.Size(280, 502);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUpdateMember_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.ComboBox cmbStudentId;
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
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.Button btnConfirm;
    }
}
