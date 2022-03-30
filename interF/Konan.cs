using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interF
{
    internal class Konan : enemies
    {
        public Konan(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }
        }

        static string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Ангел" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
