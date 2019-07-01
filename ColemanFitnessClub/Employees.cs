using ColemanFitnessClub.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ColemanFitnessClub
{
    public partial class Employees : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex;
        private readonly Employee emp;

        public Employees(Employee employee)
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
            emp = employee;
            label1.Text = emp.ToString();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
         
            cmbservices.DataSource = _contex.Services.ToList();
            cmbPacket.DataSource = _contex.Packets.ToList();
            cmbCustoemrs.DataSource = _contex.Customers.ToList();

            dataGridView1.DataSource = _contex.OrderDetails.ToList();


            cmbPacket.SelectedIndex = -1;
            cmbservices.SelectedIndex = -1;
            cmbDate.SelectedIndex = 0;
            txtPrices.Text = string.Empty;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Service selectedService = cmbservices.SelectedItem as Service;
            Packet selectedPacket = cmbPacket.SelectedItem as Packet;
            Customer selectedCustomer = cmbCustoemrs.SelectedItem as Customer;

            Order order = new Order()
            {
                Date = dateTimePicker1.Value,
                EmployeeId = emp.Id,
                Price = Convert.ToDecimal(txtPrices.Text)
            };

            _contex.Orders.Add(order);
            await _contex.SaveChangesAsync();

            if (cmbservices.SelectedIndex >=0 && cmbPacket.SelectedIndex == -1)
            {
                OrderDetail orderDetail = _contex.OrderDetails.Add(new OrderDetail
                {
                    CustomerId = selectedCustomer.Id,
                    ServicesId = selectedService.Id,
                    PacketId = null,
                    OrdersId = order.Id
                });

                _contex.OrderDetails.Add(orderDetail);
                await _contex.SaveChangesAsync();
            }

            if (cmbservices.SelectedIndex == -1 && cmbPacket.SelectedIndex >=0)
            {
                OrderDetail orderDetail = _contex.OrderDetails.Add(new OrderDetail
                {
                    CustomerId = selectedCustomer.Id,
                    ServicesId = null,
                    PacketId = selectedPacket.Id,
                    OrdersId = order.Id
                });

                _contex.OrderDetails.Add(orderDetail);
                await _contex.SaveChangesAsync();
            }

            dataGridView1.DataSource = _contex.OrderDetails.ToList();
            MessageBox.Show("Order is accepted");
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCustomer(cmbCustoemrs).ShowDialog();
        }

        private void cmbCustoemrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustoemrs.DataSource = _contex.Customers.ToList();
        }

        private void cmbservices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbservices.SelectedIndex != -1)
            {
                Service selecectedItem = cmbservices.SelectedItem as Service;

                int SelectedDate = Convert.ToInt32(cmbDate.SelectedItem);

                txtPrices.Text = (SelectedDate * selecectedItem.Price).ToString();
            }
            
                
        }

        private void cmbPacket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPacket.SelectedIndex != -1)
            {
                Packet selecectedItem = cmbPacket.SelectedItem as Packet;
                txtPrices.Text = selecectedItem.Price.ToString();
            }

        }
    }
}
