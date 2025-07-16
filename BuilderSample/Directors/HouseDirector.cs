using BuilderSample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample.Directors
{
    public class HouseDirector
    {
        public House BuildHouse(HouseBuilder houseBuilder)
        {
            houseBuilder.CreateNewHouse();
            houseBuilder.SetDoor();
            houseBuilder.SetWindows();
            houseBuilder.SetWall();
            houseBuilder.SetFoundation();
            houseBuilder.SetRoof();
            return houseBuilder.GetHouse();
        }
    }
}
