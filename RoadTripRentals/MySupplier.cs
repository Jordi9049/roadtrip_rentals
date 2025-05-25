using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripRentals
{
    class MySupplier : MyEntity
    {
        private int supplierNo;
        private string supplierName, supplierEmail, supplierTelNo;

        public MySupplier()
        {
            this.supplierName = ""; this.supplierEmail = ""; this.supplierTelNo = "";
        }

        public MySupplier(int supplierNo, string supplierName, string supplierEmail, string supplierTelNo)        
        {
            this.supplierName = supplierName; this.supplierEmail = supplierEmail; this.supplierTelNo = supplierTelNo;
        }

        public int SupplierNo 
        {
            get { return supplierNo; }
            set { supplierNo = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set
            {
                if (MyValidation.validLength(value, 3, 50) && MyValidation.validLetterNumberWhitespace(value))
                {
                    supplierName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Supplier name must be 3-50 characters");
            }
        }

        public string SupplierEmail
        {
            get { return supplierEmail; }
            set
            {
                if (MyValidation.validLength(value, 8, 50) && MyValidation.validEmail(value))
                {
                    supplierEmail = value;
                }
                else
                    throw new MyException("Email address is invalid");
            }
        }

        public string SupplierTelNo
        {
            get { return supplierTelNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    supplierTelNo = value;
                }
                else
                    throw new MyException("Telephone number must be 11-15 digits");
            }
        }

    }

    
}
