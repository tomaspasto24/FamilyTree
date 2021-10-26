using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Alfredo", 48);
            Person persona2 = new Person("Tomás", 49);
            Person persona3 = new Person("Alexander", 34);
            Person persona4 = new Person("Alfredo", 20);
            Person persona5 = new Person("Alexis", 50);
            Person persona6 = new Person("Luciana", 85);
            Person persona7 = new Person("Laura", 100);
            Person persona8 = new Person("Victoria", 20);

            Node n1 = new Node(1, persona1);
            Node n2 = new Node(2, persona2);
            Node n3 = new Node(3, persona3);
            Node n4 = new Node(4, persona4);
            Node n5 = new Node(5, persona5);
            Node n6 = new Node(6, persona6);
            Node n7 = new Node(7, persona7);
            Node n8 = new Node(8, persona8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);
            // visitar el árbol aquí
            Console.WriteLine($"Sumatoria final de edades: {PersonVisitor.sumatoriaEdades}");

            //Parte 4
            NodeVisitor visitor = new BiggestSon();
            n1.Accept(visitor);
            n2.Accept(visitor);
            n3.Accept(visitor);
            n4.Accept(visitor);
            n5.Accept(visitor);
            n6.Accept(visitor);
            n7.Accept(visitor);
            n8.Accept(visitor);
            Console.WriteLine($"Hijo mayor: {visitor.bigSon.Name}");   
            Console.WriteLine($"Persona con nombre más largo: {PersonVisitor.LongerName}");
        }
    }
}
