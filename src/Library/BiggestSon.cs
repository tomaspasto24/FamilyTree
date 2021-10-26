namespace Library
{
    public class BiggestSon : NodeVisitor
    {
        public override void Visit(Node node)
        {
            if(node.countChildren == 0)
            {
                if(node.GetAge >= bigAge)
                {
                    bigAge = node.GetAge;
                    bigSon = node.Person;
                }
            }
        }
    }
}