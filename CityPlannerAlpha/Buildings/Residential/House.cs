using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Buildings.Residential
{
    class House : Building
    {

        public House()
        {
            this.BuildingType = BuildingZone.Residential;
        }

        public void setFloors(int numberOfFloors)
        {
            this.BuildingFloors = new List<BuildingFloor>(numberOfFloors);
        }
        
        public void addRoom(Room tmpRoom, int floorNumber)
        {
            this.BuildingFloors[floorNumber].addRoom(tmpRoom);
        }

        

    }
}
