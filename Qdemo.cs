using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    public class Qdemo
    {
        public static void Qdisplay() 
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            




            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Peek - " + queue.Peek());
            queue.Dequeue();
            Console.WriteLine(" After Peek - " + queue.Peek());
            Console.WriteLine("**********");
            foreach(int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
        
        

        
            
    }
}
