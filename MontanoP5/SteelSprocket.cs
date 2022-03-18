using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    class SteelSprocket : Sprocket
    {
        decimal newPrice;
    
        SteelSprocket()
        {
            
        }

        public SteelSprocket(int numOfTeeth, int numOfItems, int itemID) : base(numOfTeeth, numOfItems, itemID)
        {
   
      
        }


        protected override void Calc()
        {
            Price = (decimal) (NumOfTeeth * NumOfItems * .05);
        }

        public override string ToString()
        {
            return base.ToString() + "Material: Steel.";
        }



    }
}
