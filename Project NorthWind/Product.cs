        //Name - Fahmi Awol
        //Date - 09/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_NorthWind
{
    public class Product
    {
        //class variables and default values
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int catagoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = 0.0;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = -1;
        private bool discontinued = true;
    
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = -1;
                }
            }
        }
        public string ProductName 
        { 
            get { return this.productName; } 
            set { this.productName = value; } 
        }
        public int SupplierId 
        {
            get { return this.supplierId; } 
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = -1;
                }
            }
        }
        public int CatagoryId 
        {
            get { return this.catagoryId; } 
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.catagoryId = value;
                }
                else
                {
                    this.catagoryId = -1;
                }
            }
        }
        public string QuantityPerUnit
        { 
            get { return this.quantityPerUnit; } 
            set { this.quantityPerUnit = value; }
        }
        public double UnitPrice 
        {
            get { return this.unitPrice; } 
            set
            {
                // the value must be greather than 0
                // if the value is less than 0 it will automatically set to 0.0
                if (value > 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0.0;
                }
            }
        }
        public int UnitsInStock 
        {
            get { return this.unitsInStock; } 
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = -1;
                }
            }
        }
        public int UnitsOnOrder 
        {
            get { return this.unitsOnOrder; } 
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = -1;
                }
            }
        }
        public int ReorderLevel 
        {
            get { return this.reorderLevel; } 
            set
            {
                // the value must be greather than -1
                // if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = -1;
                }
            }
        }
        public bool Discontinued
        {
            get { return this.discontinued; } 
            set { this.discontinued = true; } 
        }
        public Product() : this(-1, "n/a", -1, -1, "n/a", 0.0, -1, -1, -1, true)
        {
            //Empty constructor
        }
        public Product(int aProductId, string aProductName, int aSupplierId) : this(aProductId, aProductName, aSupplierId, -1, "n/a", 0.0, -1, -1, -1, true)
        {
            //Partial constructor
        }
        //Full constructor
        public Product(int aProductId, string aProductName, int aSupplierId, int aCatagoryId, string aQuantityPerUnit, double aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel, bool aDiscontinued)
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CatagoryId = aCatagoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsOnOrder = aUnitsOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;

        }
        // Creating a Tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "productId: " + this.productId + "\n";
            message = message + "productName: " + this.productName + "\n";
            message = message + "supplierId: " + this.supplierId + "\n";
            message = message + "catagoryId: " + this.catagoryId + "\n";
            message = message + "quantityPerUnit: " + this.quantityPerUnit + "\n";
            message = message + "Unitprice: " + this.UnitPrice + "\n";
            message = message + "unitsInStock: " + this.unitsInStock + "\n";
            message = message + "unitsOnOrder: " + this.unitsOnOrder + "\n";
            message = message + "reorderLevel: " + this.reorderLevel + "\n";
            message = message + "discontinued: " + this.discontinued + "\n";
            return message;

        }

    }

}
