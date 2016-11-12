using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGFramework.Processes;

namespace RPGFramework.Entities
{
    public class EntityClass
    {
        // This class should handle class-specific calculations and functions

        private static List<string> _classes()
        {
            List<string> _classes = new List<string>();
            _classes.Add("Barbarian");
            _classes.Add("Builder");
            _classes.Add("Thief");
            _classes.Add("Mage");
            _classes.Add("Civilian");
            _classes.Add("Mystic Traveler");

            return _classes;
        }

        // Use this to populate a control with classes
        public List<string> GetClasses
        {
            get
            {
                return _classes();
            }
        }
    }
}
