using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Renderer
{
    public class IOConsole
    {
        private static int _x = 29;
        private static int _y = 84;

        public void Render()
        {
            //Console.WindowHeight = _y;
            //Console.WindowWidth = _x;
            Console.SetWindowSize(_y, _x);

            string[,] screen = TitleScreen();
            for (int x = 0; x < _x; x++)
            {
                for (int y = 0; y < _y; y++)
                {
                    Console.Write(screen[y, x]);
                }
            }

            Console.ReadLine();
        }

        private string[,] TitleScreen()
        {
            string[,] screen = new string[_y, _x];
            
            for (int x = 0; x < _x; x++)
            {
                for (int y = 0; y < _y; y++)
                {
                    if (x == 0)
                    {
                        screen[y, x] = "0";
                    }

                    else if (x == _x - 1)
                    {
                        screen[y, x] = "*";
                    }

                    else if (y == 0 || y == _y - 1)
                    {
                        screen[y, x] = "*";
                    }

                    else
                    {
                        screen[y, x] = ".";
                    }
                }
            }

            return screen;
        }
    }
}
