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
    public partial class AdminAddPacket : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex;

        public AdminAddPacket()
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
            dgwPackets.DataSource = _contex.Packets.ToList(); 

            dgwPackets.Columns[0].Visible = false;
            dgwPackets.Columns[6].Visible = false;
            dgwPackets.Columns[5].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AdminAddAddPacket().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwPackets.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwPackets.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgwPackets.Rows[selectedrowindex];

                Packet packet = _contex.Packets.Find(selectedRow.Cells["Id"].Value);

                new AdminEditPacket(_contex, packet, dgwPackets).ShowDialog();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (dgwPackets.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwPackets.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgwPackets.Rows[selectedrowindex];

                Packet packet = _contex.Packets.Find(selectedRow.Cells["Id"].Value);

                new AdminReadPacket(packet).ShowDialog();
            }
         
        }
    }
}
