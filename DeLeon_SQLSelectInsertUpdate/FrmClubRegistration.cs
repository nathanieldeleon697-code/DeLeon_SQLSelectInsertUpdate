using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DeLeon_SQLSelectInsertUpdate
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        public FrmClubRegistration() { InitializeComponent(); }
        private void FrmClubRegistration_Load(object sender, EventArgs e) { ConnectAndRefresh(); }
        private void ConnectAndRefresh()
        {
            try
            {
                DatabaseSetup.Initialize();
                if (clubRegistrationQuery == null) clubRegistrationQuery = new ClubRegistrationQuery();
                RefreshListOfClubMembers();
                btnRegister.Enabled = true; btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                btnRegister.Enabled = false; btnUpdate.Enabled = false;
                MessageBox.Show("Cannot open ClubDB. Check that SQL Server Express (SQLEXPRESS) is running and your Windows account has access, then click Refresh to retry.\n\n" + ex.Message,
                    "Database connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;
            count = clubRegistrationQuery.GetLastRegistrationID();
        }
        private int RegistrationID() { count = clubRegistrationQuery.GetLastRegistrationID(); return checked(++count); }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim(); MiddleName = txtMiddleName.Text.Trim(); LastName = txtLastName.Text.Trim();
            Gender = cmbGender.Text; Program = cmbProgram.Text;
            string error;
            if (!MemberValidation.Validate(txtStudentId.Text.Trim(), FirstName, MiddleName, LastName, txtAge.Text.Trim(), Gender, Program, out StudentId, out Age, out error))
            { MessageBox.Show(error, "Check input", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                ID = RegistrationID();
                clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627 || ex.Number == 2601 ? "Student ID or registration ID already exists. Click Refresh and try again." : ex.Message,
                    "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Registration failed"); return; }
            txtStudentId.Clear(); txtFirstName.Clear(); txtMiddleName.Clear(); txtLastName.Clear(); txtAge.Clear();
            cmbGender.SelectedIndex = -1; cmbProgram.SelectedIndex = -1;
            MessageBox.Show("Member registered successfully.", "Registration");
            ConnectAndRefresh(); txtStudentId.Focus();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var form = new FrmUpdateMember())
                if (form.ShowDialog(this) == DialogResult.OK) ConnectAndRefresh();
        }
        private void btnRefresh_Click(object sender, EventArgs e) { ConnectAndRefresh(); }
        private void FrmClubRegistration_FormClosed(object sender, FormClosedEventArgs e)
        { if (clubRegistrationQuery != null) clubRegistrationQuery.Dispose(); }
    }
}
