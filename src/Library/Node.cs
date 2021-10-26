using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        private Person person;
        private List<Node> children = new List<Node>();
        public int countChildren = 0;

        public Person Person
        {
            get
            {
                return this.person;
            }
        }
        public List<Node> Children
        {
            get
            {
                return this.children;
            }
        }
        public int Number {
            get
            {
                return this.number;
            }
        }
        public int GetAge
        {
            get{
                return this.person.Age;
            }
        }

        public Node(int number, Person person)
        {
            this.person = person;
            this.number = number;
        }


        public void AddChildren(Node n)
        {
            this.children.Add(n);
            countChildren++;
        }

        public void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
