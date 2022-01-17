using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class WorkingSpace : Room
    {
        public WorkingSpace(double roomArea, string accessories, double capacity) : base(roomArea, accessories, capacity)
        {
        }
        public double GetArea(double roomArea)
        {
            return roomArea;
        }
        public string GetRoomType(string roomType)
        {
            return roomType;
        }
        public string GetAccessories(string accesories)
        {
            return accesories;
        }
        public double GetCapacity(double capacity)
        {
            return capacity;
        }
    }
}
