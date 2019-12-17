using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {


        static void Main(String[] args)
        {
            Hashtable name = new Hashtable();

            name.Add("61030001", "krungthai");
            name.Add("61030017", "napakorn");
            name.Add("61030007", "komkrit");
            name.Add("61030057", "sakulrat");
            name.Add("61030009", "Janejira");
            name.Add("61030040", "peerapon");
            name.Add("61030045", "maethapon");
            name.Add("61030021", "natthapat");

            foreach (DictionaryEntry pp in name)
            {
                Console.WriteLine(pp.Key + "=" + pp.Value);
            }
            Console.WriteLine("*******ID Student Computer Class*********");
            Console.Write("Press key ID=");
            Console.WriteLine("" + name.ContainsKey(Console.ReadLine()));




        }
    }
}
