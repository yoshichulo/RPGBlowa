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
            List<Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(File.ReadAllText("../../../enemies.json"));
        }
    }
}
