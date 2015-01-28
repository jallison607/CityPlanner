using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Buildings
{
    class BuildingFloor
    {
        private List<Room> rooms = new List<Room>();
        private bool isBasement;

        public void addRoom(Room tmpNewRoom)
        {
            rooms.Add(tmpNewRoom);
        }

        public List<Room> getRoomsOnFloor()
        {
            return this.rooms;
        }
    }
}
