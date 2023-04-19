using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPM03.ConsoleProject
{
    class FishControl
    {
        private Fish[] fishControl;
        public FishControl (int size)
        {
            fishControl = new Fish[size];
            for (int i = 0; i<size; i++)
            {
                fishControl[i] = new Fish();
            }
        }

        public void setFishControl()
        {
            for (int i = 0; i < fishControl.Length; i++)
            {
                if(fishControl.Length != 0)
                {
                    Console.WriteLine($"Введите характеристики для {i+1} рыбы:\n");
                    Console.Write("Вид: ");
                    fishControl[i].Kind = Console.ReadLine();
                    Console.Write("Производитель: ");
                    fishControl[i].Manufacturer = Console.ReadLine();
                    Console.Write("Цена: ");
                    fishControl[i].Price = Console.ReadLine();
                }
            }
        }
        
        public void updateFishControl(int index)
        {
            try
            {
                Console.WriteLine($"Введите характеристики для {index + 1} рыбы:\n");
                Console.Write("Вид: ");
                fishControl[index].Kind = Console.ReadLine();
                Console.Write("Производитель: ");
                fishControl[index].Manufacturer = Console.ReadLine();
                Console.Write("Цена: ");
                fishControl[index].Price = Console.ReadLine();
            }
            catch
            {

            }
        }
        
        public void getFishControl()
        {
            for (int i = 0; i < fishControl.Length; i++)
            {
                Console.WriteLine($"\tСписок рыб:\n");

                if (fishControl.Length != 0)
                {
                    Console.WriteLine($"Вид: {fishControl[i].Kind}");
                    Console.WriteLine($"Производитель: {fishControl[i].Manufacturer}");
                    Console.WriteLine($"Цена: {fishControl[i].Price}");
                }
            }
        }
    }
}
