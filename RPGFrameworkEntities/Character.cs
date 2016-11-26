using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Character
    {
        #region Globals

        Dice d = new Dice();

        #endregion

        #region Private Properties

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
        private int _currentHealth { get; set; }

        #endregion

        #region Public Properties

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

            set
            {
                _humour = value;
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

        public int CurrentHealth
        {
            get
            {
                return _currentHealth;
            }
            set
            {
                _currentHealth = value;
            }
        }

        #endregion

        #region Constructors

        public Character()
        {

        }

        //TODO: Restrict character class selection
        //TODO: Write character creation method
        public Character(string characterClass, string name)
        {
            Utilities u = new Utilities();
            //TODO: Calculate several of these based on class and starting options
            _class = characterClass;
            _name = name;
            _gender = "male"; // Placeholder
            _humour = "angry"; // Placeholder

            switch(characterClass)
            {
                case ("Barbarian"):
                    {
                        _physical = 10 + d.RollD6(4);
                        _magick = d.RollD10();
                        _dexterity = 3 + d.RollD10();
                        _health = _physical + u.DetermineBonus(_physical);
                        _currentHealth = _health;
                        _spirit = _magick + u.DetermineBonus(_magick);
                        _grit = 16 + d.RollD4();
                        _focus = 10;
                        _primaryType = "physical";
                        _secondaryType = "magick"; // Possibly switch to dex?
                        break;
                    }

                case ("Builder"):
                    {
                        _physical = 10 + d.RollD12(2);
                        _magick = d.RollD8();
                        _dexterity = 5 + d.RollD10();
                        _health = _physical + u.DetermineBonus(_physical);
                        _currentHealth = _health;
                        _spirit = _magick + u.DetermineBonus(_magick);
                        _grit = 16 + d.RollD6();
                        _focus = 10;
                        _primaryType = "physical";
                        _secondaryType = "magick"; // Possibly switch to dex?
                        break;
                    }

                case ("Thief"):
                    {
                        _physical = 10 + d.RollD10();
                        _magick = d.RollD8(2);
                        _dexterity = 12 + d.RollD6(4);
                        _health = _physical + u.DetermineBonus(_physical);
                        _currentHealth = _health;
                        _spirit = _magick + u.DetermineBonus(_magick);
                        _grit = 10 + d.RollD6();
                        _focus = 10;
                        _primaryType = "dexterity";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Mage"):
                    {
                        _physical = 10 + d.RollD6();
                        _magick = 12 + d.RollD6(4);
                        _dexterity = d.RollD10();
                        _health = _physical + u.DetermineBonus(_physical);
                        _currentHealth = _health;
                        _spirit = _magick + u.DetermineBonus(_magick);
                        _grit = 10 + d.RollD4();
                        _focus = 10;
                        _primaryType = "magick";
                        _secondaryType = "pysical";
                        break;
                    }

                case ("Mystic Traveler"):
                    {
                        _health = d.RollD20(2);
                        _currentHealth = _health;
                        _spirit = d.RollD20(2);
                        _grit = d.RollD20(2);
                        _physical = d.RollD20(2);
                        _magick = d.RollD20(2);
                        _dexterity = d.RollD20(2);
                        _focus = d.RollD20(2);
                        _primaryType = "physical";
                        _secondaryType = "magick";
                        break;
                    }

                case ("Civilian"):
                    {
                        _physical = d.RollD10();
                        _magick = d.RollD10();
                        _dexterity = d.RollD10();
                        _health = _physical + u.DetermineBonus(_physical);
                        _currentHealth = _health;
                        _spirit = _magick + u.DetermineBonus(_magick);
                        _grit = d.RollD10();
                        _focus = 10;
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

        #endregion

        #region Public Methods

        public void Rest()
        {
            _currentHealth = _health;
            // Expand with rest of stats as needed...
        }

        #endregion
    }
}
