using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    abstract class AbstractBuilding : IBuilding
    {
        public abstract double ComputingArea();
        public abstract int GetNumberOfFloors();
        public abstract int GetTotalNumberOfRooms();
        public abstract double TotalCapacity();
    }
}
