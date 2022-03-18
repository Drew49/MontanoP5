using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP5
{
    class PlasticSprocket : Sprocket
    {
        PlasticSprocket()
        {
            Calc();
        }

        public PlasticSprocket(int numOfTeeth, int numOfItems, int itemID) : base(numOfTeeth, numOfItems, itemID)
        {
            Calc();
        }

        protected override void Calc()
        {
            Price = (decimal)(NumOfTeeth * NumOfItems * .02);
        }

        public override string ToString()
        {
            return base.ToString() + "Material: Plastic.";
        }



    }
}

