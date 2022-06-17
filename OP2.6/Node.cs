namespace OPlab2._6
{
internal class Node
    {
        public Node(char value)
        {
            Value = value;
            Left = Right = null;
        }

        public char Value { get; private set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public override string ToString()
        {
            return $"[{Value}]";
        }
    }
}