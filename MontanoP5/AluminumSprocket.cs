using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    class AluminumSprocket:Sprocket
    {
        AluminumSprocket()
        {
            Calc();
        }

        public AluminumSprocket(int numOfTeeth, int numOfItems, int itemID) : base(numOfTeeth, numOfItems, itemID)
        {
            Calc();
        }

        protected override void Calc()
        {
            Price = (decimal)(NumOfTeeth * NumOfItems * .04);
        }

        public override string ToString()
        {
            return base.ToString() + "Material: Aluminum.";
        }



    }
}

