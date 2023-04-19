using System;

namespace ProgramPM03.ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Количество видов рыб: ");
            n = Convert.ToInt32(Console.ReadLine());

            FishControl fishControl = new FishControl(n);

            fishControl.setFishControl();
            fishControl.getFishControl();

            Console.Write("Sort: ");
            fishControl.sortFishControl();
            fishControl.getFishControl();

            fishControl.writingFishControl(".\\Text.txt");
        }
    }
}
