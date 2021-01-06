using System;

namespace timeCalulatorNewSolution
{
    class CalculatorTime
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (hour < 0 || minutes < 0)
            {
                Console.WriteLine("Hour and minutes needs to be only positive numbers !");
            }
            else
            {
                if (minutes >= 60)
                {

                    hour++;
                    minutes = minutes - 60;
                }
                if (hour > 23)
                {
                    hour = 0;
                }
                Console.WriteLine($"{hour} h : {minutes} m");
            }


        }
    }
}
