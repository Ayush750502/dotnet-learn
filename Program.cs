using System;

namespace HelloWorld {
    class Program {
        static void Main(){
            String str = "Hello";
            for (int i = 0; i < str.Length+1; i++)
            {
                Console.WriteLine(str.Substring(0 , i));
            }
        }
    }
}