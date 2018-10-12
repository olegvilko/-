using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика__Проценты_
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            string[] arrInput = userInput.Split(' ');
            double rub = double.Parse(arrInput[0], System.Globalization.CultureInfo.InvariantCulture);
            double percent = double.Parse(arrInput[1], System.Globalization.CultureInfo.InvariantCulture);
            int month = Int32.Parse(arrInput[2]);
            double userOutput=rub;
            for (int i = 0; i < month; i++)
            {
                userOutput += userOutput / 100 * percent/12;
            }
            return userOutput;
        }

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            //Console.WriteLine(arrInput[2]);
            Console.WriteLine(Calculate(userInput));
        }
    }
}
