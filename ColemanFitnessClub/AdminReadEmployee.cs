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
    public partial class AdminReadEmployee : Form
    {
        public AdminReadEmployee(Employee employe)
        {
            InitializeComponent();
            label1.Text = employe.Firstname;
            label6.Text = employe.Lastname;
            label5.Text = employe.Username;
            label4.Text = employe.Email;
            label3.Text = employe.Password;
            label2.Text = employe.Role.Name;
        }
    }
}
