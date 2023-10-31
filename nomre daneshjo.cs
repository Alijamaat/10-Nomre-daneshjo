using System;
class Program
{
    static void Main(string[] args)
    {
       //علی پیر محمد جماعت  و حمیدرضا واحدی و مهدی نوروزی  پیشرفته 1   شمسی پور
		int[] nomre = new int[10];
        double[] zarib = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("نمره {0}: ", i + 1);
            nomre[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("ضریب {0}: ", i + 1);
            zarib[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += nomre[i] * zarib[i];
        }

        double totalZarib = 0;
        for (int i = 0; i < 10; i++)
        {
            totalZarib += zarib[i];
        }

        double average = sum / totalZarib;

        Console.WriteLine("میانگین: " + average);
    }
}