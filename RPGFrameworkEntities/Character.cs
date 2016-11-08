﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGFramework.Processes;

namespace RPGFramework.Entities
{
    public class Character
    {
        private EntityClass _class { get; set; }
        private string _name { get; set; }
        private int _health { get; set; }
        private int _spirit { get; set; }
        private int _grit { get; set; }
        private int _physical { get; set; }
        private int _magick { get; set; }
        private int _dexterity { get; set; }
        private int _focus { get; set; }


        public Character(string entityClass, string name, int health, int spirit, int grit, int physical, int magick, int dexterity, int focus)
        {
            //TODO: Calculate several of these based on class and starting options
            //TODO: Assign class
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
