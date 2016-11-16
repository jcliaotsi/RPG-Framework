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
        Utilities u = new Utilities();

        public Combat()
        {

        }

        public int PrimaryAtk(Character attacker, Character defender)
        {
            // Very basic system. Needs more complexity.
            int damage = 0;

            if (attacker.PrimaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical) - defender.Dexterity;
            }

            else if (attacker.PrimaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick) - defender.Magick;
            }

            else if (attacker.PrimaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity) - defender.Physical;
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

        public int SecondaryAtk(Character attacker, Character defender)
        {
            // Very basic system. Needs more complexity.
            int damage = 0;

            if (attacker.SecondaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical) - defender.Dexterity;
            }

            else if (attacker.SecondaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick) - defender.Magick;
            }

            else if (attacker.SecondaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity) - defender.Physical;
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

        public int PrimaryFoc(Character attacker, Character defender)
        {
            // Very basic system. Needs more complexity.
            int damage = 0;
            bool maxDmg = true;

            if (attacker.PrimaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical, maxDmg);
            }

            else if (attacker.PrimaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick, maxDmg);
            }

            else if (attacker.PrimaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity, maxDmg);
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

        public int SecondaryFoc(Character attacker, Character defender)
        {
            // Very basic system. Needs more complexity.
            int damage = 0;
            bool maxDmg = true;

            if (attacker.SecondaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical, maxDmg);
            }

            else if (attacker.SecondaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick, maxDmg);
            }

            else if (attacker.SecondaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity, maxDmg);
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
    }
}
