using DataStructureProgram;
using System.Collections;

namespace DataStrctureProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(2, "test");
            hashtable.Add(2.3, 23);
            hashtable.Add("Hii", "Hello");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(hashtable[2.3]);

            //Sdemo.Sdisplay();
            //ArrayList obj = new ArrayList();
            //obj.Add(1);
            //obj.Add('c');
            //obj.Add(2.2);

            foreach (var ele in obj)
            {
                Console.WriteLine(ele);

            }
            //obj.Clear();
            Console.WriteLine("-------------");
            bool val = obj.Contains(5.4);

            //obj.Remove(2.2);
            obj.Remove(1);

            //Console.WriteLine(obj.Count);
            foreach (var ele in obj)
            {
                Console.WriteLine(ele);
            }

            List<string> obj1 = new List<string>();


        }
    }

}
