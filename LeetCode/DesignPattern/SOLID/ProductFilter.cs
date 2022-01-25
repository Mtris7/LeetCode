using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DesignPattern.SOLID
{
    //Normal
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.size == size)
                    yield return p;
            }
        }
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.color == color)
                    yield return p;
            }
        }
        public static IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var p in products)
            {
                if (p.color == color && p.size == size)
                    yield return p;
            }
        }
    }
}
