using System;
using System.Collections.Generic;
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
            {3, "Exit"}
        };

        public static void ShowMenu()
        {
            Console.WriteLine(MenuHeader());
            Console.WriteLine("Welcome! What do you want to do?\n");

            foreach (KeyValuePair<int, string> kvp in MenuOptions)
            {
                Console.WriteLine("{0}. {1}", kvp.Key, kvp.Value);
            }
        }

        private static void SelectOption()
        {

        }
    }
}
