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
        Encounter en;
        public MainWindow()
        {
            InitializeComponent();
            Initializer();
        }

        public void Initializer()
        {
            DefaultAllButtons();
            DefaultAllText();

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

            btn_Adventure.Visible = true;
        }

        #endregion

        #region Button Event Handlers

        private void btn_Interact_Click(object sender, EventArgs e)
        {
            string h = tb_NPCHumour.Text;

            switch (h)
            {
                case "angry":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " is having none of your shit.\n");
                    // Attack
                    break;

                case "affable":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " greets you like a friend.\n");
                    break;

                case "suspicious":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " gives you a cautious greeting.\n");
                    break;

                case "seedy":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " eyes you like a piece of meat and cackles.\n");
                    break;

                case "flirty":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " compliments your kilt. You aren't wearing a kilt.\n");
                    break;

                case "rampaging":
                    //TODO: Random action generator
                    mlb_ActionLog.AppendText(tb_NPCName.Text + " wrecks your face. Why did you think that was a good idea?\n");
                    // Attack twice
                    break;
            }
        }

        private void btn_Adventure_Click(object sender, EventArgs e)
        {
            en = new Encounter();

            tb_NPCName.Text = en.Npc.Name;
            tb_NPCHP.Text = "0";
            tb_NPCHumour.Text = en.Npc.Humour;
            tb_NPCGender.Text = en.Npc.Gender;
            tb_NPCLastAct.Text = "none";

            mlb_ActionLog.AppendText("A wild " + en.Npc.Name + " appears!\n");
            ReadyEncounter();
        }

        private void btn_Rest_Click(object sender, EventArgs e)
        {
            //TODO: Set max values for character stats so resting can be accomplished
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {

        }

        private void btn_PrimaryAtk_Click(object sender, EventArgs e)
        {
            Combat c = new Combat();
            int damage = c.PrimaryAtk(pc, en.Npc);
            mlb_ActionLog.AppendText("You did " + damage.ToString() + " with your attack!\n");
            // This is ghetto
            int holder = Convert.ToInt32(tb_NPCHP.Text);
            holder += damage;
            tb_NPCHP.Text = holder.ToString();
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

        private void DefaultAllText()
        {
            tb_PlayerName.Text = "";
            tb_PlayerHP.Text = "";
            tb_PlayerSpr.Text = "";
            tb_PlayerGrt.Text = "";
            tb_PlayerPhs.Text = "";
            tb_PlayerMag.Text = "";
            tb_PlayerDex.Text = "";
            tb_PlayerFoc.Text = "";

            tb_NPCName.Text = "";
            tb_NPCGender.Text = "";
            tb_NPCHP.Text = "";
            tb_NPCHumour.Text = "";
            tb_NPCLastAct.Text = "";

            mlb_ActionLog.Text = "";
        }

        private void ReadyEncounter()
        {
            btn_Adventure.Visible = false;
            btn_Interact.Visible = true;
            btn_PrimaryAtk.Visible = true;
            btn_FocusPri.Visible = true;
            btn_SecondaryAtk.Visible = true;
            btn_FocusSec.Visible = true;
            btn_Run.Visible = true;
        }

        #endregion
    }
}
