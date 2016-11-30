using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RPGFramework.Entities
{
    public class Combat_Shelved
    {
        //Random r = new Random();
        //Dice d = new Dice();
        Utilities u = new Utilities();
        ActionWorker a = new ActionWorker();
        private ControlStatus _cs = new ControlStatus();
        Random r = new Random();
        private Character _player;
        private Character _npc;
        private bool _continue = true;
        private int _roundCount = 0;
        public bool PlayerTurn;

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

        public ControlStatus Cs
        {
            get
            {
                return _cs;
            }

            set
            {
                _cs = value;
            }
        }

        public Combat_Shelved()
        {

        }

        public Combat_Shelved(Character player, Character npc, ControlStatus cs)
        {
            _player = player;
            _npc = npc;
            //TODO: This is ghetto
            Cs = cs;
        }

        public Combat_Shelved(Character[] participants, ControlStatus cs)
        {
            if (participants.Length == 2)
            {
                _player = participants[0];
                _npc = participants[1];
                //TODO: This is ghetto
                Cs = cs;
            }

            else
            {
                throw new ArgumentOutOfRangeException("Combat must have exactly 2 participants.");
            }

            PlayerTurn = u.RollInitiative(_player, _npc);

            // Placeholder for combat rounds
            while (_continue)
            {
                if (PlayerTurn)
                {
                    
                    // Wait for input...
                    PlayerTurn = false;
                }

                else
                {
                    switch (Npc.Humour)
                    {
                        case "angry":
                            if (r.Next(0, 2) == 0)
                            {
                                _player = PrimaryAttack(Npc, Player);
                            }

                            else
                            {
                                _player = SecondaryAttack(Npc, Player);
                            }

                            break;

                        case "rampaging":
                            if (r.Next(0, 2) == 0)
                            {
                                _player = PrimaryAttack(Npc, Player, true);
                            }

                            else
                            {
                                _player = SecondaryAttack(Npc, Player, true);
                            }

                            break;
                    }

                    PlayerTurn = true;
                }

                if (Player.CurrentHealth <= 0)
                {
                    a.Message = "Player " + Player.Name + " has been killed!";
                    _continue = false;
                }

                else if (Npc.CurrentHealth <= 0)
                {
                    a.Message = Npc.Name + " has been slain!";
                    _continue = false;
                }

                _roundCount++;
            }
        }

        public void Round()
        {
            //TODO: Devise better system for starting combat so NPC can gain initiative advantage
            bool playerHasInitiative = u.RollInitiative(_player, _npc);
            
            if (playerHasInitiative)
            {
                //EventHandler eh = new EventHandler(void (Button. sender, EventArgs e) );
            }

            else
            {

            }
        }

        public Character PrimaryAttack(Character attacker, Character defender, bool focus = false)
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

            return defender;
        }

        public Character SecondaryAttack(Character attacker, Character defender, bool focus = false)
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

            return defender;
        }
    }
}
