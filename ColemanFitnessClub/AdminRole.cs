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

namespace ColemanFitnessClub
{
    public partial class AdminRole : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;

        public AdminRole()
        {
            InitializeComponent();
            _contex2 = new ColemanIdmanClubuEntities2();
        }

        private void AdminRole_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = _contex2.Roles.Where(r=>r.Id!=1).ToList();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role selectedItem = cmbRole.SelectedItem as Role;
            txtName.Text = selectedItem.Name;
        }

        private async  void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = new Role()
            {
                Name = txtName.Text
            };

            _contex2.Roles.Add(role);
            await _contex2.SaveChangesAsync();
            cmbRole.DataSource = _contex2.Roles.Where(r => r.Id != 1).ToList();

            txtName.Text = " ";
        }

        private async void btnDlete_Click(object sender, EventArgs e)
        {
            Role role = cmbRole.SelectedItem as Role;
            _contex2.Roles.Remove(role);
            await  _contex2.SaveChangesAsync();

            cmbRole.DataSource = _contex2.Roles.Where(r => r.Id != 1).ToList();
        }

        private async void lblEdit_Click(object sender, EventArgs e)
        {
            Role role = cmbRole.SelectedItem as Role;
            role.Name = txtName.Text;

            await _contex2.SaveChangesAsync();
            cmbRole.DataSource = _contex2.Roles.Where(r => r.Id != 1).ToList();

        }
    }
}
