using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Entities
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

        public string btn_Adventure_Status { get; set; }
        public string btn_Interact_Status { get; set; }
        public string btn_Run_Status { get; set; }
        public string btn_Rest_Status { get; set; }
        public string btn_PrimaryAtk_Status { get; set; }
        public string btn_FocusPri_Status { get; set; }
        public string btn_SecondaryAtk_Status { get; set; }
        public string btn_FocusSec_Status { get; set; }

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

            btn_Adventure_Status = "default";
            btn_Interact_Status = "default";
            btn_Run_Status = "default";
            btn_Rest_Status = "default";
            btn_PrimaryAtk_Status = "default";
            btn_FocusPri_Status = "default";
            btn_SecondaryAtk_Status = "default";
            btn_FocusSec_Status = "default";
        }
    }
}
