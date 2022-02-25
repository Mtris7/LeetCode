using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public bool IsSatisfied(Product t)
        {
            return t.size == size;
        }
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
    }
}
