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
    public partial class AdminEditAddServices : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;
        private readonly Service service;
        private readonly DataGridView dgt;

        public AdminEditAddServices(ColemanIdmanClubuEntities2 __contex,Service ser,DataGridView dataGrid)
        {
            InitializeComponent();
            _contex2 = __contex;
            service = ser;
            dgt = dataGrid;

            txtName.Text = ser.Name;
            txtDate.Text = ser.Date.ToString();
            numericUpDown1.Value = ser.Price;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            service.Name = txtName.Text;
            service.Date = Convert.ToInt32(txtDate.Text);
            service.Price = numericUpDown1.Value;

            await _contex2.SaveChangesAsync();

            dgt.DataSource = _contex2.Services.ToList();
            this.Close();
        }
    }
}
