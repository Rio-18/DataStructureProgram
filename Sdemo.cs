using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    public class Sdemo
    {
        public static void Sdisplay()
 
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(30);
            stack.Push(60);
            stack.Push(90);
            stack.Push(120);
            stack.Push(150);
            foreach(int ele in stack)
            {
                Console.WriteLine(ele);
            }

            stack.Pop();

            foreach(int ele in stack)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Peek - "+stack.Peek();
            Console.WriteLine("*******************");
            foreach(int ele in stack)
            {
                Console.WriteLine(ele);
            }
        }


    }
}
