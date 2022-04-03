using StackCollection;
namespace TestingConsole;

public class App
{
    public void Start()
    {
        var array = new[] {1, 2, 3, 5};
        var stack = new StackCollection.Stack<int>(10);
        
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        var a = stack.Pop();
        stack.Push(6);
        stack.Push(7);
        var b = stack.Peek();
    }
}
