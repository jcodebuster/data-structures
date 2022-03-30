using System.Collections;

namespace StackCollection;

public class Stack<T> : IEnumerable<T>
{
    private T[] _array;

    public int Count { get; private set; }

    private int _top;

    private Stack()
    {
        _array = new T[4];
    }

    public Stack(int initialCapacity) : this()
    {
        _array = new T[initialCapacity];
        _top = 0;
        Count = 0;
    }

    public Stack(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Push(item);
        }
    }

    public void Push(T element)
    {
        if (Count == _array.Length)
        {
            var newArr = new T[_array.Length * 2];
            Array.Copy(_array, newArr, _array.Length);
            _array = newArr;
        }
        _array[_top++] = element;
        Count++;
    }

    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return _array[--_top];
    }

    public T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        var value = _array[--_top];
        _array[_top] = default;
        return value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = _top; i >= 0; i--)
        {
            yield return _array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
