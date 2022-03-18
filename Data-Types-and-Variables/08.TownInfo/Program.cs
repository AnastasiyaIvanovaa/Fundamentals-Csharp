using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            Console.WriteLine("The code of {0} is: {1}", ch, (int) ch);
            ch = 'b';
            Console.WriteLine("The code of {0} is: {1}", ch, (int)ch);
            ch = 'A';
            Console.WriteLine("The code of {0} is: {1}", ch, (int)ch);
            ch = 'Щ';
            Console.WriteLine("The code of {0} is: {1}", ch, (int)ch);
            string file = "C:\Windows\\win.ini";
            Console.WriteLine(file);
            string fileone = @"C:\\Windows\\win.ini";
            Console.WriteLine(fileone);
            string os = "Windows";
            string fileName = "win.ini";
            string path = $@"C:\{os}\{fileName}";
            string path1 = $@"C:\{os}\{fileName}";

            Console.WriteLine(path);
        }
    }
}
