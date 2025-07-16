using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders
{
    public class NormalHouseBuilder : HouseBuilder
    {
        public override void SetDoor()
        {
            houseObject.Door = 2;
        }
        public override void SetWindows()
        {
            houseObject.Windows = 4;
        }

        public override void SetWall()
        {
            houseObject.Wall = "Brick Wall";
        }

        public override void SetFoundation()
        {
            houseObject.Foundation = "Concrete Foundation";
        }

        public override void SetRoof()
        {
            houseObject.Roof = "Concrete Roof";
        }
    }
}
