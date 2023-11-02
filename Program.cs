using System;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            string sum = null;
            text = Console.ReadLine();
            for (int i = text.Length -1; i >= 0; i--)
            {
                sum += text[i];
            }
            Console.WriteLine(sum);
        }
    }
}
