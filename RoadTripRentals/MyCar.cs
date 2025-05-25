using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MyCar : MyEntity
    {
        private string carReg, modelID, colour, fuelType;
        private int mileage, noSeats, year, rentalCostID;

        public MyCar() : base()
        {
            this.carReg = ""; this.modelID = ""; this.colour = ""; this.mileage = 0; this.fuelType = ""; this.noSeats = 0; this.year = 0; this.rentalCostID = 0;
        }

        public MyCar(string carReg, string modelID, string colour, int mileage, string fuelType, int noSeats, int year, int rentalCostID) : base()
        {
            CarReg = carReg;
            ModelID = modelID;
            Colour = colour;
            Mileage = mileage;
            FuelType = fuelType;
            NoSeats = noSeats;
            Year = year;
            RentalCostID = rentalCostID;
        }

        public string CarReg
        {
            get { return carReg; }
            set
            {
                if (value.Length >= 6 && value.Length <= 10)
                    carReg = value.ToUpper();
                else
                    throw new MyException("Car registration must be between 6 and 10 characters");
            }
        }

        public string ModelID
        {
            get { return modelID; }
            set
            {
                if (MyValidation.validLength(value, 1, 10))
                    modelID = value;
                else
                    throw new MyException("Model ID must be 1-10 characters");
            }
        }

        public string Colour
        {
            get { return colour; }
            set
            {
                if (MyValidation.validLength(value, 1, 20))
                    colour = value;
                else
                    throw new MyException("Colour must be 1-20 characters");
            }
        }

        public int Mileage
        {
            get { return mileage; }
            set
            {
                if (value >= 0)
                    mileage = value;
                else
                    throw new MyException("Mileage must be a positive value");
            }
        }

        public string FuelType
        {
            get { return fuelType; }
            set
            {
                if (MyValidation.validFuelType(value))
                    fuelType = value;
                else
                    throw new MyException("Fuel type must be Petrol, Diesel, Electric, or Hybrid");
            }
        }

        public int NoSeats
        {
            get { return noSeats; }
            set
            {
                if (value >= 1)
                    noSeats = value;
                else
                    throw new MyException("Number of seats must be a positive value");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (MyValidation.validYear(value))
                    year = value;
                else
                    throw new MyException("Year must be a valid value");
            }
        }

        public int RentalCostID
        {
            get { return rentalCostID; }
            set
            {
                if (value > 0)
                    rentalCostID = value;
                else
                    throw new MyException("Rental Cost ID must be a positive value");
            }
        }
    }
}
