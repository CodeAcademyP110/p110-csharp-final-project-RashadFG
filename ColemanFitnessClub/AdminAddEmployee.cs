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
using static   ColemanFitnessClub.Utilities.Hash;

namespace ColemanFitnessClub
{
    public partial class AdminAddEmployee : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;
        private readonly DataGridView dgw;

        public AdminAddEmployee(ColemanIdmanClubuEntities2 entitie, DataGridView dgw2)
        {
            InitializeComponent();
            _contex2 = entitie;
            dgw = dgw2;
            cmbRoles.DataSource = _contex2.Roles.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role selectedItem=cmbRoles.SelectedItem as Role;

            Employee emp = new Employee()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = ttxEmail.Text,
                Username = txtUsername.Text,
                Password = GetHash(txtPassword.Text),
                RoleId = selectedItem.Id,
                HasVerified=false
            };

            _contex2.Employees.Add(emp);
            _contex2.SaveChanges();
            dgw.DataSource = _contex2.Employees
           //     .Select(empe => new
           // {
                
           //     Fullname = string.Concat(empe.Firstname, " ", empe.Lastname),
           //     Username = empe.Username,
           //     Email = empe.Email,
           //     Password = empe.Password,
           //     Role = empe.Role.Name
           // }
           //)
           .ToList();
            this.Close();
        }
    }
}
