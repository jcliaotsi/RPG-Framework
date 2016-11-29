using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
{
    public class ActionWorker
    {
        public string Message;
        public bool PlayerPrimaryAttack = false;
        public bool PlayerSecondaryAttack = false;
        public bool PlayerPrimaryFocus = false;
        public bool PlayerSecondaryFocus = false;
        public bool PlayerAlive = true;
        public bool NpcAlive = false;
    }
}
