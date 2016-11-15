using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Character
    {
        Dice d = new Dice();

        private string _class { get; set; }
        private string _name { get; set; }
        private int _health { get; set; }
        private int _spirit { get; set; }
        private int _grit { get; set; }
        private int _physical { get; set; }
        private int _magick { get; set; }
        private int _dexterity { get; set; }
        private int _focus { get; set; }
        private int _primaryAtk { get; set; }
        private int _secondaryAtk { get; set; }
        private string _gender { get; set; }
        private string _humour { get; set; }
        private string _lastAction { get; set; }
        private int _damageTaken { get; set; }
        private string _primaryType { get; set; }
        private string _secondaryType { get; set; }

        public string Class
        {
            get
            {
                return _class;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
        }
        public int Spirit
        {
            get
            {
                return _spirit;
            }
        }
        public int Grit
        {
            get
            {
                return _grit;
            }
        }
        public int Physical
        {
            get
            {
                return _physical;
            }
        }
        public int Magick
        {
            get
            {
                return _magick;
            }
        }
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }
        }
        public int Focus
        {
            get
            {
                return _focus;
            }
        }

        public int PrimaryAtk
        {
            get
            {
                return _primaryAtk;
            }
        }

        public int SecondaryAtk
        {
            get
            {
                return _secondaryAtk;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
        }

        public string Humour
        {
            get
            {
                return _humour;
            }
        }

        public string LastAction
        {
            get
            {
                return _lastAction;
            }
        }

        public int DamageTaken
        {
            get
            {
                return _damageTaken;
            }
        }

        public string PrimaryType
        {
            get
            {
                return _primaryType;
            }
        }

        public string SecondaryType
        {
            get
            {
                return _secondaryType;
            }
        }

        public Character()
        {

        }

        //TODO: Restrict character class selection
        //TODO: Write character creation method
        public Character(string characterClass, string name)
        {
            //TODO: Calculate several of these based on class and starting options
            _class = characterClass;
            _name = name;
            _gender = "male"; // Placeholder
            _humour = "angry"; // Placeholder
            //_health = health;
            //_spirit = spirit;
            //_grit = grit;
            //_physical = physical;
            //_magick = magick;
            //_dexterity = dexterity;
            //_focus = focus;

            switch(characterClass)
            {
                case ("Barbarian"):
                    {
                        _health = 10 + d.RollD6(4);
                        _spirit = 10;
                        _grit = 80;
                        _physical = _health / d.RollD4(); //TODO: Revamp to be in-line with dice rolls
                        _magick = _spirit;
                        _dexterity = _health / d.RollD8();
                        _focus = 100;
                        _primaryAtk = (_physical * 2) + _dexterity;
                        _secondaryAtk = _magick + _spirit;
                        _primaryType = "physical";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Builder"):
                    {
                        _health = 10 + d.RollD20();
                        _spirit = 10;
                        _grit = 100;
                        _physical = _health / d.RollD6();
                        _magick = _spirit;
                        _dexterity = _health / d.RollD10();
                        _focus = 100;
                        _primaryAtk = _physical + _grit + _dexterity;
                        _secondaryAtk = _magick + _spirit;
                        _primaryType = "physical";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Thief"):
                    {
                        _health = 10 + d.RollD8();
                        _spirit = 30;
                        _grit = 60;
                        _physical = _health / d.RollD8();
                        _magick = _spirit;
                        _dexterity = 28 + d.RollD20(2);
                        _focus = 100;
                        _primaryAtk = (_dexterity * 2) + _physical;
                        _secondaryAtk = _magick + _spirit;
                        _primaryType = "dexterity";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Mage"):
                    {
                        _health = 10 + d.RollD4();
                        _spirit = 100;
                        _grit = 40;
                        _physical = _health / d.RollD12();
                        _magick = _spirit + d.RollD20();
                        _dexterity = _health / d.RollD12();
                        _focus = 100;
                        _primaryAtk = (_magick * 2) + _spirit;
                        _secondaryAtk = _physical + _dexterity;
                        _primaryType = "magick";
                        _secondaryType = "pysical";
                        break;
                    }

                case ("Mystic Traveler"):
                    {
                        _health = d.RollD20(2);
                        _spirit = d.RollD20(2);
                        _grit = d.RollD20(2);
                        _physical = d.RollD20(2);
                        _magick = d.RollD20(2);
                        _dexterity = d.RollD20(2);
                        _focus = d.RollD20(2);
                        _primaryAtk = _physical + _dexterity + _grit; // Implement a random system that gives clues to which it will be
                        _secondaryAtk = _magick + _spirit + _grit;
                        _primaryType = "physical";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Civilian"):
                    {
                        _health = 10;
                        _spirit = 10;
                        _grit = 10;
                        _physical = d.RollD20();
                        _magick = d.RollD20();
                        _dexterity = d.RollD20();
                        _focus = 50;
                        _primaryAtk = (_physical * 2) + _dexterity;
                        _secondaryAtk = (_magick * 2) + _spirit;
                        _primaryType = "physical";
                        _secondaryType = "magick";
                        break;
                    }

                default:
                    {
                        //TODO: Throw exception
                        break;
                    }
            }
        }
    }
}
