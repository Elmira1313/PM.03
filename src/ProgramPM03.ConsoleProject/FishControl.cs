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
        public void sortFishControl()
        {
            try
            {
                for (int i = 0; i < fishControl.Length; i++)
                {
                    for (int j = 0; j < fishControl.Length - 1; j++)
                    {
                        if (needToReOrder(fishControl[j].Kind, fishControl[j + 1].Kind))
                        {
                            Fish buffer = fishControl[j];
                            fishControl[j] = fishControl[j + 1];
                            fishControl[j + 1] = buffer;
                        }
                        
                        if (fishControl[j].Kind == fishControl[j + 1].Kind && Convert.ToInt32(fishControl[j].Price) > Convert.ToInt32(fishControl[j + 1].Price))
                        {
                            Fish buffer = fishControl[j];
                            fishControl[j] = fishControl[j + 1];
                            fishControl[j + 1] = buffer;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ошибка сортировки");
            }
        }

        protected static bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
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
