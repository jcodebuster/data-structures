using System.Collections;

namespace BinaryTree;

public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private BinaryTreeNode<T>? _head;
    private int _count;

    public void Add(T value)
    {
        if (_head == null)
        {
            _head = new BinaryTreeNode<T>(value);
        }
        else
        {
            AddTo(_head, value);
        }

        _count++;
    }

    public void AddTo(BinaryTreeNode<T> node, T value)
    {
        if (value.CompareTo(node.Value) < 0)
        {
            if (node.Left == null)
            {
                node.Left = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(node.Left, value);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(node.Right, value);
            }
        }
    }
    
    


    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
