using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Product
    {
        public string name;
        public Color color;
        public Size size;
        public Product(string name, Color color, Size size)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            this.name = name;
            this.color = color;
            this.size = size;
        }
    }
}
