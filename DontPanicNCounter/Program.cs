using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string DontPanic = "Don't Panic".ToLower();
            int counter = 0;
            for (int i = 0; i < DontPanic.Length; i++)
            {
                if (DontPanic[i] == 'n')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
