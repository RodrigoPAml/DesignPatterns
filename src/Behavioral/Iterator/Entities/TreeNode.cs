namespace DesignPatterns.Behavioral.Iterator.Entities
{
    public class TreeNode<T>
    {
        public T Value { get; }

        public TreeNode<T>? Left { get; set; }

        public TreeNode<T>? Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
