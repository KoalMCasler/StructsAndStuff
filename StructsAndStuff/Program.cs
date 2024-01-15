using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structs!");
            Console.WriteLine("Variables Full of Variables!");
            // Pre Structs - no structs, no classes
            int Hp = 100;
            int Xpos = 10;
            int Ypos = 10;

            // Structs
            
            // Pre Classes

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey(true);
        }
        struct Vector3
        {
            float x;
            float y;
            float z;
            
        }
    }
}
