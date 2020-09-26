using System;


namespace SampleApp
{
    class Ex02
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int[] array = new int[20];
            Console.WriteLine("enter the size of array");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < a; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                }
                else
                {
                    sum2 = sum2 + array[i];
                }

            }
            Console.WriteLine("even sum" + sum);
            Console.WriteLine("odd sum" + sum2);

        }
    }
}