using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.GUI
{
    public class ControlStatus
    {
        //TODO: Define an interface for this class to control statuses
        public string btn_Option1_Status { get; set; }

        public ControlStatus()
        {
            btn_Option1_Status = "default";
        }
    }
}
