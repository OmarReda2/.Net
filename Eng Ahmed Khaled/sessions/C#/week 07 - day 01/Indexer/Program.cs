using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook note = new PhoneBook(3);

            note.AddNumber("Ahmed", 123, 0);
            note.AddNumber("Aya", 456, 1);
            note.AddNumber("Kamal", 789, 2);
            Console.WriteLine(note.GetNumber("Ahmed"));


            note.AddNumber("Ahmed", 1111, 2);
            Console.WriteLine(note.GetNumber("Ahmed"));




            note["Ahmed"] = 1010;
            Console.WriteLine(note.GetNumber("Ahmed"));


            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }


        }
    }
}
