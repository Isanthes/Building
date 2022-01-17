using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Building : AbstractBuilding
    {
        const double MAX_CAPACITY = 300;
        double totalAarea = 0;
        int totalRooms = 0;
        double totalCpacity = 0;

        List<Floor> floors = new List<Floor>();

        public Building(List<Floor>floors)
        {
            if (floors.Count >= 5)
            {
                for (int i = 0; i < floors.Count; i++)
                {
                    this.floors.Add(floors[i]);
                }
            }
            else
            {
                Console.WriteLine(" You must have at least 5 floors !");
                throw new Exception();
            }
        }

        public override double ComputingArea()
        {
            for (int i = 0; i<floors.Count; i++)
            {
                totalAarea += floors[i].FloorArea();
            }
            return totalAarea; 
        }

        public override int GetNumberOfFloors()
        {
            return floors.Count;
        }

        public override int GetTotalNumberOfRooms()
        {
            for (int i = 0; i < floors.Count; i++)
            {
                List<Room> rooms = floors[i].GetRooms();
                totalRooms += rooms.Count;
            }
            return totalRooms;    
        }

        public override double TotalCapacity()
        {
            for (int i = 0; i < floors.Count; i++)
            {
                totalCpacity += floors[i].FloorCapacity();
            }
            if (MAX_CAPACITY < totalCpacity)
            {
                throw new BuildingException("Total Capacity is greater than 300 ");
            }
            return totalCpacity;

        }

        public static void BuildingInfo(Building b)
        {
            Console.WriteLine("The area of the building is {0}, and has {1} floors, with {2} rooms," +
                " and a total capacity of {3}",b.ComputingArea(), b.GetNumberOfFloors(), b.GetTotalNumberOfRooms(), b.TotalCapacity());
        }

        
    }
}
