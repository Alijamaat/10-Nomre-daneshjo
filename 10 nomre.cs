using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomarat_daneshjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[10];
            double[] coefficients = new double[10];

            // علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی  پیشرفته1
            for (int i = 0; i < 10; i++)
            {
                Console.Write("nomre {0}: ", i + 1);
                grades[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("zarib {0}: ", i + 1);
                coefficients[i] = Convert.ToDouble(Console.ReadLine());
            }

            
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += grades[i] * coefficients[i];
            }

            double totalCoefficient = 0;
            for (int i = 0; i < 10; i++)
            {
                totalCoefficient += coefficients[i];
            }

            double average = sum / totalCoefficient;

            Console.WriteLine("miangin=: " + average);
        }
    }
}
