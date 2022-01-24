using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// Open - Closed Principle
    /// </summary>

    //
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large
    }
    public class Product
    {
        public string name;
        public Color color;
        public Size size;
        public Product(string name, Color color, Size size)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            this.name = name;
            this.color = color;
            this.size = size;
        }
    }
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach(var p in products)
            {
                if (p.size == size)
                    yield return p;
            }
        }
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach(var p in products)
            {
                if (p.color == color)
                    yield return p;
            }
        }
    }
}
