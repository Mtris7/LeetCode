using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public enum Relationship
    {
        parent, child, sibling
    }
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();
        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.parent, child));
            relations.Add((child, Relationship.child, parent) );

        }

        public IEnumerable<Person> FindAllChildOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.parent).Select(x => x.Item3);
        }
    }
}
