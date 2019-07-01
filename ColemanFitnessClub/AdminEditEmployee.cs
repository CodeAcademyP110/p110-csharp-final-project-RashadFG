using ColemanFitnessClub.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ColemanFitnessClub
{
    public partial class AdminEditEmployee : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;
        private readonly Employee emp;
        private readonly DataGridView dgt;

        public AdminEditEmployee(ColemanIdmanClubuEntities2 _contex, Employee employee, DataGridView dgwdgtEmployee)
        {
            InitializeComponent();
            _contex2 = _contex;
            emp = employee;
            dgt = dgwdgtEmployee;
        }

        private void AdminEditEmployee_Load(object sender, EventArgs e)
        {
            cmbRolesE.DataSource = _contex2.Roles.ToList();

            txtFirstnameE.Text = emp.Firstname;
            txtLastnameE.Text = emp.Lastname;
            ttxEmailE.Text = emp.Email;
            txtPasswordE.Text = emp.Password;
            txtUsernameE.Text = emp.Username;
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            Role role = cmbRolesE.SelectedItem as Role;

            emp.Firstname = txtFirstnameE.Text;
            emp.Lastname = txtLastnameE.Text;
            emp.Email = ttxEmailE.Text;
            emp.Password = txtPasswordE.Text;
            emp.Username = txtUsernameE.Text;
            emp.Role.Name = role.Name;

            _contex2.SaveChanges();
            dgt.DataSource = _contex2.Employees.ToList();
            this.Close();
        }

     
    }
}
