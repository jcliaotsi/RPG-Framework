using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class Dice
    {
        Random r = new Random();

        public int RollD4(bool max = false)
        {
            if (max == true)
            {
                return 4;
            }

            return r.Next(1, 5);
        }

        public int RollD6(bool max = false)
        {
            if (max == true)
            {
                return 6;
            }

            return r.Next(1, 7);
        }

        public int RollD8(bool max = false)
        {
            if (max == true)
            {
                return 8;
            }

            return r.Next(1, 9);
        }

        public int RollD10(bool max = false)
        {
            if (max == true)
            {
                return 10;
            }

            return r.Next(1, 11);
        }

        public int RollD12(bool max = false)
        {
            if (max == true)
            {
                return 12;
            }

            return r.Next(1, 13);
        }

        public int RollD20(bool max = false)
        {
            if (max == true)
            {
                return 20;
            }

            return r.Next(1, 21);
        }

        public int RollD120(bool max = false)
        {
            if (max == true)
            {
                return 120;
            }

            return r.Next(1, 121);
        }

        public int RollD4(int n, bool max = false)
        {
            if (max == true)
            {
                return 4 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD4();
            }

            return total;
        }

        public int RollD6(int n, bool max = false)
        {
            if (max == true)
            {
                return 6 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD6();
            }

            return total;
        }

        public int RollD8(int n, bool max = false)
        {
            if (max == true)
            {
                return 8 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD8();
            }

            return total;
        }

        public int RollD10(int n, bool max = false)
        {
            if (max == true)
            {
                return 10 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD10();
            }

            return total;
        }

        public int RollD12(int n, bool max = false)
        {
            if (max == true)
            {
                return 12 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD12();
            }

            return total;
        }

        public int RollD20(int n, bool max = false)
        {
            if (max == true)
            {
                return 20 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD20();
            }

            return total;
        }

        public int RollD120(int n, bool max = false)
        {
            if (max == true)
            {
                return 120 * n;
            }

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += RollD120();
            }

            return total;
        }
    }
}
