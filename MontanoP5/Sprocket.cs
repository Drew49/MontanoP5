using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    public abstract class Sprocket
    {
        public int NumOfTeeth { get; set; }
        public int NumOfItems { get; set; }

        public decimal Price { get; set; }
        public int ItemID { get; private set; }
      

        public Sprocket()
        {
            Calc();
        }

        protected Sprocket(int numOfTeeth, int numOfItems, int itemID)
        {
            NumOfTeeth = numOfTeeth;
            NumOfItems = numOfItems;
            ItemID = itemID;
            Calc();
        }

        protected abstract void Calc();

        public override string ToString()
        {
            return "Order number: " + ItemID
                + ". Amount of sprockets: " + NumOfItems
                + ". Number of teeth: " + NumOfTeeth
                + ". Price: " + Price;
                
                
        }


    }
}
