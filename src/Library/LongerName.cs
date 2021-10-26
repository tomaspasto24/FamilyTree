namespace Library
{
    public class LongerName : PersonVisitor
    {
        public override void Visit(Person person)
        {
            if(person.Name.Length > LongerName.Length || LongerName == string.Empty)
            {
                LongerName = person.Name;
            }
        }
    }
}