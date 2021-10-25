using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            */

            Person person1 = new Person("Alfredo", 48);
            Person person2 = new Person("Tomás", 49);
            Person person3 = new Person("Alexander", 34);
            Person person4 = new Person("Alfredo", 20);
            Person person5 = new Person("Alexis", 48);
            Person person6 = new Person("Luciana", 85);
            Person person7 = new Person("Laura", 100);
            Person person8 = new Person("Victoria", 20);

            person1.AddChildren(person2);
            person1.AddChildren(person3);

            person2.AddChildren(person4);
            person2.AddChildren(person5);

            person3.AddChildren(person6);
            person3.AddChildren(person7);
            person3.AddChildren(person8);
        }
    }
}
