using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateTimeFormat = "dd/MM/yyyy HH:mm:ss";
            Console.WriteLine("Hello World! It's {0}", DateTime.Now.ToString(dateTimeFormat));
        }
    }
}
