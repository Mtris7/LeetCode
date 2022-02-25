using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
