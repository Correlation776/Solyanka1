using System;
using System.Text;

namespace Solyanka1
{
    //Сгенерировать последовательность Морса-Туэ до N-го знака.
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Which digit should the sequence start with(0 or 1)?");
            if (!int.TryParse(Console.ReadLine(), out int f))
            {
                Console.WriteLine("Incorrect Data");
                return;
            }
            Console.WriteLine("How long is the sequence to be generated?");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Incorrect Data");
                return;
            }
            Console.WriteLine(SequenceGenerator(f, n));
        }

        public static string SequenceGenerator(int firstDigit, int sequenceLength)
        {
            if (firstDigit > 1 || firstDigit < 0)
            {
                Console.WriteLine("Incorrect number on the first spot");
                return null;
            }
            
            if (sequenceLength < 0)
            {
                Console.WriteLine("Length can't be negative");
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