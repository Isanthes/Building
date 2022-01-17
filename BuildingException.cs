using System;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    
    class BuildingException :Exception
    {
        string exception;

        public BuildingException(string exception)
        {
            this.exception = "Buildin Exception : " + exception;
        }

        public override string ToString()
        {
            return exception  + base.ToString();
        }
    }
}
