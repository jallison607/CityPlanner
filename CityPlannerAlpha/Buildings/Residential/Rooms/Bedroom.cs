using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Buildings.Residential.Rooms
{
    class Bedroom : Room
    {
        private bool isLargeBedroom;

        public Bedroom(bool largeBedroom)
        {
            isLargeBedroom = largeBedroom;
        }
    }
}
