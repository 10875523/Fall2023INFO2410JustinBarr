using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDetails
{
    public class Phone
    {
        public Phone(string[] tempPhone)
        {
            Make = tempPhone[0];
            Model = tempPhone[1];
            Display = tempPhone[2];
            Storage = tempPhone[3];
            Price = decimal.Parse(tempPhone[4]);
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Display { get; set; }
        public string Storage { get; set; }
        public decimal Price { get; set; }
    }
}
