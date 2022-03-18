using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    class SprocketOrder
    {
        List<Sprocket> order = new List<Sprocket>();

        public Address Address { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }

        /*public void Add(List<Sprocket> newOrder)
        {
            List<Sprocket> order = new Sprocket();
            newOrder.Add(order)

        }*/
    }
}
