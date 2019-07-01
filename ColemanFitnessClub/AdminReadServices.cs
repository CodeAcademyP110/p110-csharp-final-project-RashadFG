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
    public partial class AdminReadServices : Form
    {
        public AdminReadServices(Service service)
        {
            InitializeComponent();
            label4.Text =service.Price.ToString();
            label5.Text = service.Date.ToString();
            label1.Text = service.Name;
        }
    }
}
