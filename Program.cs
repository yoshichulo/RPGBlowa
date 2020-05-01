using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;

namespace RPGBlowa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up the player
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);

            Menu.ShowHeader();
            while(true)
            {
                Menu.ShowMenu();
                Menu.SelectOption(player);
            }
        }
    }
}
