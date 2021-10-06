using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string DontPanic = "Don't Panic".ToUpper();
            for (int i = DontPanic.Length - 1; i >= 0; i--)
            {
                Console.Write(DontPanic[i]);
            }


        }
    }
}
