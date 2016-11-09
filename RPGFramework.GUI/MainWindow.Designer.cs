namespace RPGFramework.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Player = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Interact = new System.Windows.Forms.Button();
            this.btn_Adventure = new System.Windows.Forms.Button();
            this.btn_Rest = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_PrimaryAtk = new System.Windows.Forms.Button();
            this.btn_FocusPri = new System.Windows.Forms.Button();
            this.btn_SecondaryAtk = new System.Windows.Forms.Button();
            this.btn_FocusSec = new System.Windows.Forms.Button();
            this.btn_Option1 = new System.Windows.Forms.Button();
            this.btn_Option2 = new System.Windows.Forms.Button();
            this.btn_Option3 = new System.Windows.Forms.Button();
            this.btn_Option4 = new System.Windows.Forms.Button();
            this.btn_Option5 = new System.Windows.Forms.Button();
            this.btn_Option6 = new System.Windows.Forms.Button();
            this.btn_Option7 = new System.Windows.Forms.Button();
            this.btn_Option8 = new System.Windows.Forms.Button();
            this.tbl_PlayerStats = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.lbl_PlayerHP = new System.Windows.Forms.Label();
            this.lbl_PlayerSpr = new System.Windows.Forms.Label();
            this.lbl_PlayerGrt = new System.Windows.Forms.Label();
            this.lbl_PlayerPhs = new System.Windows.Forms.Label();
            this.lbl_PlayerMag = new System.Windows.Forms.Label();
            this.lbl_PlayerDex = new System.Windows.Forms.Label();
            this.lbl_PlayerPri = new System.Windows.Forms.Label();
            this.lbl_PlayerSec = new System.Windows.Forms.Label();
            this.lbl_PlayerFoc = new System.Windows.Forms.Label();
            this.tb_PlayerName = new System.Windows.Forms.TextBox();
            this.tb_PlayerHP = new System.Windows.Forms.TextBox();
            this.tb_PlayerSpr = new System.Windows.Forms.TextBox();
            this.tb_PlayerGrt = new System.Windows.Forms.TextBox();
            this.tb_PlayerPhs = new System.Windows.Forms.TextBox();
            this.tb_PlayerMag = new System.Windows.Forms.TextBox();
            this.tb_PlayerDex = new System.Windows.Forms.TextBox();
            this.tb_PlayerPri = new System.Windows.Forms.TextBox();
            this.tb_PlayerSec = new System.Windows.Forms.TextBox();
            this.tb_PlayerFoc = new System.Windows.Forms.TextBox();
            this.pnl_NPC = new System.Windows.Forms.Panel();
            this.mlb_ActionLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_NPCName = new System.Windows.Forms.Label();
            this.lbl_NPCHP = new System.Windows.Forms.Label();
            this.lbl_NPCGender = new System.Windows.Forms.Label();
            this.lbl_NPCHumour = new System.Windows.Forms.Label();
            this.lbl_NPSLastAct = new System.Windows.Forms.Label();
            this.tb_NPCName = new System.Windows.Forms.TextBox();
            this.tb_NPCHP = new System.Windows.Forms.TextBox();
            this.tb_NPCGender = new System.Windows.Forms.TextBox();
            this.tb_NPCHumour = new System.Windows.Forms.TextBox();
            this.tb_NPCLastAct = new System.Windows.Forms.TextBox();
            this.pnl_Board = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_Player.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_PlayerStats.SuspendLayout();
            this.pnl_NPC.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_Board.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Player
            // 
            this.pnl_Player.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Player.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Player.Controls.Add(this.tbl_PlayerStats);
            this.pnl_Player.Location = new System.Drawing.Point(12, 12);
            this.pnl_Player.Name = "pnl_Player";
            this.pnl_Player.Size = new System.Drawing.Size(300, 537);
            this.pnl_Player.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Interact, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Adventure, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Rest, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Run, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_PrimaryAtk, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_FocusPri, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_SecondaryAtk, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_FocusSec, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Option8, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 273);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Interact
            // 
            this.btn_Interact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Interact.Location = new System.Drawing.Point(3, 3);
            this.btn_Interact.Name = "btn_Interact";
            this.btn_Interact.Size = new System.Drawing.Size(67, 59);
            this.btn_Interact.TabIndex = 0;
            this.btn_Interact.Text = "Interact";
            this.btn_Interact.UseVisualStyleBackColor = true;
            this.btn_Interact.Visible = false;
            this.btn_Interact.Click += new System.EventHandler(this.btn_Interact_Click);
            // 
            // btn_Adventure
            // 
            this.btn_Adventure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Adventure.Location = new System.Drawing.Point(76, 3);
            this.btn_Adventure.Name = "btn_Adventure";
            this.btn_Adventure.Size = new System.Drawing.Size(67, 59);
            this.btn_Adventure.TabIndex = 1;
            this.btn_Adventure.Text = "Adventure";
            this.btn_Adventure.UseVisualStyleBackColor = true;
            this.btn_Adventure.Visible = false;
            this.btn_Adventure.Click += new System.EventHandler(this.btn_Adventure_Click);
            // 
            // btn_Rest
            // 
            this.btn_Rest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rest.Location = new System.Drawing.Point(149, 3);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(67, 59);
            this.btn_Rest.TabIndex = 2;
            this.btn_Rest.Text = "Rest";
            this.btn_Rest.UseVisualStyleBackColor = true;
            this.btn_Rest.Visible = false;
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Run.Location = new System.Drawing.Point(222, 3);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(68, 59);
            this.btn_Run.TabIndex = 3;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Visible = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_PrimaryAtk
            // 
            this.btn_PrimaryAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PrimaryAtk.Location = new System.Drawing.Point(3, 68);
            this.btn_PrimaryAtk.Name = "btn_PrimaryAtk";
            this.btn_PrimaryAtk.Size = new System.Drawing.Size(67, 59);
            this.btn_PrimaryAtk.TabIndex = 4;
            this.btn_PrimaryAtk.Text = "Primary Attack";
            this.btn_PrimaryAtk.UseVisualStyleBackColor = true;
            this.btn_PrimaryAtk.Visible = false;
            this.btn_PrimaryAtk.Click += new System.EventHandler(this.btn_PrimaryAtk_Click);
            // 
            // btn_FocusPri
            // 
            this.btn_FocusPri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FocusPri.Location = new System.Drawing.Point(76, 68);
            this.btn_FocusPri.Name = "btn_FocusPri";
            this.btn_FocusPri.Size = new System.Drawing.Size(67, 59);
            this.btn_FocusPri.TabIndex = 5;
            this.btn_FocusPri.Text = "Primary Focus Attack";
            this.btn_FocusPri.UseVisualStyleBackColor = true;
            this.btn_FocusPri.Visible = false;
            this.btn_FocusPri.Click += new System.EventHandler(this.btn_FocusPri_Click);
            // 
            // btn_SecondaryAtk
            // 
            this.btn_SecondaryAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SecondaryAtk.Location = new System.Drawing.Point(149, 68);
            this.btn_SecondaryAtk.Name = "btn_SecondaryAtk";
            this.btn_SecondaryAtk.Size = new System.Drawing.Size(67, 59);
            this.btn_SecondaryAtk.TabIndex = 6;
            this.btn_SecondaryAtk.Text = "Secondary Attack";
            this.btn_SecondaryAtk.UseVisualStyleBackColor = true;
            this.btn_SecondaryAtk.Visible = false;
            this.btn_SecondaryAtk.Click += new System.EventHandler(this.btn_SecondaryAtk_Click);
            // 
            // btn_FocusSec
            // 
            this.btn_FocusSec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FocusSec.Location = new System.Drawing.Point(222, 68);
            this.btn_FocusSec.Name = "btn_FocusSec";
            this.btn_FocusSec.Size = new System.Drawing.Size(68, 59);
            this.btn_FocusSec.TabIndex = 7;
            this.btn_FocusSec.Text = "Secondary Focus Attack";
            this.btn_FocusSec.UseVisualStyleBackColor = true;
            this.btn_FocusSec.Visible = false;
            this.btn_FocusSec.Click += new System.EventHandler(this.btn_FocusSec_Click);
            // 
            // btn_Option1
            // 
            this.btn_Option1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option1.Location = new System.Drawing.Point(3, 133);
            this.btn_Option1.Name = "btn_Option1";
            this.btn_Option1.Size = new System.Drawing.Size(67, 59);
            this.btn_Option1.TabIndex = 8;
            this.btn_Option1.Text = "Option 1";
            this.btn_Option1.UseVisualStyleBackColor = true;
            this.btn_Option1.Visible = false;
            this.btn_Option1.Click += new System.EventHandler(this.btn_Option1_Click);
            // 
            // btn_Option2
            // 
            this.btn_Option2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option2.Location = new System.Drawing.Point(76, 133);
            this.btn_Option2.Name = "btn_Option2";
            this.btn_Option2.Size = new System.Drawing.Size(67, 59);
            this.btn_Option2.TabIndex = 9;
            this.btn_Option2.Text = "Option 2";
            this.btn_Option2.UseVisualStyleBackColor = true;
            this.btn_Option2.Visible = false;
            this.btn_Option2.Click += new System.EventHandler(this.btn_Option2_Click);
            // 
            // btn_Option3
            // 
            this.btn_Option3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option3.Location = new System.Drawing.Point(149, 133);
            this.btn_Option3.Name = "btn_Option3";
            this.btn_Option3.Size = new System.Drawing.Size(67, 59);
            this.btn_Option3.TabIndex = 10;
            this.btn_Option3.Text = "Option 3";
            this.btn_Option3.UseVisualStyleBackColor = true;
            this.btn_Option3.Visible = false;
            this.btn_Option3.Click += new System.EventHandler(this.btn_Option3_Click);
            // 
            // btn_Option4
            // 
            this.btn_Option4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option4.Location = new System.Drawing.Point(222, 133);
            this.btn_Option4.Name = "btn_Option4";
            this.btn_Option4.Size = new System.Drawing.Size(68, 59);
            this.btn_Option4.TabIndex = 11;
            this.btn_Option4.Text = "Option 4";
            this.btn_Option4.UseVisualStyleBackColor = true;
            this.btn_Option4.Visible = false;
            this.btn_Option4.Click += new System.EventHandler(this.btn_Option4_Click);
            // 
            // btn_Option5
            // 
            this.btn_Option5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option5.Location = new System.Drawing.Point(3, 198);
            this.btn_Option5.Name = "btn_Option5";
            this.btn_Option5.Size = new System.Drawing.Size(67, 60);
            this.btn_Option5.TabIndex = 12;
            this.btn_Option5.Text = "Option 5";
            this.btn_Option5.UseVisualStyleBackColor = true;
            this.btn_Option5.Visible = false;
            this.btn_Option5.Click += new System.EventHandler(this.btn_Option5_Click);
            // 
            // btn_Option6
            // 
            this.btn_Option6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option6.Location = new System.Drawing.Point(76, 198);
            this.btn_Option6.Name = "btn_Option6";
            this.btn_Option6.Size = new System.Drawing.Size(67, 60);
            this.btn_Option6.TabIndex = 13;
            this.btn_Option6.Text = "Option 6";
            this.btn_Option6.UseVisualStyleBackColor = true;
            this.btn_Option6.Visible = false;
            this.btn_Option6.Click += new System.EventHandler(this.btn_Option6_Click);
            // 
            // btn_Option7
            // 
            this.btn_Option7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option7.Location = new System.Drawing.Point(149, 198);
            this.btn_Option7.Name = "btn_Option7";
            this.btn_Option7.Size = new System.Drawing.Size(67, 60);
            this.btn_Option7.TabIndex = 14;
            this.btn_Option7.Text = "Option 7";
            this.btn_Option7.UseVisualStyleBackColor = true;
            this.btn_Option7.Visible = false;
            this.btn_Option7.Click += new System.EventHandler(this.btn_Option7_Click);
            // 
            // btn_Option8
            // 
            this.btn_Option8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Option8.Location = new System.Drawing.Point(222, 198);
            this.btn_Option8.Name = "btn_Option8";
            this.btn_Option8.Size = new System.Drawing.Size(68, 60);
            this.btn_Option8.TabIndex = 15;
            this.btn_Option8.Text = "Option 8";
            this.btn_Option8.UseVisualStyleBackColor = true;
            this.btn_Option8.Visible = false;
            this.btn_Option8.Click += new System.EventHandler(this.btn_Option8_Click);
            // 
            // tbl_PlayerStats
            // 
            this.tbl_PlayerStats.ColumnCount = 2;
            this.tbl_PlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_PlayerStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerName, 0, 0);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerHP, 0, 1);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerSpr, 0, 2);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerGrt, 0, 3);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerPhs, 0, 4);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerMag, 0, 5);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerDex, 0, 6);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerPri, 0, 7);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerSec, 0, 8);
            this.tbl_PlayerStats.Controls.Add(this.lbl_PlayerFoc, 0, 9);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerName, 1, 0);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerHP, 1, 1);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerSpr, 1, 2);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerGrt, 1, 3);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerPhs, 1, 4);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerMag, 1, 5);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerDex, 1, 6);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerPri, 1, 7);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerSec, 1, 8);
            this.tbl_PlayerStats.Controls.Add(this.tb_PlayerFoc, 1, 9);
            this.tbl_PlayerStats.Location = new System.Drawing.Point(4, 4);
            this.tbl_PlayerStats.Name = "tbl_PlayerStats";
            this.tbl_PlayerStats.RowCount = 10;
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_PlayerStats.Size = new System.Drawing.Size(293, 262);
            this.tbl_PlayerStats.TabIndex = 0;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Location = new System.Drawing.Point(108, 6);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(35, 13);
            this.lbl_PlayerName.TabIndex = 0;
            this.lbl_PlayerName.Text = "Name";
            // 
            // lbl_PlayerHP
            // 
            this.lbl_PlayerHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerHP.AutoSize = true;
            this.lbl_PlayerHP.Location = new System.Drawing.Point(105, 32);
            this.lbl_PlayerHP.Name = "lbl_PlayerHP";
            this.lbl_PlayerHP.Size = new System.Drawing.Size(38, 13);
            this.lbl_PlayerHP.TabIndex = 1;
            this.lbl_PlayerHP.Text = "Health";
            // 
            // lbl_PlayerSpr
            // 
            this.lbl_PlayerSpr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerSpr.AutoSize = true;
            this.lbl_PlayerSpr.Location = new System.Drawing.Point(113, 58);
            this.lbl_PlayerSpr.Name = "lbl_PlayerSpr";
            this.lbl_PlayerSpr.Size = new System.Drawing.Size(30, 13);
            this.lbl_PlayerSpr.TabIndex = 2;
            this.lbl_PlayerSpr.Text = "Spirit";
            // 
            // lbl_PlayerGrt
            // 
            this.lbl_PlayerGrt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerGrt.AutoSize = true;
            this.lbl_PlayerGrt.Location = new System.Drawing.Point(120, 84);
            this.lbl_PlayerGrt.Name = "lbl_PlayerGrt";
            this.lbl_PlayerGrt.Size = new System.Drawing.Size(23, 13);
            this.lbl_PlayerGrt.TabIndex = 3;
            this.lbl_PlayerGrt.Text = "Grit";
            // 
            // lbl_PlayerPhs
            // 
            this.lbl_PlayerPhs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerPhs.AutoSize = true;
            this.lbl_PlayerPhs.Location = new System.Drawing.Point(97, 110);
            this.lbl_PlayerPhs.Name = "lbl_PlayerPhs";
            this.lbl_PlayerPhs.Size = new System.Drawing.Size(46, 13);
            this.lbl_PlayerPhs.TabIndex = 4;
            this.lbl_PlayerPhs.Text = "Physical";
            // 
            // lbl_PlayerMag
            // 
            this.lbl_PlayerMag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerMag.AutoSize = true;
            this.lbl_PlayerMag.Location = new System.Drawing.Point(101, 136);
            this.lbl_PlayerMag.Name = "lbl_PlayerMag";
            this.lbl_PlayerMag.Size = new System.Drawing.Size(42, 13);
            this.lbl_PlayerMag.TabIndex = 5;
            this.lbl_PlayerMag.Text = "Magick";
            // 
            // lbl_PlayerDex
            // 
            this.lbl_PlayerDex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerDex.AutoSize = true;
            this.lbl_PlayerDex.Location = new System.Drawing.Point(95, 162);
            this.lbl_PlayerDex.Name = "lbl_PlayerDex";
            this.lbl_PlayerDex.Size = new System.Drawing.Size(48, 13);
            this.lbl_PlayerDex.TabIndex = 6;
            this.lbl_PlayerDex.Text = "Dexterity";
            // 
            // lbl_PlayerPri
            // 
            this.lbl_PlayerPri.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerPri.AutoSize = true;
            this.lbl_PlayerPri.Location = new System.Drawing.Point(68, 188);
            this.lbl_PlayerPri.Name = "lbl_PlayerPri";
            this.lbl_PlayerPri.Size = new System.Drawing.Size(75, 13);
            this.lbl_PlayerPri.TabIndex = 7;
            this.lbl_PlayerPri.Text = "Primary Attack";
            // 
            // lbl_PlayerSec
            // 
            this.lbl_PlayerSec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerSec.AutoSize = true;
            this.lbl_PlayerSec.Location = new System.Drawing.Point(51, 214);
            this.lbl_PlayerSec.Name = "lbl_PlayerSec";
            this.lbl_PlayerSec.Size = new System.Drawing.Size(92, 13);
            this.lbl_PlayerSec.TabIndex = 8;
            this.lbl_PlayerSec.Text = "Secondary Attack";
            // 
            // lbl_PlayerFoc
            // 
            this.lbl_PlayerFoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PlayerFoc.AutoSize = true;
            this.lbl_PlayerFoc.Location = new System.Drawing.Point(107, 241);
            this.lbl_PlayerFoc.Name = "lbl_PlayerFoc";
            this.lbl_PlayerFoc.Size = new System.Drawing.Size(36, 13);
            this.lbl_PlayerFoc.TabIndex = 9;
            this.lbl_PlayerFoc.Text = "Focus";
            // 
            // tb_PlayerName
            // 
            this.tb_PlayerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerName.Location = new System.Drawing.Point(149, 3);
            this.tb_PlayerName.Name = "tb_PlayerName";
            this.tb_PlayerName.ReadOnly = true;
            this.tb_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerName.TabIndex = 10;
            // 
            // tb_PlayerHP
            // 
            this.tb_PlayerHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerHP.Location = new System.Drawing.Point(149, 29);
            this.tb_PlayerHP.Name = "tb_PlayerHP";
            this.tb_PlayerHP.ReadOnly = true;
            this.tb_PlayerHP.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerHP.TabIndex = 11;
            // 
            // tb_PlayerSpr
            // 
            this.tb_PlayerSpr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerSpr.Location = new System.Drawing.Point(149, 55);
            this.tb_PlayerSpr.Name = "tb_PlayerSpr";
            this.tb_PlayerSpr.ReadOnly = true;
            this.tb_PlayerSpr.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerSpr.TabIndex = 12;
            // 
            // tb_PlayerGrt
            // 
            this.tb_PlayerGrt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerGrt.Location = new System.Drawing.Point(149, 81);
            this.tb_PlayerGrt.Name = "tb_PlayerGrt";
            this.tb_PlayerGrt.ReadOnly = true;
            this.tb_PlayerGrt.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerGrt.TabIndex = 13;
            // 
            // tb_PlayerPhs
            // 
            this.tb_PlayerPhs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerPhs.Location = new System.Drawing.Point(149, 107);
            this.tb_PlayerPhs.Name = "tb_PlayerPhs";
            this.tb_PlayerPhs.ReadOnly = true;
            this.tb_PlayerPhs.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerPhs.TabIndex = 14;
            // 
            // tb_PlayerMag
            // 
            this.tb_PlayerMag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerMag.Location = new System.Drawing.Point(149, 133);
            this.tb_PlayerMag.Name = "tb_PlayerMag";
            this.tb_PlayerMag.ReadOnly = true;
            this.tb_PlayerMag.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerMag.TabIndex = 15;
            // 
            // tb_PlayerDex
            // 
            this.tb_PlayerDex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerDex.Location = new System.Drawing.Point(149, 159);
            this.tb_PlayerDex.Name = "tb_PlayerDex";
            this.tb_PlayerDex.ReadOnly = true;
            this.tb_PlayerDex.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerDex.TabIndex = 16;
            // 
            // tb_PlayerPri
            // 
            this.tb_PlayerPri.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerPri.Location = new System.Drawing.Point(149, 185);
            this.tb_PlayerPri.Name = "tb_PlayerPri";
            this.tb_PlayerPri.ReadOnly = true;
            this.tb_PlayerPri.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerPri.TabIndex = 17;
            // 
            // tb_PlayerSec
            // 
            this.tb_PlayerSec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerSec.Location = new System.Drawing.Point(149, 211);
            this.tb_PlayerSec.Name = "tb_PlayerSec";
            this.tb_PlayerSec.ReadOnly = true;
            this.tb_PlayerSec.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerSec.TabIndex = 18;
            // 
            // tb_PlayerFoc
            // 
            this.tb_PlayerFoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_PlayerFoc.Location = new System.Drawing.Point(149, 238);
            this.tb_PlayerFoc.Name = "tb_PlayerFoc";
            this.tb_PlayerFoc.ReadOnly = true;
            this.tb_PlayerFoc.Size = new System.Drawing.Size(100, 20);
            this.tb_PlayerFoc.TabIndex = 19;
            // 
            // pnl_NPC
            // 
            this.pnl_NPC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_NPC.Controls.Add(this.mlb_ActionLog);
            this.pnl_NPC.Controls.Add(this.tableLayoutPanel2);
            this.pnl_NPC.Location = new System.Drawing.Point(872, 12);
            this.pnl_NPC.Name = "pnl_NPC";
            this.pnl_NPC.Size = new System.Drawing.Size(300, 537);
            this.pnl_NPC.TabIndex = 1;
            // 
            // mlb_ActionLog
            // 
            this.mlb_ActionLog.Location = new System.Drawing.Point(4, 137);
            this.mlb_ActionLog.Multiline = true;
            this.mlb_ActionLog.Name = "mlb_ActionLog";
            this.mlb_ActionLog.ReadOnly = true;
            this.mlb_ActionLog.Size = new System.Drawing.Size(293, 397);
            this.mlb_ActionLog.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_NPCName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_NPCHP, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_NPCGender, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_NPCHumour, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_NPSLastAct, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tb_NPCName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_NPCHP, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_NPCGender, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_NPCHumour, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_NPCLastAct, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(293, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_NPCName
            // 
            this.lbl_NPCName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NPCName.AutoSize = true;
            this.lbl_NPCName.Location = new System.Drawing.Point(149, 6);
            this.lbl_NPCName.Name = "lbl_NPCName";
            this.lbl_NPCName.Size = new System.Drawing.Size(35, 13);
            this.lbl_NPCName.TabIndex = 0;
            this.lbl_NPCName.Text = "Name";
            // 
            // lbl_NPCHP
            // 
            this.lbl_NPCHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NPCHP.AutoSize = true;
            this.lbl_NPCHP.Location = new System.Drawing.Point(149, 32);
            this.lbl_NPCHP.Name = "lbl_NPCHP";
            this.lbl_NPCHP.Size = new System.Drawing.Size(81, 13);
            this.lbl_NPCHP.TabIndex = 1;
            this.lbl_NPCHP.Text = "Damage Taken";
            // 
            // lbl_NPCGender
            // 
            this.lbl_NPCGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NPCGender.AutoSize = true;
            this.lbl_NPCGender.Location = new System.Drawing.Point(149, 58);
            this.lbl_NPCGender.Name = "lbl_NPCGender";
            this.lbl_NPCGender.Size = new System.Drawing.Size(42, 13);
            this.lbl_NPCGender.TabIndex = 2;
            this.lbl_NPCGender.Text = "Gender";
            // 
            // lbl_NPCHumour
            // 
            this.lbl_NPCHumour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NPCHumour.AutoSize = true;
            this.lbl_NPCHumour.Location = new System.Drawing.Point(149, 84);
            this.lbl_NPCHumour.Name = "lbl_NPCHumour";
            this.lbl_NPCHumour.Size = new System.Drawing.Size(44, 13);
            this.lbl_NPCHumour.TabIndex = 3;
            this.lbl_NPCHumour.Text = "Humour";
            // 
            // lbl_NPSLastAct
            // 
            this.lbl_NPSLastAct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NPSLastAct.AutoSize = true;
            this.lbl_NPSLastAct.Location = new System.Drawing.Point(149, 111);
            this.lbl_NPSLastAct.Name = "lbl_NPSLastAct";
            this.lbl_NPSLastAct.Size = new System.Drawing.Size(57, 13);
            this.lbl_NPSLastAct.TabIndex = 4;
            this.lbl_NPSLastAct.Text = "LastAction";
            // 
            // tb_NPCName
            // 
            this.tb_NPCName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_NPCName.Location = new System.Drawing.Point(43, 3);
            this.tb_NPCName.Name = "tb_NPCName";
            this.tb_NPCName.ReadOnly = true;
            this.tb_NPCName.Size = new System.Drawing.Size(100, 20);
            this.tb_NPCName.TabIndex = 5;
            // 
            // tb_NPCHP
            // 
            this.tb_NPCHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_NPCHP.Location = new System.Drawing.Point(43, 29);
            this.tb_NPCHP.Name = "tb_NPCHP";
            this.tb_NPCHP.ReadOnly = true;
            this.tb_NPCHP.Size = new System.Drawing.Size(100, 20);
            this.tb_NPCHP.TabIndex = 6;
            // 
            // tb_NPCGender
            // 
            this.tb_NPCGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_NPCGender.Location = new System.Drawing.Point(43, 55);
            this.tb_NPCGender.Name = "tb_NPCGender";
            this.tb_NPCGender.ReadOnly = true;
            this.tb_NPCGender.Size = new System.Drawing.Size(100, 20);
            this.tb_NPCGender.TabIndex = 7;
            // 
            // tb_NPCHumour
            // 
            this.tb_NPCHumour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_NPCHumour.Location = new System.Drawing.Point(43, 81);
            this.tb_NPCHumour.Name = "tb_NPCHumour";
            this.tb_NPCHumour.ReadOnly = true;
            this.tb_NPCHumour.Size = new System.Drawing.Size(100, 20);
            this.tb_NPCHumour.TabIndex = 8;
            // 
            // tb_NPCLastAct
            // 
            this.tb_NPCLastAct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_NPCLastAct.Location = new System.Drawing.Point(43, 107);
            this.tb_NPCLastAct.Name = "tb_NPCLastAct";
            this.tb_NPCLastAct.ReadOnly = true;
            this.tb_NPCLastAct.Size = new System.Drawing.Size(100, 20);
            this.tb_NPCLastAct.TabIndex = 9;
            // 
            // pnl_Board
            // 
            this.pnl_Board.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Board.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Board.Location = new System.Drawing.Point(319, 12);
            this.pnl_Board.Name = "pnl_Board";
            this.pnl_Board.Size = new System.Drawing.Size(547, 537);
            this.pnl_Board.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 530);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(273, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 259);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(3, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 259);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(273, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(264, 259);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnl_Board);
            this.Controls.Add(this.pnl_NPC);
            this.Controls.Add(this.pnl_Player);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.pnl_Player.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_PlayerStats.ResumeLayout(false);
            this.tbl_PlayerStats.PerformLayout();
            this.pnl_NPC.ResumeLayout(false);
            this.pnl_NPC.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_Board.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Player;
        private System.Windows.Forms.Panel pnl_NPC;
        private System.Windows.Forms.Panel pnl_Board;
        private System.Windows.Forms.TableLayoutPanel tbl_PlayerStats;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Label lbl_PlayerHP;
        private System.Windows.Forms.Label lbl_PlayerSpr;
        private System.Windows.Forms.Label lbl_PlayerGrt;
        private System.Windows.Forms.Label lbl_PlayerPhs;
        private System.Windows.Forms.Label lbl_PlayerMag;
        private System.Windows.Forms.Label lbl_PlayerDex;
        private System.Windows.Forms.Label lbl_PlayerPri;
        private System.Windows.Forms.Label lbl_PlayerSec;
        private System.Windows.Forms.Label lbl_PlayerFoc;
        private System.Windows.Forms.TextBox tb_PlayerName;
        private System.Windows.Forms.TextBox tb_PlayerHP;
        private System.Windows.Forms.TextBox tb_PlayerSpr;
        private System.Windows.Forms.TextBox tb_PlayerGrt;
        private System.Windows.Forms.TextBox tb_PlayerPhs;
        private System.Windows.Forms.TextBox tb_PlayerMag;
        private System.Windows.Forms.TextBox tb_PlayerDex;
        private System.Windows.Forms.TextBox tb_PlayerPri;
        private System.Windows.Forms.TextBox tb_PlayerSec;
        private System.Windows.Forms.TextBox tb_PlayerFoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Interact;
        private System.Windows.Forms.Button btn_Adventure;
        private System.Windows.Forms.Button btn_Rest;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_PrimaryAtk;
        private System.Windows.Forms.Button btn_FocusPri;
        private System.Windows.Forms.Button btn_SecondaryAtk;
        private System.Windows.Forms.Button btn_FocusSec;
        private System.Windows.Forms.Button btn_Option1;
        private System.Windows.Forms.Button btn_Option2;
        private System.Windows.Forms.Button btn_Option3;
        private System.Windows.Forms.Button btn_Option4;
        private System.Windows.Forms.Button btn_Option5;
        private System.Windows.Forms.Button btn_Option6;
        private System.Windows.Forms.Button btn_Option7;
        private System.Windows.Forms.Button btn_Option8;
        private System.Windows.Forms.TextBox mlb_ActionLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_NPCName;
        private System.Windows.Forms.Label lbl_NPCHP;
        private System.Windows.Forms.Label lbl_NPCGender;
        private System.Windows.Forms.Label lbl_NPCHumour;
        private System.Windows.Forms.Label lbl_NPSLastAct;
        private System.Windows.Forms.TextBox tb_NPCName;
        private System.Windows.Forms.TextBox tb_NPCHP;
        private System.Windows.Forms.TextBox tb_NPCGender;
        private System.Windows.Forms.TextBox tb_NPCHumour;
        private System.Windows.Forms.TextBox tb_NPCLastAct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}