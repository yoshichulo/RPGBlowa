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
            // Loading enemies.json file and deserializing into an Enemy list
            List<Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(File.ReadAllText("../../../enemies.json"));


            // Setting up the player
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);

            Menu.ShowMenu();

        }
    }
}
