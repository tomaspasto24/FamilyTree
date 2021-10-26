using System;
using System.Text;

namespace Library
{
    public abstract class PersonVisitor
    {
        public static int sumatoriaEdades {get; protected set;}
        public static string LongerName = "";
        public abstract void Visit(Person person);
    }
}