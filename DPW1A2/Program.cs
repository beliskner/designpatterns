using System;

namespace DPW1A2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            IPencil pencil = new Pencil(50);
            IPencilSharpener pencilSharpener = new PencilSharpener();

            while (message != "stop")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a word: ");
                message = Console.ReadLine();
                if (message == "sharpen")
                {
                    pencilSharpener.Sharpen(pencil);
                } else if (message == "stop")
                {
                    Console.WriteLine("end of program...");
                } else
                {
                    pencil.Write(message);
                }
            }
        }
    }
}
