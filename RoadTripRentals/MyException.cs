using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MyException : Exception
    {
        private string message;

        public MyException(string message)
        {
            this.message = message;
        }
        public String validate()
        {
            return String.Format("Error: {0} ", message);
        }
    }
}
