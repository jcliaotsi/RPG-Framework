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
            //TODO: Make this dice-based? -Yes, make it dice-based.
            int damage = 0;
            //int ratio = 0;

            if (attacker.PrimaryType == "physical")
            {
                //ratio = attacker.PrimaryAtk / (defender.Physical + defender.Grit);
                damage = attacker.Physical + DetermineBonus(attacker.Physical) - defender.Physical;
            }

            else if (attacker.PrimaryType == "magick")
            {
                //ratio = attacker.PrimaryAtk / (defender.Magick + defender.Spirit);
                damage = attacker.Magick + DetermineBonus(attacker.Magick) - defender.Magick;
            }

            else if (attacker.PrimaryType == "dexterity")
            {
                //ratio = attacker.PrimaryAtk / (defender.Dexterity + defender.Grit);
                damage = attacker.Dexterity + DetermineBonus(attacker.Dexterity) - defender.Dexterity;
            }

            else
            {
                //TODO: Throw exception
            }

            if (damage < 0)
            {
                damage = 0;
            }

            return damage;
        }

        private int DetermineBonus(int skill)
        {
            int bonus = 0;

            if (skill < 11)
            {
                bonus = d.RollD4();
            }

            else if (skill >= 11 && skill < 15)
            {
                bonus = d.RollD6();
            }

            else if (skill >= 15 && skill < 18)
            {
                bonus = d.RollD8();
            }

            else if (skill >=18 && skill < 20)
            {
                bonus = d.RollD10();
            }

            else if (skill >=20 && skill < 22)
            {
                bonus = d.RollD6(2);
            }

            else if (skill >= 22 && skill < 24)
            {
                bonus = d.RollD8(2);
            }

            else if (skill >=24)
            {
                bonus = d.RollD10(2);
            }

            return bonus;
        }
    }
}
