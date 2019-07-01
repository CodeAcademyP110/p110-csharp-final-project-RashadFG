using ColemanFitnessClub.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ColemanFitnessClub
{
    public partial class AdminEditPacket : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex2;
        private readonly Packet Pac;
        private readonly DataGridView dgt;

        public AdminEditPacket(ColemanIdmanClubuEntities2 _contex, Packet packet, DataGridView dgwPackets)
        {
            InitializeComponent();

            _contex2 = _contex;
            Pac = packet;
            dgt = dgwPackets;

            foreach (var control in flowLayoutPanel1.Controls)
            {
                var checkbox = (CheckBox)control;
                checkbox.Checked = false;
            }
        }

        private void AdminEditPacket_Load(object sender, EventArgs e)
        {
            foreach (var item in _contex2.Services)
            {
                CheckBox checkbox = new CheckBox()
                {
                    Tag = $"{item.Id}",
                    Text = item.Name
                };

                flowLayoutPanel1.Controls.Add(checkbox);
            }

            txtName.Text = Pac.Name;
            txtDate.Text = Pac.Date;
            txtDateWeek.Text = Pac.DateWeek;
            nmrcPrice.Value = Pac.Price;

            List<ServicesToPacket> listofpackage = _contex2.ServicesToPackets.Where(ser => ser.PacketId ==Pac.Id).ToList();

            foreach (var control in flowLayoutPanel1.Controls)
            {
                var checkbox = (CheckBox)control;

                foreach (var row in listofpackage)
                {
                    if (row.ServicesId == Convert.ToInt32(checkbox.Tag))
                    {
                        checkbox.Checked = true;
                    }
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Pac.Name = txtName.Text;
            Pac.Date = txtDate.Text;
            Pac.DateWeek = txtDateWeek.Text;
            Pac.Price = nmrcPrice.Value;

            foreach (var item in _contex2.ServicesToPackets.Where(x => x.PacketId == Pac.Id))
            {
                _contex2.ServicesToPackets.Remove(item);
            }

           await  _contex2.SaveChangesAsync();

            foreach (var item in flowLayoutPanel1.Controls)
            {
                CheckBox checkbox = (CheckBox)item;
                if (checkbox.Checked)
                {
                    ServicesToPacket servicesToPackage = new ServicesToPacket()
                    {
                        ServicesId = Convert.ToInt32(checkbox.Tag),
                        PacketId = Pac.Id
                    };
                    _contex2.ServicesToPackets.Add(servicesToPackage);
                }
            }
           await  _contex2.SaveChangesAsync();
            dgt.DataSource = _contex2.Packets.ToList();
            this.Close();
            MessageBox.Show("You Edited");
        }
    }
}
