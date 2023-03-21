using System;

namespace ArrayMinMaxExtension
{
    public static class IntArrayExtensions
    {
        public static (int min, int max) FindMinMax(this int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Масив не може бути порожнім або null.");
            }

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return (min, max);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 12, 6, 9 };
            var (min, max) = numbers.FindMinMax();

            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");
        }
    }
}
