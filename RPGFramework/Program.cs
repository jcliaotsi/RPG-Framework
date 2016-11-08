using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGFramework.Entities;
using RPGFramework.Processes;
using RPGFramework.Renderer;

namespace RPGFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IOConsole con = new IOConsole();
            con.Render();

        }

        public void Round()
        {
            Character player = new Character(100, "Barbarian");
            Character enemy = new Character(50, "Thief");
        }
    }
}
