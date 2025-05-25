using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MyCustomer : MyEntity
    {
        private string title, surname, forename;


        public MyCustomer() : base()
        {
            this.title = ""; this.surname = ""; this.forename = "";
        }


        public MyCustomer(int customerID, string title, string surname, string forename, string street, string town, string county, string postcode, string email, string telNo) : base(customerID, street, town, county, postcode, email, telNo)
        {
            this.title = title; this.surname = surname; this.forename = forename;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.ToUpper() != "MR" && value.ToUpper() != "MRS" && value.ToUpper() != "MISS" && value.ToUpper() != "MS")
                    throw new MyException("Title must be Mr, Mrs, Miss, Ms.");
                else
                    title = MyValidation.firstLetterEachWordToUpper(value);
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 letters");
            }
        }


        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");
            }
        }
    }
}
