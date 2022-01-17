using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Kitchen : Room
    {
        int window;
        public Kitchen(double roomArea, string accessories, double capacity, int window) : base(roomArea, accessories, capacity)
        {
            this.window = window;
        }

       

    }
}
