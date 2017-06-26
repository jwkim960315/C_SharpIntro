using System;
using System.Collections.Generic;

namespace OOP_2
{
    class Stack
    {
        private List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException("null object detected");
                }
                else
                {
                    _stack.Add(obj);
                    Console.WriteLine("Object has been inserted");
                    Console.ReadLine();
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            
        }

        public object Pop()
        {
            try
            {
                if (_stack.Count == 0)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                else
                {
                    var lastItem = _stack[_stack.Count-1];
                    _stack.Remove(lastItem);
                    return lastItem;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                // Console.ReadLine();
                return null;
            }
            
        }

        public void Clear()
        {
            _stack.Clear();
            Console.WriteLine("Stack has been cleared!");
        }
    }
}
