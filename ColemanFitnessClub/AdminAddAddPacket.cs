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
    public partial class AdminAddAddPacket : Form
    {
        private readonly ColemanIdmanClubuEntities2 db;

        public AdminAddAddPacket()
        {
            InitializeComponent();
            db = new ColemanIdmanClubuEntities2();
           
            foreach (var item in db.Services)
            {
                CheckBox checkbox = new CheckBox() {
                    Tag = $"{item.Id}",
                    Text = item.Name
                };

                flowLayoutPanel1.Controls.Add(checkbox);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Packet packet = new Packet() {
                DateWeek = txtDate.Text,
                Price = nmrcPrice.Value,
                Name=txtName.Text,
                Date=txtDate.Text
            };

            db.Packets.Add(packet);
            await  db.SaveChangesAsync();
           
            foreach (var item in flowLayoutPanel1.Controls)
            {
                CheckBox checkBox = (CheckBox)item;

                if (checkBox.Checked)
                {
                    ServicesToPacket serviceToPackage = new ServicesToPacket() {
                        ServicesId = Convert.ToInt32(checkBox.Tag),
                        PacketId = packet.Id
                    };

                    db.ServicesToPackets.Add(serviceToPackage);
                }
            }
           
            await db.SaveChangesAsync();
            
            this.Close();
            MessageBox.Show("You add new packet");
        }
    }
}
