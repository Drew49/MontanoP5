using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public string toString()
        {
            return "Ship to: " + Street + "\n" + City + ", " + State + ZipCode;
        }
        
    }
}
