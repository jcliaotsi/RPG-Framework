using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    class Combat
    {
        //Random r = new Random();
        //Dice d = new Dice();
        Utilities u = new Utilities();
        private Character _player;
        private Character _npc;
        private bool _continue = true;

        public Character Player
        {
            get
            {
                return _player;
            }
        }

        public Character Npc
        {
            get
            {
                return _npc;
            }
        }

        public Combat(Character player, Character npc)
        {
            _player = player;
            _npc = npc;
        }

        public Combat(Character[] participants)
        {
            if (participants.Length == 2)
            {
                _player = participants[0];
                _npc = participants[1];
            }

            else
            {
                throw new ArgumentOutOfRangeException("Combat must have exactly 2 participants.");
            }
        }

        public void Round()
        {
            //TODO: Devise better system for starting combat so NPC can gain initiative advantage
            bool playerHasInitiative = u.RollInitiative(_player, _npc);
            //...
        }

        public void PrimaryAttack(Character attacker, Character defender, bool focus = false)
        {
            int damage = 0;

            if (attacker.PrimaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical, focus) - defender.Dexterity;
            }

            else if (attacker.PrimaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick, focus) - defender.Magick;
            }

            else if (attacker.PrimaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity, focus) - defender.Physical;
            }

            else
            {
                //TODO: Throw exception
            }

            if (damage < 0)
            {
                damage = 0;
            }

            defender.CurrentHealth -= damage;
        }

        public void SecondaryAttack(Character attacker, Character defender, bool focus = false)
        {
            int damage = 0;

            if (attacker.SecondaryType == "physical")
            {
                damage = attacker.Physical + u.DetermineBonus(attacker.Physical, focus) - defender.Dexterity;
            }

            else if (attacker.SecondaryType == "magick")
            {
                damage = attacker.Magick + u.DetermineBonus(attacker.Magick, focus) - defender.Magick;
            }

            else if (attacker.SecondaryType == "dexterity")
            {
                damage = attacker.Dexterity + u.DetermineBonus(attacker.Dexterity, focus) - defender.Physical;
            }

            else
            {
                //TODO: Throw exception
            }

            if (damage < 0)
            {
                damage = 0;
            }

            defender.CurrentHealth -= damage;
        }
    }
}
