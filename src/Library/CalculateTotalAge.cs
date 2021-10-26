namespace Library
{
    public class CalculateTotalAge : PersonVisitor
    {
        public override void Visit(Person person)
        {
            sumatoriaEdades += person.Age; 
        }
    }
}