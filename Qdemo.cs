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

            


            foreach(int ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("**********");
            foreach(int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
        
        

        
            
    }
}
