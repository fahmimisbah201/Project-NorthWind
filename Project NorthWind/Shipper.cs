        //Name - Fahmi Awol
        //Date - 09/03

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NorthWind
{
    public class Shipper
    {
        //class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        public int ShipperId
        {
            get { return shipperId; }
            set
            {
                //The value must be greather than -1
                //if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = -1;
                }
            }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        public Shipper() : this(-1, "n/a", "n/a")
        {
            //Empty constructor
        }
        public Shipper(int aShipperId) : this(aShipperId, "n/a", "n/a")
        {
            //Partial constructor 
        }

        //Full constructor
        public Shipper(int aShipperId, string aCompanyName, string aPhone)
        {
            this.ShipperId = aShipperId;
            this.CompanyName = aCompanyName;
            this.Phone = aPhone;
        }

        //Creating a Tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "shipperID: " + this.shipperID + "\n";
            message = message + "companyName: " + this.companyName + "\n";
            message = message + "phone: " + this.phone + "\n";
            return message;
        }
    }
}


