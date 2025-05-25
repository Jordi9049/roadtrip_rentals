using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    public class MyModel
    {
        private string modelID;
        private string make;
        private string description;

        public string ModelID
        {
            get { return modelID; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Model ID must not be empty.");
                if (value.Length > 10)
                    throw new Exception("Model ID must be less than or equal to 10 characters.");
                modelID = value;
            }
        }

        public string Make
        {
            get { return make; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Make must not be empty.");
                if (value.Length > 20)
                    throw new Exception("Make must be less than or equal to 20 characters.");
                make = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Description must not be empty.");
                if (value.Length > 20)
                    throw new Exception("Description must be less than or equal to 20 characters.");
                description = value;
            }
        }
    }


}
