using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sep23;
namespace Sep23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> po = new List<product>();
            Class2 cq = new Class2();
            po = cq.ShowProducts();
            foreach (var item in po)
            {
                Console.Write($"{item.ProductId},{item.Product_Name},{item.Unitcost},{item.Unitsonorders}\n");
            }
            Console.Read();
        }
    }
}
