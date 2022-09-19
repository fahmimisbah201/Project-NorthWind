        //Name - Fahmi Awol
        //Date - 09/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NorthWind
{
    public class Employee
    {
        //class variables and default values
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private DateTime birthDate;
        private DateTime hireDate;
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        //gets and sets
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                //The value must be greather than -1
                //if the value is less than 1 it will automatically set to -1
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = -1;
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public DateTime Hiredate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                if (value > -1)
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = -1;
                }
            }
        }

        public Employee() : this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {
            //Empty constructor
        }

        public Employee(int anEmployeeId, string aLastName, string aFirstName) : this(anEmployeeId, aLastName, aFirstName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {
            //Partial constructor
        }

        //Full constractor
        public Employee(int anEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string anExtension, string aNotes, int aReportsTo)
        {
            this.EmployeeId = anEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = anAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = anExtension;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;

        }
        //To string override
        public override string ToString()
        {
            string message = " ";
            message = message + "employeeId: " + this.employeeId + "n/a";
            message = message + "lastName: " + this.lastName + "n/a";
            message = message + "firstName: " + this.firstName + "n/a";
            message = message + "title: " + this.title + "n/a";
            message = message + "titleOfCourtesy: " + this.titleOfCourtesy + "n/a";
            message = message + "birthDate: " + this.birthDate + "n/a";
            message = message + "hireDate: " + this.hireDate + "n/a";
            message = message + "address: " + this.address + "n/a";
            message = message + "city: " + this.city + "n/a";
            message = message + "region: " + this.region + "n/a";
            message = message + "postalCode: " + this.postalCode + "n/a";
            message = message + "country: " + this.country + "n/a";
            message = message + "postalCode: " + this.postalCode + "n/a";
            message = message + "homePhone: " + this.homePhone + "n/a";
            message = message + "extension: " + this.extension + "n/a";
            message = message + "notes: " + this.notes + "n/a";
            message = message + "reportsTo: " + this.reportsTo + "n/a";
            return message;
        }

    }

}
