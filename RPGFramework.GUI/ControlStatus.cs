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
        public string btn_Option2_Status { get; set; }
        public string btn_Option3_Status { get; set; }
        public string btn_Option4_Status { get; set; }
        public string btn_Option5_Status { get; set; }
        public string btn_Option6_Status { get; set; }
        public string btn_Option7_Status { get; set; }
        public string btn_Option8_Status { get; set; }

        public ControlStatus()
        {
            btn_Option1_Status = "default";
            btn_Option2_Status = "default";
            btn_Option3_Status = "default";
            btn_Option4_Status = "default";
            btn_Option5_Status = "default";
            btn_Option6_Status = "default";
            btn_Option7_Status = "default";
            btn_Option8_Status = "default";
        }
    }
}
