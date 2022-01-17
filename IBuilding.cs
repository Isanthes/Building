using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    interface IBuilding
    {
        double ComputingArea();
        int GetNumberOfFloors();
        int GetTotalNumberOfRooms();
        double TotalCapacity();

    }
}
