using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Processes
{
    public class Dice
    {
        Random r = new Random();
        public int RollD6()
        {
            return r.Next(1, 7);
        }

        public int RollD8()
        {
            return r.Next(1, 9);
        }

        public int RollD10()
        {
            return r.Next(1, 11);
        }

        public int RollD12()
        {
            return r.Next(1, 13);
        }

        public int RollD20()
        {
            return r.Next(1, 21);
        }

        public int RollD120()
        {
            return r.Next(1, 121);
        }

        public int RollD6(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD6();
            }

            return total;
        }

        public int RollD8(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD8();
            }

            return total;
        }

        public int RollD10(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD10();
            }

            return total;
        }

        public int RollD12(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD12();
            }

            return total;
        }

        public int RollD20(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD20();
            }

            return total;
        }

        public int RollD120(int n)
        {
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD120();
            }

            return total;
        }
    }
}
