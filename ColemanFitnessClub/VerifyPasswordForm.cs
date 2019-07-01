using ColemanFitnessClub.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColemanFitnessClub.Utilities.Hash;

namespace ColemanFitnessClub
{
    public partial class VerifyPasswordForm : Form
    {
        public readonly Employee loggedEmployee;
        public readonly ColemanIdmanClubuEntities2 _contex;
        private Employee employee;

        public VerifyPasswordForm(Employee employee)
        {
            InitializeComponent();
            loggedEmployee = employee;
            _contex = new ColemanIdmanClubuEntities2();
        }

        private async  void btnLogIn_Click(object sender, EventArgs e)
        {
            string defaultPassword = txtDefault.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if(defaultPassword==string.Empty || newPassword == string.Empty || confirmPassword == string.Empty)
            {
                ShowMessage("Please fill all fields", "Error");
                return;
            }

            if (!CheckHashCode(loggedEmployee.Password, defaultPassword))
            {
                ShowMessage( "Current password is not  invalid.", "Error");
                return;
            }

            if (newPassword != confirmPassword)
            {
                ShowMessage( "New password and confirm password don't match.", "Error");
                return;
            }

            Employee UpdateEmployee = await _contex.Employees.FindAsync(loggedEmployee.Id);
            UpdateEmployee.Password = GetHash(newPassword);
            UpdateEmployee.HasVerified = true;
            await _contex.SaveChangesAsync();

            if (UpdateEmployee.Role.Name == Roles.Employee.ToString())
            {
                this.Close();
                new Employees(employee).ShowDialog();
            }

        }

        private void ShowMessage(string content, string Eror, bool IsError = true)
        {
            MessageBox.Show(content,
                            Eror,
                            MessageBoxButtons.OK,
                            IsError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
    }
}
