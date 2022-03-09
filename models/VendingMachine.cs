using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine4.models
{
    public class VendingMachine
    {
        public double cash { get; set; }
        public List<Drink> Drinks { get; set; } = new List<Drink>();
    }
}
