using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MyEntity
    {
        private int customerID;
        private string street, town, county, postcode, email,  telNo;

        public MyEntity()
        {
            this.street = ""; this.town = ""; this.county = ""; this.postcode = ""; this.email = ""; this.telNo = ""; 
        }

        public MyEntity(int customerID, string street, string town, string county, string postcode, string email, string telNo)
        {
            CustomerID = customerID;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.email = email;
            this.telNo = telNo;
        }

        public MyEntity(int customerID, string title, string surname, string forename, string street, string town, string county, string postcode, string email, string telNo)
        {
            this.street = street; this.town = town; this.county = county; this.postcode = postcode; this.telNo = telNo;
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }
        }


        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }
        }


        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-20 Letters");
            }
        }


        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Postcode must be 7-8 letters and alphanumeric only");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (MyValidation.validEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new MyException("Invalid email address");
                }
            }
        }


        public string TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }
        }


    }
}
