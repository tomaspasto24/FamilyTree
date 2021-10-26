using System;
using System.Text;

namespace Library
{
    public abstract class Visitor
    {
        public int sumatoriaEdades = 0;

        public abstract void Visit(Person person);

        //public abstract void Visit(Node node);

    }

    public class CalculateTotalAge : Visitor
    {
        public override void Visit(Person person)
        {
            sumatoriaEdades += person.Age;
        }
    }
}