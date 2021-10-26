using System;
using System.Text;

namespace Library
{
    public abstract class NodeVisitor
    {
        public int bigAge {get; set;}
        public Person bigSon {get; set;}
        public abstract void Visit(Node node);
    }
}