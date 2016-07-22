using System;

namespace GUIDgenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GuidFactory guidFactory = new GuidFactory();

            Console.WriteLine(guidFactory.getGuid());

            Console.WriteLine("Hit any key to exit...");

            Console.ReadLine();
        }
    }
}
