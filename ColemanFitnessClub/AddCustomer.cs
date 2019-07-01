using ColemanFitnessClub.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ColemanFitnessClub
{
    public partial class AddCustomer : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex;
        private readonly ComboBox cmb;

        public AddCustomer(ComboBox cbmCustomer)
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
            cmb = cbmCustomer;
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstname = txtCustomerName.Text;
            string lastname = txtCustomerLastName.Text;
            string email = txtEmail.Text;

            if (firstname == " " || lastname == " " || email == " ")
            {
                ShowMessage("Your Username or Password is not valid ", "Eror");
                return;
            }

            Customer customer = new Customer()
            {
                Firstname = firstname,
                Lastname = lastname,
                Email = email
            };

            _contex.Customers.Add(customer);
             await _contex.SaveChangesAsync();

            cmb.DataSource = _contex.Customers.ToList(); 

            txtCustomerName.Text = string.Empty;
            txtCustomerLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;

           
            this.Close();
        }

        private void ShowMessage(string content, string Eror, bool IsError = true)
        {
            MessageBox.Show(content,
                            Eror,
                            MessageBoxButtons.OK,
                            IsError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
    }
}
