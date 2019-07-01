using ColemanFitnessClub.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using static ColemanFitnessClub.Utilities.Hash;

namespace ColemanFitnessClub
{
    public partial class Form1 : Form
    {
        public readonly ColemanIdmanClubuEntities2 _contex;
        public Form1()
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //validation start
            if (username == string.Empty || password == string.Empty)
            {
                ShowMessage("Your Username or Password is not valid ", "Eror");
                return;
            }

            Employee employee = _contex.Employees.FirstOrDefault(ump => ump.Username.ToLower() == username.ToLower());

            if (employee == null)
            {
                ShowMessage("Your Username or Password is not valid ", "Eror");
                return;
            }

            if (!CheckHashCode(employee.Password, password))
            {
                ShowMessage("Your Username or Password is not valid ", "Eror");
                return;
            }
            //validation End

            //Entering worker or Admin Form
            switch (employee.RoleId)
            {
                case 1:
                    new AdminForm().ShowDialog();
                    break;
                case 2:
                    if (employee.HasVerified == false)
                        new VerifyPasswordForm(employee).ShowDialog();
                    else
                        new Employees(employee).ShowDialog();
                    break;
                default:
                    ShowMessage("Unknown login error", "Unknown error occurred. Please, contact Admin!");
                    break;
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
