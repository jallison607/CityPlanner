using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Buildings.Residential
{
    class ResidentialBuildingFactory
    {
        private Building currentBuilding = null;
        
        //House Room Rules
        private int H_MIN_KITCHEN = 1;
        private int H_MAX_KITCHEN = 1;
        private int H_MIN_DINING = 0;
        private int H_MAX_DINING = 1;
        private int H_MIN_LIVING = 1;
        private int H_MAX_LIVING = 2;
        //Bedrooms based on population capacity, Randomly generated bedrooms small for 1 population large for 2
        



        int capacity = 0;
        /// <summary>
        /// Factory Used to create Residential buildings of the passed capacity
        /// </summary>
        /// <param name="housePersonCapacity"></param>
        /// <returns>Returns House, Multiplex or Appartment Complex</returns>
        public Building createResidentialBuilding(int housePersonCapacity)
        {
            capacity = housePersonCapacity;
            if (capacity <= 3) /// House
            {
                currentBuilding = new House();
            }
            else if (capacity <= 6) //House or MultiPlex
            {
                int randomValue = CityPlanner.r.Next(0, 1);
                if (randomValue == 0)
                {
                    currentBuilding = new House();
                }
                else
                {
                    currentBuilding = new Multiplex();
                }
            }
            else if (capacity <= 10) //Duplex or Appartment Complex
            {
                int randomValue = CityPlanner.r.Next(0, 1);
                if (randomValue == 0)
                {
                    currentBuilding = new Multiplex();
                }
                else
                {
                    currentBuilding = new AppartmentComplex();
                }
            }
            else //Appartment Complex
            {
                currentBuilding = new AppartmentComplex();
            }

            
            generateRooms();

            Building newBuilding = currentBuilding;
            currentBuilding = null;
            capacity = 0;

            return newBuilding;
        }

        private void generateRooms(){

            if (currentBuilding.GetType() == typeof(House))
            {
                House aHouse = (House)currentBuilding;
                List<Room> roomsToAdd = new List<Room>();
                
                //Generate Bedroom(s)
                int remainingCapacity = capacity;
                while (remainingCapacity > 0)
                {
                    if (remainingCapacity >= 2)
                    {
                        int roomCap = CityPlanner.r.Next(1, 2);
                        roomsToAdd.Add(new Rooms.Bedroom(roomCap == 2));
                        remainingCapacity -= roomCap;
                    }
                    else
                    {
                        roomsToAdd.Add(new Rooms.Bedroom(false));
                        remainingCapacity = 0;
                    }
                }

                //Generate Kitchen
                roomsToAdd.Add(new Rooms.Kitchen());

                //Generate Living Room(s)
                int numOfRooms = CityPlanner.r.Next(1, 2);
                for (int i = 0; i < numOfRooms; i++)
                {
                    roomsToAdd.Add(new Rooms.Living_Room());
                }

                //Generate Dinning Room
                numOfRooms = CityPlanner.r.Next(0, 1);
                for (int i = 0; i < numOfRooms; i++)
                {
                    roomsToAdd.Add(new Rooms.Dinning_Room());
                }

                //Generate Storage Room(s)

            }

        }
        
    }
}
