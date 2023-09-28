using System;
using System.Text;

namespace Solyanka1
{
    //Сгенерировать последовательность Морса-Туэ до N-го знака.
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Which digit should the sequence start with(0 or 1)?");
            int.TryParse(Console.ReadLine(), out int f);
            Console.WriteLine("How long is the sequence to be generated?");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine(SequenceGenerator(f, n));
        }

        static string SequenceGenerator(int firstDigit, int sequenceLength)
        {
            if (firstDigit > 1)
            {
                Console.WriteLine("Incorrect number on the first spot");
                return null;
            }

            StringBuilder result = new StringBuilder(firstDigit.ToString());
            for (int i = 0; i < (int)Math.Ceiling(Math.Log(sequenceLength, 2)); i++)
            {
                int currentLength = result.Length;
                for (int j = 0; j < currentLength; j++)
                {
                    if (result[j].Equals('0'))
                    {
                        result.Append('1');
                    }
                    else
                    {
                        result.Append('0');
                    }
                }
            }

            return result.ToString(0, sequenceLength);
        }
    }
}