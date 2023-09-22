using DesignPatterns.Behavioral.Iterator.Interface;

namespace DesignPatterns.Behavioral.Iterator.Entities
{
    public class BreadthTreeIterator<T> : IIterator
    {
        private TreeNode<T> _root;
        private List<TreeNode<T>> _list;

        public BreadthTreeIterator (TreeNode<T> root)
        {
            _root = root;
            _list = new List<TreeNode<T>>();

            InitializeList(_root);
        }

        private void InitializeList(TreeNode<T> root)
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode<T> node = queue.Dequeue();
                _list.Add(node); 

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        public bool HasNext()
        {
            return _list.Count > 0;
        }

        public object GetNext()
        {
            if (HasNext())
            {
                var first = _list[0].Value;
                _list.RemoveAt(0);

                return first;
            }

            throw new InvalidOperationException("No more elements to iterate.");
        }
    }
}
