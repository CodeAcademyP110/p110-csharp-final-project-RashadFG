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
    public partial class AdminAddServices : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;
        private readonly DataGridView dgt;

        public AdminAddServices(ColemanIdmanClubuEntities2 _contex,  DataGridView dgtServices)
        {
            InitializeComponent();
            _contex2 = _contex;
            dgt = dgtServices;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Service service = new Service()
            {
                Name = txtName.Text,
                Date = Convert.ToInt32(txtDate.Text),
                Price = numericUpDown1.Value
            };

            _contex2.Services.Add(service);
            await _contex2.SaveChangesAsync();

            dgt.DataSource = _contex2.Services.ToList();
            this.Close();
        }
    }
}
