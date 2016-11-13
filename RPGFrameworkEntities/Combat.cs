using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Combat
    {
        Random r = new Random();
        Dice d = new Dice();

        public Combat()
        {

        }

        public int PrimaryAtk(Character attacker, Character defender)
        {
            // This section is just a bunch of BS to get a system in place.
            // NEEDS HEAVY EDITING
            //TODO: Make this dice-based?
            int damage = 0;
            int ratio = 0;

            if (attacker.PrimaryType == "physical")
            {
                ratio = attacker.PrimaryAtk / (defender.Physical + defender.Grit);
                damage = attacker.PrimaryAtk * ratio - defender.PrimaryAtk;
            }

            else if (attacker.PrimaryType == "magick")
            {
                ratio = attacker.PrimaryAtk / (defender.Magick + defender.Spirit);
                damage = attacker.PrimaryAtk * ratio - defender.PrimaryAtk;
            }

            else if (attacker.PrimaryType == "dexterity")
            {
                ratio = attacker.PrimaryAtk / (defender.Dexterity + defender.Grit);
                damage = attacker.PrimaryAtk * ratio - defender.PrimaryAtk;
            }

            else
            {
                //TODO: Throw exception
            }

            return damage;
        }
    }
}
