using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
     class Room
    {
        public double roomArea;
        public string accessories;
        public double capacity;

        public Room(double roomArea, string accessories, double capacity)
        {
            this.roomArea = roomArea;
            this.accessories = accessories;
            this.capacity = capacity;
        }

        public double GetArea()
        {
            return roomArea;
        } 
        public string GetAccessories()
        {
            return accessories;
        }
        public double GetCapacity()
        {
            return capacity;
        }

        
    }
}
