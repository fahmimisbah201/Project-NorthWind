    //Name - Fahmi Awol
    //Date - 09/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_NorthWind
{
    public class OrderDetail
    {
        //Class variables and default values
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = 0.0;
        private int quantity = 0;
        private double discount = 0.0;

        //getting and setting
        public int OrderId
        {
            get { return orderId; }
            set
            {
                //The value must be greather than -1
                //If the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    orderId = value;
                }
                else
                {
                    orderId = -1;
                }
            }
        }
        public int ProductId
        {
            get { return productId; }
            set
            {
                //The value must be greather than -1
                //if the value is less than -1 it will automatically set to -1
                if (value > -1)
                {
                    orderId = value;
                }
                else
                {
                    orderId = -1;
                }
            }
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
                    unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0.0;
                }
            }

        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                // the value must be greather than 0
                // if the value is less than 0 it will automatically set to 0
                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }
            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                // the value must be greather than 0
                // if the value is less than 0 it will automatically set to 0
                if (value > 0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = 0.0;
                }

            }

        }
        public OrderDetail() : this(-1, -1, 0.0, 0, 0.0)
        {
            //Empty constructor
        }

        public OrderDetail(int aOrderId, int aProductId) : this(aOrderId, aProductId, 0.0, 0, 0.0)
        {
            //Partial constructor
        }

        //Full constructor
        public OrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {
            this.OrderId = aOrderId;
            this.ProductId = aProductId;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;

        }
        //Overriding to string
        public override string ToString()
        {
            string message = " ";
            message = message + " orderId: " + this.orderId + "\n";
            message = message + " productId: " + this.productId + "\n";
            message = message + " unitPrice: " + this.unitPrice + "\n";
            message = message + " quantity: " + this.quantity + "\n";
            message = message + " discount: " + this.discount + "\n";
            return message;
        }

    }

}
