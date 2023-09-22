using DesignPatterns.Behavioral.Iterator.Interface;

namespace DesignPatterns.Behavioral.Iterator.Entities
{
    public class DepthTreeIterator<T> : IIterator
    {
        private TreeNode<T> _root;
        private List<TreeNode<T>> _list;

        public DepthTreeIterator(TreeNode<T> root)
        {
            _root = root;
            _list = new List<TreeNode<T>>();

            InitializeList(_root);
        }

        private void InitializeList(TreeNode<T> node)
        {
            if (node != null)
            {
                _list.Add(node);
                InitializeList(node.Left);
                InitializeList(node.Right);
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
