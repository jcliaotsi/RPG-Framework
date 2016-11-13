using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Encounter
    {
        Random r = new Random();
        public Character Npc;

        public Encounter()
        {
            switch (r.Next(1, 7))
            {
                case 1:
                    Npc = new Character("Barbarian", "DEEZ NUTS");
                    break;

                case 2:
                    Npc = new Character("Builder", "DEEZ NUTS");
                    break;

                case 3:
                    Npc = new Character("Thief", "DEEZ NUTS");
                    break;

                case 4:
                    Npc = new Character("Mage", "DEEZ NUTS");
                    break;

                case 5:
                    Npc = new Character("Mystic Traveler", "DEEZ NUTS");
                    break;

                case 6:
                    Npc = new Character("Civilian", "DEEZ NUTS");
                    break;
            }
        }
    }
}
