using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Builders
{
    public abstract class HouseBuilder
    {
        protected House houseObject;

        public abstract void SetDoor();
        public abstract void SetWindows();
        public abstract void SetWall();
        public abstract void SetFoundation();
        public abstract void SetRoof();
        public void CreateNewHouse()
        {
            houseObject = new House();
        }

        public House GetHouse()
        {
            return houseObject;
        }
    }
}
