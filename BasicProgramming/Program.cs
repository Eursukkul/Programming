using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            //Input

            Console.Write("Input Weight(kg): ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Input Height(cm): ");
            double.TryParse(Console.ReadLine(), out height);

            //Process
            //BMI = weight/height^2

            height /= 100;
            double bmi = weight / Math.Pow(height, 2);

            //Output

            Console.WriteLine("BMI = {0:F2}", bmi);
            Console.ReadKey();
        }
    }
}
