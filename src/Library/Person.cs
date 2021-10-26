namespace Library
{
    public class Person 
    {
        private string name;
        private int age;
        private static PersonVisitor totalAge = new CalculateTotalAge();
        private static PersonVisitor longerName = new LongerName();

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.Accept(totalAge);
            this.Accept(longerName);
        }

        public void Accept(PersonVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}