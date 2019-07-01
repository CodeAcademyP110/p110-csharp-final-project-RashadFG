using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColemanFitnessClub.Model
{
    public partial class Service
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Packet
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Employee
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }

    public partial class Customer
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }

    public partial class Order
    {
        public override string ToString()
        {
            return Date +" / " + Price;

        }
    }
}
