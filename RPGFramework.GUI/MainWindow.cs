using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGFramework.Entities;

namespace RPGFramework.GUI
{
    public partial class MainWindow : Form
    {
        //TODO: Add saving system or DB instead of just instantiating
        ControlStatus cs = new ControlStatus();
        Character pc;
        public MainWindow()
        {
            InitializeComponent();
            Initializer();
        }

        public void Initializer()
        {
            btn_Option1.Text = "Start";
            btn_Option1.Visible = true;
            cs.btn_Option1_Status = "start";
        }

        #region Button Event Handlers

        private void btn_Interact_Click(object sender, EventArgs e)
        {

        }

        private void btn_Adventure_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rest_Click(object sender, EventArgs e)
        {

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {

        }

        private void btn_PrimaryAtk_Click(object sender, EventArgs e)
        {

        }

        private void btn_FocusPri_Click(object sender, EventArgs e)
        {

        }

        private void btn_SecondaryAtk_Click(object sender, EventArgs e)
        {

        }

        private void btn_FocusSec_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option1_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option1_Status.ToString();

            switch (status)
            {
                case "start":
                    mlb_ActionLog.AppendText("Game started!\n");
                    cs.btn_Option1_Status = "default";
                    btn_Option1.Visible = false;
                    btn_Option1.Text = "Option 1";

                    pc = new Character("Barbarian", "Deez Nuts", 100, 50, 100, 25, 5, 10, 100);
                    tb_PlayerName.Text = pc.Name;
                    tb_PlayerHP.Text = pc.Health.ToString();

                    break;
            }
        }

        private void btn_Option2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Option8_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
