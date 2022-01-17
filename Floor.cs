using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Floor 
    {

        double totalArea = 0;
        double totalCapacity = 0;
        List<Room> rooms = new List<Room>();

        public Floor(List<Room> rooms)
        {
            if (rooms.Count >= 5)
            {
                for( int i = 0; i<rooms.Count; i++)
                {
                    this.rooms.Add(rooms[i]);
                }
            }
            else
            {
                Console.WriteLine("At least 5 rooms per floor are required");
                throw new Exception();
            }
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

        public double FloorArea()
        {   
            for (int i =0; i<rooms.Count; i++)
            {
                totalArea += rooms[i].GetArea();
            }
            return totalArea;
        }

        public double FloorCapacity()
        {
            for(int i =0; i<rooms.Count; i++)
            {
                totalCapacity += rooms[i].GetCapacity();
            }
            return totalCapacity;
        }


   

        
        

    }
}
