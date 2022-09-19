            //Name - Fahmi Awol
            //Date - 09/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NorthWind
{
     public class Category
     {
          //class variables (instances) and default values
          private int categoryId = -1;
          private string categoryName = "n/a";
          private string description = "n/a";

          //gets and sets
          public int CategoryId
          {
               get { return categoryId; }
               set
               {
                    //must be greather than -1
                    if (value > -1)
                    {
                         this.categoryId = value;
                    }
                    else
                    {
                         this.categoryId = 0;
                    }
               }
          }
          public string CategoryName
          {
                get { return categoryName; }
                set { this.categoryName = value; }

          }  
          public string Description 
          { 
                get { return description; }
                set { this.description = value; }
            
          }

        public Category() : this(-1, "n/a", "n/a")
        {
            //Empty constructor
        }
        public Category(int aCatagoryId) : this(aCatagoryId, "n/a", "n/a")
        {
            //Partial constructor
        }

        //Full constructor
        public Category(int aCatagoryId, string aCatagoryName, string aDescription)
        {
            this.categoryId = aCatagoryId;
            this.categoryName = aCatagoryName;
            this.description = aDescription;

        }
        // overrride to tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "catagory Id: " + this.categoryId + "\n";
            message = message + "catagory name: " + this.categoryName + "\n";
            message = message + "Description: " + this.description + "\n";
            return message;
        }


     }

}
