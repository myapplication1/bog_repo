using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoanModule.Models {
    public class Order {
        public int AccountID { get; set; }
        public DateTime AccountDate { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
