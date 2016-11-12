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

        #region GameStart

        public void StartNewGame()
        {
            mlb_ActionLog.AppendText("Game started!\n");
            mlb_ActionLog.AppendText("Select your character class\n");

            cs.btn_Option1_Status = "character";
            btn_Option1.Visible = true;
            btn_Option1.Text = "Barbarian";

            cs.btn_Option2_Status = "character";
            btn_Option2.Visible = true;
            btn_Option2.Text = "Builder";

            cs.btn_Option3_Status = "character";
            btn_Option3.Visible = true;
            btn_Option3.Text = "Thief";

            cs.btn_Option4_Status = "character";
            btn_Option4.Visible = true;
            btn_Option4.Text = "Mage";

            cs.btn_Option5_Status = "character";
            btn_Option5.Visible = true;
            btn_Option5.Text = "Mystic Traveler";

            cs.btn_Option6_Status = "character";
            btn_Option6.Visible = true;
            btn_Option6.Text = "Civilian";
        }

        public void SelectCharacter(string characterClass, string name)
        {
            pc = new Character(characterClass, tb_PlayerName.Text);

            tb_PlayerName.Text = pc.Name;
            tb_PlayerHP.Text = pc.Health.ToString();
            tb_PlayerSpr.Text = pc.Spirit.ToString();
            tb_PlayerGrt.Text = pc.Grit.ToString();
            tb_PlayerPhs.Text = pc.Physical.ToString();
            tb_PlayerMag.Text = pc.Magick.ToString();
            tb_PlayerDex.Text = pc.Dexterity.ToString();
            tb_PlayerFoc.Text = pc.Focus.ToString();
            tb_PlayerPri.Text = pc.PrimaryAtk.ToString();
            tb_PlayerSec.Text = pc.SecondaryAtk.ToString();

            DefaultAllButtons();
        }

        #endregion

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
                    StartNewGame();
                    break;

                case "character":
                    SelectCharacter(btn_Option1.Text, "");
                    break;
            }
        }

        private void btn_Option2_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option2_Status.ToString();

            switch (status)
            {
                case "character":
                    SelectCharacter(btn_Option2.Text, "");
                    break;
            }
        }

        private void btn_Option3_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option3_Status.ToString();

            switch (status)
            {
                case "character":
                    SelectCharacter(btn_Option3.Text, "");
                    break;
            }
        }

        private void btn_Option4_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option4_Status.ToString();

            switch (status)
            {
                case "character":
                    SelectCharacter(btn_Option4.Text, "");
                    break;
            }
        }

        private void btn_Option5_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option5_Status.ToString();

            switch (status)
            {
                case "character":
                    SelectCharacter(btn_Option5.Text, "");
                    break;
            }
        }

        private void btn_Option6_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option6_Status.ToString();

            switch (status)
            {
                case "character":
                    SelectCharacter(btn_Option6.Text, "");
                    break;
            }
        }

        private void btn_Option7_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option8_Status.ToString();

            switch (status)
            {
                case "PLACEHOLDER":
                    break;
            }
        }

        private void btn_Option8_Click(object sender, EventArgs e)
        {
            string status = cs.btn_Option8_Status.ToString();

            switch (status)
            {
                case "PLACEHOLDER":
                    break;
            }
        }

        #endregion

        #region Utilities

        private void DefaultAllButtons()
        {
            cs.btn_Option1_Status = "default";
            cs.btn_Option2_Status = "default";
            cs.btn_Option3_Status = "default";
            cs.btn_Option4_Status = "default";
            cs.btn_Option5_Status = "default";
            cs.btn_Option6_Status = "default";
            cs.btn_Option7_Status = "default";
            cs.btn_Option8_Status = "default";

            btn_Option1.Visible = false;
            btn_Option2.Visible = false;
            btn_Option3.Visible = false;
            btn_Option4.Visible = false;
            btn_Option5.Visible = false;
            btn_Option6.Visible = false;
            btn_Option7.Visible = false;
            btn_Option8.Visible = false;
        }

        #endregion
    }
}
