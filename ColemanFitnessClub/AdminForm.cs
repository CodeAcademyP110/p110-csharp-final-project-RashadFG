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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeMain().ShowDialog();
        }

        private void packetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminAddPacket().ShowDialog(); 
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminsServices().ShowDialog();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminRole().ShowDialog();
        }
    }
}
