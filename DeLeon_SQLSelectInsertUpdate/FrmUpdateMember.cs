using System;
using System.Windows.Forms;
namespace DeLeon_SQLSelectInsertUpdate
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery query;
        private bool loading;
        public FrmUpdateMember() { InitializeComponent(); }
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            try
            {
                query = new ClubRegistrationQuery(); query.DisplayList();
                loading = true;
                cmbStudentId.DisplayMember = "StudentId"; cmbStudentId.ValueMember = "StudentId";
                cmbStudentId.DataSource = query.dataTable; cmbStudentId.SelectedIndex = -1;
                loading = false;
                if (query.dataTable.Rows.Count == 0) MessageBox.Show("No members yet. Register a member first.", "Update member");
            }
            catch (Exception ex) { loading = false; MessageBox.Show(ex.Message, "Cannot load members"); }
        }
        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading || query == null) return;
            btnConfirm.Enabled = false;
            txtFirstName.Clear(); txtMiddleName.Clear(); txtLastName.Clear(); txtAge.Clear();
            cmbGender.SelectedIndex = -1; cmbProgram.SelectedIndex = -1;
            long studentId;
            if (cmbStudentId.SelectedValue == null || !long.TryParse(cmbStudentId.SelectedValue.ToString(), out studentId)) return;
            try
            {
                if (!query.FindStudent(studentId)) return;
                txtFirstName.Text = query._FirstName; txtMiddleName.Text = query._MiddleName; txtLastName.Text = query._LastName;
                txtAge.Text = query._Age.ToString();
                if (!cmbGender.Items.Contains(query._Gender)) cmbGender.Items.Add(query._Gender);
                if (!cmbProgram.Items.Contains(query._Program)) cmbProgram.Items.Add(query._Program);
                cmbGender.SelectedItem = query._Gender; cmbProgram.SelectedItem = query._Program;
                btnConfirm.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Cannot load member"); }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            long studentId; int age; string error;
            if (!MemberValidation.Validate(cmbStudentId.Text, txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(), txtLastName.Text.Trim(),
                txtAge.Text.Trim(), cmbGender.Text, cmbProgram.Text, out studentId, out age, out error))
            { MessageBox.Show(error, "Check input", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Save changes for student " + studentId + "?", "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                if (!query.UpdateStudent(studentId, txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(), txtLastName.Text.Trim(), age, cmbGender.Text, cmbProgram.Text))
                { MessageBox.Show("This member no longer exists. Close and reopen the update window."); return; }
                MessageBox.Show("Member updated successfully.", "Update member");
                DialogResult = DialogResult.OK; Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void FrmUpdateMember_FormClosed(object sender, FormClosedEventArgs e)
        { if (query != null) query.Dispose(); }
    }
}
