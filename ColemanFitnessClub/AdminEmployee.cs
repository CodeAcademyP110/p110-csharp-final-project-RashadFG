using ColemanFitnessClub.Model;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ColemanFitnessClub
{
    public partial class EmployeeMain : Form
    {
        private readonly ColemanIdmanClubuEntities2 _contex;

        public EmployeeMain()
        {
            InitializeComponent();
            _contex = new ColemanIdmanClubuEntities2();
            dgtEmployee.DataSource = _contex.Employees.ToList();

            dgtEmployee.Columns[0].Visible = false;
            dgtEmployee.Columns[6].Visible = false;
            dgtEmployee.Columns[7].Visible = false;
            dgtEmployee.Columns[9].Visible = false;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            new AdminAddEmployee(_contex, dgtEmployee).Show();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dgtEmployee.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtEmployee.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtEmployee.Rows[selectedrowindex];


                var Emp = _contex.Employees.Find(selectedRow.Cells["Id"].Value);

                _contex.Employees.Remove(Emp);
                _contex .SaveChanges();


                MessageBox.Show("Deleted");

                dgtEmployee.DataSource = _contex.Employees.ToList();
            }
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            if (dgtEmployee.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtEmployee.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtEmployee.Rows[selectedrowindex];

                Employee employee = _contex.Employees.Find(selectedRow.Cells["Id"].Value);

                new AdminReadEmployee(employee).ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgtEmployee.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgtEmployee.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgtEmployee.Rows[selectedrowindex];

                Employee employee = _contex.Employees.Find(selectedRow.Cells["Id"].Value);

                new AdminEditEmployee(_contex,employee,dgtEmployee).ShowDialog();
            }
        
        }
    }
}
