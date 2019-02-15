using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HomeBuilder : AHomeBuilder
    { 
        public override void FundamentCreate()
        {
            Home.FundamentOptions = FundamentOptions.WithBasement;
        }

        public override void HouseBasicCreate()
        {
            Home.HouseMaterial = HouseMaterial.Stone;
        }

        public override void RoofCreate()
        {
            Home.RoofType = RoofType.Basic;
        }
    }
}
