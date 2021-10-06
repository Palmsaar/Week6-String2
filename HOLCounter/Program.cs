using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World!".ToLower();
            int counterH = 0;
            int counterO = 0;
            int counterL = 0;
            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    counterH++;
                }
                else if (HelloWorld[i] == 'o')
                {
                    counterO++;
                }
                else if (HelloWorld[i] == 'l')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"H = {counterH}, O = {counterO}, L = {counterL}");
        }
    }
}
