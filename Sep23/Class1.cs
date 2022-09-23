using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep23
{
    public class product
    {
        private int product_id;
        public int ProductId
        {
            get { return product_id; }
            set { product_id = value; }
        }
        private string product_name;
        public string Product_Name
        {
            get { return product_name; }
            set
            {
                if (value.Length < 45)
                {
                    product_name = value;
                }
                else
                {
                    throw new Exception("product name is not valid");
                }
            }
        }
        public Double Unitcost
        {
            get;
            set;
        }
        public int Unitsonorders
        {
            get;
            set;
        }

    }
}
