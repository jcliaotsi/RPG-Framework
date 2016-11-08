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
        private static List<string> _classes()
        {
            List<string> _classes = new List<string>();
            _classes.Add("Barbarian");
            _classes.Add("Builder");
            _classes.Add("Thief");
            _classes.Add("Mage");
            _classes.Add("Civilian");

            return _classes;
        }
        public List<string> GetClasses
        {
            get
            {
                return _classes();
            }
        }

        public string SelectClass(string selection)
        {
            // ...
            return "";
        }
    }
}
