using System;

namespace PROG01
{
    class Program
    {

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            bool bshouldRun = true;
            while (bshouldRun)
            {
                int inputNumber;
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputNumber))
                {
                    switch (inputNumber)
                    {
                        case 0:
                            Console.WriteLine("Shutdown Program");
                            bshouldRun = false;
                            break;

                        case 1:
                            HealthPotion potion = new HealthPotion("HealthPotion", "Heal for amount");
                            inventory.Additem(potion);
                            Console.WriteLine("Added a potion to the inventory");
                            break;

                        case 2:
                            ManaPotion pot = new ManaPotion("Manapotion", "Shield for amount");
                            inventory.Additem(pot);
                            Console.WriteLine("Added a ManaPotion to the inventory");
                            break;

                        case 6:
                            int amountOfHealthPotions = 0;
                            int amountOfManaPotions = 0;
                            foreach (var item in inventory.GetItems())
                            {
                                if (item is ManaPotion)
                                {
                                    amountOfHealthPotions++;
                                }
                                if (item is HealthPotion)
                                {
                                    amountOfManaPotions++;
                                }
                            }
                            Console.WriteLine($"Manapotion is {amountOfHealthPotions} Healthpotion is {amountOfManaPotions}");
                            //Console.WriteLine("heal value = {0}", userinput);
                            break;

                        default:
                            Console.WriteLine("wrong number");
                            bshouldRun = true;
                            break;
                    }
                }

            }
        }
    }
}