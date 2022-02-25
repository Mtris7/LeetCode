using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public bool IsSatisfied(Product t)
        {
            return t.color == color;
        }
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
    }
}
