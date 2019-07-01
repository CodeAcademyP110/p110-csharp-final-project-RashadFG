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
    public partial class AdminReadPacket : Form
    {
        public AdminReadPacket(Packet packet)
        {
            InitializeComponent();
            label1.Text = packet.Name;
            label6.Text = packet.Date;
            label5.Text = packet.DateWeek;
            label4.Text = packet.Price.ToString() + "AZN";
        }
    }
}
