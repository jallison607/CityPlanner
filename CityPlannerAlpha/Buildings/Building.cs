using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Buildings
{
    public abstract class Building
    {
        public enum BuildingZone { Residential, Comercial, Industrial }
        protected BuildingZone BuildingType;
        protected List<BuildingFloor> BuildingFloors = new List<BuildingFloor>();
    }
}
