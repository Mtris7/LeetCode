using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildOf(string name);
    }
}
