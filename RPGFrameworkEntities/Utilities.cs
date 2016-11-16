using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Utilities
    {
        Dice d = new Dice();

        public int DetermineBonus(int skill, bool max = false)
        {
            int bonus = 0;

            if (skill < 11)
            {
                bonus = d.RollD4(max);
            }

            else if (skill >= 11 && skill < 15)
            {
                bonus = d.RollD6(max);
            }

            else if (skill >= 15 && skill < 18)
            {
                bonus = d.RollD8(max);
            }

            else if (skill >= 18 && skill < 20)
            {
                bonus = d.RollD10(max);
            }

            else if (skill >= 20 && skill < 22)
            {
                bonus = d.RollD6(2, max);
            }

            else if (skill >= 22 && skill < 24)
            {
                bonus = d.RollD8(2, max);
            }

            else if (skill >= 24)
            {
                bonus = d.RollD10(2, max);
            }

            return bonus;
        }
    }
}
