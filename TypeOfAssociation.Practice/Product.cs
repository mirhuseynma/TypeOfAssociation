using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfAssociation.Practice
{
    public class Product
    {
        public string Name;
        public double Price;
        public double Count;

        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        public Product(string name,double price,double count) : this(name, price)
        {
            Count = count;
        }

        public void Detail()
        {
            Console.WriteLine($"Mehsulun adi: {Name}, mehsulun qiymeti: {Price}, mehsula endirim: {Count}");
        }

        public void Discount()
        {
            Console.WriteLine("mehsulun Endirim deyerini daxil edin");
            Count = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Mehsulun evvelki qiymeti: {Price}, endirimli qiymeti: {Price-(Price * Count/100)}");
        }



    }
}
