using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.First.Try
{
    class Program
    {
        class MyStack
        {
            private const int BufferSize = 10;
            private object[] _data = new object[BufferSize];
            private int _top = -1;

            public void Push(object o)
            {
                if (_top == _data.Length - 1)
                {
                    var temp = _data;
                    int newSize = _data.Length + BufferSize;
                    _data = new object[newSize];
                    Array.Copy(temp, _data, temp.Length);
                }
                _data[++_top] = o;
            }

            public object Peek()
            {
                return _data[_top];
            }

            public object Pop()
            {
                if (_top == -1) return null;
                return _data[_top--];
            }

            public void Traverse()
            {
                for (int i = 0; i <= _top; i++)
                {
                    Console.Write(_data[i] + "-");
                }
            }
        }

        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push("giang");
            stack.Push(1994);
            stack.Push("thao");
            stack.Push(1992);

            stack.Traverse();

            Console.WriteLine();

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop() == null);

            stack.Traverse();

            MyStack newStack = new MyStack();
            for (int i = 0; i < 20; i++)
            {
                newStack.Push(i);
            }

            newStack.Traverse();

            Console.WriteLine();

            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Pop());
            newStack.Traverse();

            Console.ReadKey();
        }
    }
}
