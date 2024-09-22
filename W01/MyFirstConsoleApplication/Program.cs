using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Zack";
            string location = "Rexburg";
            DateTime today = DateTime.Now;
            DateTime xmas = new DateTime(today.Year, 12, 25);
            if (today > xmas)
            {
                xmas = xmas.AddYears(1);
            }
            int daysToXmas = (xmas - today).Days;
            string todayProcessed = today.ToString("MM/dd/yyyy");


            Console.WriteLine($"Hello, my name is {name} from {location}");
            Console.WriteLine($"Current Date: {todayProcessed}");
            Console.WriteLine($"Days to Christmas: {daysToXmas}");

            /*======================= Yellow Book Example =======================*/

            Console.WriteLine();
            Console.WriteLine("===== Yellow Book Example =====");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
