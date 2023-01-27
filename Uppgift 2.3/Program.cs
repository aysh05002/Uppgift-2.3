using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många dagar vill du hyra bilen ? = ");
            int dagar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hur många kilometer vill du köra ? = ");
            double kilometer = Convert.ToDouble(Console.ReadLine());
            double summa = (dagar - 1) * 500 + kilometer + 300;
            Console.WriteLine("Du kommer att betala " + summa + " Kr");
        }
    }
}