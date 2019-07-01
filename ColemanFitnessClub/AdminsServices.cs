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
    public partial class AdminsServices : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex;

        public AdminsServices()
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
            dgtServices.DataSource = _contex.Services.ToList();

            dgtServices.Columns[0].Visible = false;
            dgtServices.Columns[4].Visible = false;
            dgtServices.Columns[5].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AdminAddServices(_contex, dgtServices).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgtServices.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtServices.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtServices.Rows[selectedrowindex];

                var Ser = _contex.Services.Find(selectedRow.Cells["Id"].Value);

                _contex.Services.Remove(Ser);
                _contex.SaveChanges();

                MessageBox.Show("Deleted");

                dgtServices.DataSource = _contex.Services.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgtServices.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtServices.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtServices.Rows[selectedrowindex];

                var Ser = _contex.Services.Find(selectedRow.Cells["Id"].Value);

                new AdminEditAddServices(_contex, Ser, dgtServices).ShowDialog();
               
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (dgtServices.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtServices.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtServices.Rows[selectedrowindex];

                var Ser = _contex.Services.Find(selectedRow.Cells["Id"].Value);

                new AdminReadServices(Ser).ShowDialog();

            }
        }
    }
}
