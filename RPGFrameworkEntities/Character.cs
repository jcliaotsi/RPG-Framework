using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGFramework.Processes;

namespace RPGFramework.Entities
{
    public class Character
    {
        private string _class { get; set; }
        private string _name { get; set; }
        private int _health { get; set; }
        private int _spirit { get; set; }
        private int _grit { get; set; }
        private int _physical { get; set; }
        private int _magick { get; set; }
        private int _dexterity { get; set; }
        private int _focus { get; set; }

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

        public Character()
        {

        }


        public Character(string characterClass, string name, int health, int spirit, int grit, int physical, int magick, int dexterity, int focus)
        {
            //TODO: Calculate several of these based on class and starting options
            _class = characterClass;
            _name = name;
            _health = health;
            _spirit = spirit;
            _grit = grit;
            _physical = physical;
            _magick = magick;
            _dexterity = dexterity;
            _focus = focus;
        }
    }
}
