using System;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //Console.WriteLine("Hello world!"+ name);

            foreach (var item in args)
            {
                Console.WriteLine("Hello "+item+"!");
            }
        }
    }
}
