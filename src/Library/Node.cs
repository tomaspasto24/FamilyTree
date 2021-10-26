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

        public int Number {
            get
            {
                return this.number;
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
        }
        
    }
}
