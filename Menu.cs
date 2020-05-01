using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPGBlowa
{
    class Menu
    {
        private static string MenuHeader()
        {
            return @"
____________ _____ ______ _                    
| ___ \ ___ \  __ \| ___ \ |                   
| |_/ / |_/ / |  \/| |_/ / | _____      ____ _ 
|    /|  __/| | __ | ___ \ |/ _ \ \ /\ / / _` |
| |\ \| |   | |_\ \| |_/ / | (_) \ V  V / (_| |
\_| \_\_|    \____/\____/|_|\___/ \_/\_/ \__,_|
                                              
";
        }

        public static Dictionary<int, string> MenuOptions = new Dictionary<int, string>()
        {
            {1, "Fight"},
            {2, "Shop"},
            {3, "View stats"},
            {4, "Exit"},
        };

        public static void ShowHeader()
        {
            Console.WriteLine(MenuHeader());
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome! What do you want to do? [1~{0}]\n", MenuOptions.Count);

            foreach (KeyValuePair<int, string> kvp in MenuOptions)
            {
                Console.WriteLine("{0}. {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();
        }

        public static void SelectOption(Player p)
        {
            bool validValue = false;
            int selectedOption = 0;

            // Ask for a valid value
            while (!validValue)
            {
                string input = Console.ReadLine();
                try
                {
                    selectedOption = Int32.Parse(input);
                    if (selectedOption < 1 || selectedOption > MenuOptions.Count)
                        Console.WriteLine("Option is not in range. Try again");

                    else
                        validValue = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("You need to introduce a numeric value. Try again");
                }
            }

            switch (selectedOption)
            {
                
                case 1:
                    List<Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(File.ReadAllText("../../../enemies.json"));
                    Random rand = new Random();

                    Fighting.Fight(p, enemies[rand.Next(0, enemies.Count)]);
                    break;
                case 2:
                    //Shop
                    break;
                case 3:
                    p.StatView();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
