using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, new Person("Alfredo", 48));
            Node n2 = new Node(2, new Person("Tomás", 49));
            Node n3 = new Node(3, new Person("Alexander", 34));
            Node n4 = new Node(4, new Person("Alfredo", 20));
            Node n5 = new Node(5, new Person("Alexis", 48));
            Node n6 = new Node(6, new Person("Luciana", 85));
            Node n7 = new Node(7, new Person("Laura", 100));
            Node n8 = new Node(8, new Person("Victoria", 20));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
        }
    }
}
