using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine4.models
{
    public class User
    {
        public List<Drink> Drinks { get; set; } = new List<Drink>();
    }
}
