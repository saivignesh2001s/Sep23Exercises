using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep23
{
   public class Class2
    {
        public List<product> ShowProducts()
        {
            List<product> p = new List<product>();
            string connstring = @"Data Source=LAPTOP-566KJ7GJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand sq = new SqlCommand("Select * from Products", conn);
            conn.Open();
            SqlDataReader sl = sq.ExecuteReader();
            while (sl.Read())
            {
                product p1 = new product();
                p1.ProductId = Convert.ToInt32(sl[0]);
                p1.Product_Name = sl[1].ToString();
                p1.Unitcost = Convert.ToDouble(sl[5]);
                p1.Unitsonorders = Convert.ToInt32(sl[6]);
                p.Add(p1);
            }
            return p;
        }
    }
}
