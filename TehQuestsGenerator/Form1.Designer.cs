namespace TehQuestsGenerator
{
    partial class Form1
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
            this.QuestXmlPickerButton = new System.Windows.Forms.Button();
            this.QuestLinksPickerButton = new System.Windows.Forms.Button();
            this.CurrentQuestFilepath = new System.Windows.Forms.Label();
            this.CurrentLinksFilepath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveQuestsButton = new System.Windows.Forms.Button();
            this.NewRewardButton = new System.Windows.Forms.Button();
            this.newObjectiveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.questDescriptionIdTextbox = new System.Windows.Forms.TextBox();
            this.questTitleIdTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteRewardButton = new System.Windows.Forms.Button();
            this.rewardIndexTextbox = new System.Windows.Forms.TextBox();
            this.rewardTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.rewardAmountTextbox = new System.Windows.Forms.TextBox();
            this.rewardSpecTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteObjectiveButton = new System.Windows.Forms.Button();
            this.objectiveIndexTextbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lockTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.hideflag = new System.Windows.Forms.CheckBox();
            this.objectiveIdTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.descriptionIdTextbox = new System.Windows.Forms.TextBox();
            this.titleIdTextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.objectiveTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.orderTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconTextbox = new System.Windows.Forms.TextBox();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.questTypeCombobox = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.questOrderTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveLinksButton = new System.Windows.Forms.Button();
            this.linksDataGridView = new System.Windows.Forms.DataGridView();
            this.questListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestXmlPickerButton
            // 
            this.QuestXmlPickerButton.Location = new System.Drawing.Point(106, 12);
            this.QuestXmlPickerButton.Name = "QuestXmlPickerButton";
            this.QuestXmlPickerButton.Size = new System.Drawing.Size(104, 23);
            this.QuestXmlPickerButton.TabIndex = 0;
            this.QuestXmlPickerButton.Text = "Pick quests XML";
            this.QuestXmlPickerButton.UseVisualStyleBackColor = true;
            this.QuestXmlPickerButton.Click += new System.EventHandler(this.QuestXmlPickerButton_Click);
            // 
            // QuestLinksPickerButton
            // 
            this.QuestLinksPickerButton.Location = new System.Drawing.Point(106, 41);
            this.QuestLinksPickerButton.Name = "QuestLinksPickerButton";
            this.QuestLinksPickerButton.Size = new System.Drawing.Size(104, 23);
            this.QuestLinksPickerButton.TabIndex = 1;
            this.QuestLinksPickerButton.Text = "Pick links XML";
            this.QuestLinksPickerButton.UseVisualStyleBackColor = true;
            this.QuestLinksPickerButton.Click += new System.EventHandler(this.QuestLinksPickerButton_Click);
            // 
            // CurrentQuestFilepath
            // 
            this.CurrentQuestFilepath.AutoSize = true;
            this.CurrentQuestFilepath.Location = new System.Drawing.Point(225, 17);
            this.CurrentQuestFilepath.Name = "CurrentQuestFilepath";
            this.CurrentQuestFilepath.Size = new System.Drawing.Size(100, 13);
            this.CurrentQuestFilepath.TabIndex = 2;
            this.CurrentQuestFilepath.Text = "FILE NOT PICKED!";
            // 
            // CurrentLinksFilepath
            // 
            this.CurrentLinksFilepath.AutoSize = true;
            this.CurrentLinksFilepath.Location = new System.Drawing.Point(225, 46);
            this.CurrentLinksFilepath.Name = "CurrentLinksFilepath";
            this.CurrentLinksFilepath.Size = new System.Drawing.Size(100, 13);
            this.CurrentLinksFilepath.TabIndex = 3;
            this.CurrentLinksFilepath.Text = "FILE NOT PICKED!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveQuestsButton);
            this.groupBox1.Controls.Add(this.NewRewardButton);
            this.groupBox1.Controls.Add(this.newObjectiveButton);
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.questDescriptionIdTextbox);
            this.groupBox1.Controls.Add(this.questTitleIdTextbox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.groupbox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.iconTextbox);
            this.groupBox1.Controls.Add(this.IndexBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.questTypeCombobox);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.PreviousButton);
            this.groupBox1.Controls.Add(this.questOrderTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.questIdTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quest";
            // 
            // saveQuestsButton
            // 
            this.saveQuestsButton.Location = new System.Drawing.Point(9, 254);
            this.saveQuestsButton.Name = "saveQuestsButton";
            this.saveQuestsButton.Size = new System.Drawing.Size(72, 52);
            this.saveQuestsButton.TabIndex = 6;
            this.saveQuestsButton.Text = "SAVE QUEST CHANGES";
            this.saveQuestsButton.UseVisualStyleBackColor = true;
            this.saveQuestsButton.Click += new System.EventHandler(this.saveQuestsButton_Click);
            // 
            // NewRewardButton
            // 
            this.NewRewardButton.Location = new System.Drawing.Point(395, 153);
            this.NewRewardButton.Name = "NewRewardButton";
            this.NewRewardButton.Size = new System.Drawing.Size(75, 25);
            this.NewRewardButton.TabIndex = 24;
            this.NewRewardButton.Text = "new";
            this.NewRewardButton.UseVisualStyleBackColor = true;
            this.NewRewardButton.Click += new System.EventHandler(this.NewRewardButton_Click);
            // 
            // newObjectiveButton
            // 
            this.newObjectiveButton.Location = new System.Drawing.Point(395, 13);
            this.newObjectiveButton.Name = "newObjectiveButton";
            this.newObjectiveButton.Size = new System.Drawing.Size(75, 25);
            this.newObjectiveButton.TabIndex = 6;
            this.newObjectiveButton.Text = "new";
            this.newObjectiveButton.UseVisualStyleBackColor = true;
            this.newObjectiveButton.Click += new System.EventHandler(this.newObjectiveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(166, 220);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(73, 28);
            this.newButton.TabIndex = 23;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "DescriptionId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "TitleID";
            // 
            // questDescriptionIdTextbox
            // 
            this.questDescriptionIdTextbox.Location = new System.Drawing.Point(79, 194);
            this.questDescriptionIdTextbox.Name = "questDescriptionIdTextbox";
            this.questDescriptionIdTextbox.Size = new System.Drawing.Size(150, 20);
            this.questDescriptionIdTextbox.TabIndex = 20;
            this.questDescriptionIdTextbox.TextChanged += new System.EventHandler(this.questDescriptionIdTextbox_TextChanged);
            this.questDescriptionIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questDescriptionIdTextbox_KeyPress);
            // 
            // questTitleIdTextbox
            // 
            this.questTitleIdTextbox.Location = new System.Drawing.Point(71, 168);
            this.questTitleIdTextbox.Name = "questTitleIdTextbox";
            this.questTitleIdTextbox.Size = new System.Drawing.Size(158, 20);
            this.questTitleIdTextbox.TabIndex = 19;
            this.questTitleIdTextbox.TextChanged += new System.EventHandler(this.questTitleIdTextbox_TextChanged);
            this.questTitleIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questTitleIdTextbox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteRewardButton);
            this.groupBox3.Controls.Add(this.rewardIndexTextbox);
            this.groupBox3.Controls.Add(this.rewardTypeCombobox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.rewardAmountTextbox);
            this.groupBox3.Controls.Add(this.rewardSpecTextbox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(476, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reward";
            // 
            // deleteRewardButton
            // 
            this.deleteRewardButton.Location = new System.Drawing.Point(359, 38);
            this.deleteRewardButton.Name = "deleteRewardButton";
            this.deleteRewardButton.Size = new System.Drawing.Size(75, 25);
            this.deleteRewardButton.TabIndex = 26;
            this.deleteRewardButton.Text = "delete";
            this.deleteRewardButton.UseVisualStyleBackColor = true;
            this.deleteRewardButton.Click += new System.EventHandler(this.deleteRewardButton_Click);
            // 
            // rewardIndexTextbox
            // 
            this.rewardIndexTextbox.Location = new System.Drawing.Point(87, 15);
            this.rewardIndexTextbox.Name = "rewardIndexTextbox";
            this.rewardIndexTextbox.ReadOnly = true;
            this.rewardIndexTextbox.Size = new System.Drawing.Size(49, 20);
            this.rewardIndexTextbox.TabIndex = 25;
            // 
            // rewardTypeCombobox
            // 
            this.rewardTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardTypeCombobox.FormattingEnabled = true;
            this.rewardTypeCombobox.Items.AddRange(new object[] {
            "OT_ITEM",
            "OT_RESOURCE",
            "OT_UNIT"});
            this.rewardTypeCombobox.Location = new System.Drawing.Point(232, 15);
            this.rewardTypeCombobox.Name = "rewardTypeCombobox";
            this.rewardTypeCombobox.Size = new System.Drawing.Size(121, 21);
            this.rewardTypeCombobox.TabIndex = 5;
            this.rewardTypeCombobox.TextChanged += new System.EventHandler(this.rewardTypeCombobox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Current index:";
            // 
            // rewardAmountTextbox
            // 
            this.rewardAmountTextbox.Location = new System.Drawing.Point(232, 41);
            this.rewardAmountTextbox.Name = "rewardAmountTextbox";
            this.rewardAmountTextbox.Size = new System.Drawing.Size(121, 20);
            this.rewardAmountTextbox.TabIndex = 4;
            this.rewardAmountTextbox.TextChanged += new System.EventHandler(this.rewardAmountTextbox_TextChanged);
            this.rewardAmountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rewardAmountTextbox_KeyPress);
            // 
            // rewardSpecTextbox
            // 
            this.rewardSpecTextbox.Location = new System.Drawing.Point(55, 41);
            this.rewardSpecTextbox.Name = "rewardSpecTextbox";
            this.rewardSpecTextbox.Size = new System.Drawing.Size(121, 20);
            this.rewardSpecTextbox.TabIndex = 3;
            this.rewardSpecTextbox.TextChanged += new System.EventHandler(this.rewardSpecTextbox_TextChanged);
            this.rewardSpecTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rewardSpecTextbox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "spec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "type";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(247, 184);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(223, 95);
            this.listBox2.TabIndex = 17;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rewards list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Objectives list";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(247, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 108);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.groupBox4);
            this.groupbox2.Controls.Add(this.deleteObjectiveButton);
            this.groupbox2.Controls.Add(this.objectiveIndexTextbox);
            this.groupbox2.Controls.Add(this.label19);
            this.groupbox2.Controls.Add(this.lockTypeCombobox);
            this.groupbox2.Controls.Add(this.label18);
            this.groupbox2.Controls.Add(this.hideflag);
            this.groupbox2.Controls.Add(this.objectiveIdTextbox);
            this.groupbox2.Controls.Add(this.label14);
            this.groupbox2.Controls.Add(this.descriptionIdTextbox);
            this.groupbox2.Controls.Add(this.titleIdTextbox);
            this.groupbox2.Controls.Add(this.label17);
            this.groupbox2.Controls.Add(this.label16);
            this.groupbox2.Controls.Add(this.objectiveTypeCombobox);
            this.groupbox2.Controls.Add(this.label15);
            this.groupbox2.Controls.Add(this.orderTextbox);
            this.groupbox2.Controls.Add(this.label13);
            this.groupbox2.Location = new System.Drawing.Point(476, 13);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(444, 268);
            this.groupbox2.TabIndex = 13;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Objective";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 125);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "attributes";
            // 
            // deleteObjectiveButton
            // 
            this.deleteObjectiveButton.Location = new System.Drawing.Point(363, 98);
            this.deleteObjectiveButton.Name = "deleteObjectiveButton";
            this.deleteObjectiveButton.Size = new System.Drawing.Size(75, 25);
            this.deleteObjectiveButton.TabIndex = 25;
            this.deleteObjectiveButton.Text = "delete";
            this.deleteObjectiveButton.UseVisualStyleBackColor = true;
            this.deleteObjectiveButton.Click += new System.EventHandler(this.deleteObjectiveButton_Click);
            // 
            // objectiveIndexTextbox
            // 
            this.objectiveIndexTextbox.Location = new System.Drawing.Point(87, 13);
            this.objectiveIndexTextbox.Name = "objectiveIndexTextbox";
            this.objectiveIndexTextbox.ReadOnly = true;
            this.objectiveIndexTextbox.Size = new System.Drawing.Size(49, 20);
            this.objectiveIndexTextbox.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Current index:";
            // 
            // lockTypeCombobox
            // 
            this.lockTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lockTypeCombobox.FormattingEnabled = true;
            this.lockTypeCombobox.Items.AddRange(new object[] {
            "QUESTLOCK_HARD",
            "QUESTLOCK_SOFT",
            "QUESTLOCK_GUIDELINE",
            "QUESTLOCK_GENERIC"});
            this.lockTypeCombobox.Location = new System.Drawing.Point(221, 34);
            this.lockTypeCombobox.Name = "lockTypeCombobox";
            this.lockTypeCombobox.Size = new System.Drawing.Size(195, 21);
            this.lockTypeCombobox.TabIndex = 12;
            this.lockTypeCombobox.TextChanged += new System.EventHandler(this.lockTypeCombobox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(161, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "LockType";
            // 
            // hideflag
            // 
            this.hideflag.AutoSize = true;
            this.hideflag.Location = new System.Drawing.Point(319, 15);
            this.hideflag.Name = "hideflag";
            this.hideflag.Size = new System.Drawing.Size(75, 17);
            this.hideflag.TabIndex = 10;
            this.hideflag.Text = "Is hidden?";
            this.hideflag.UseVisualStyleBackColor = true;
            this.hideflag.CheckedChanged += new System.EventHandler(this.hideflag_CheckedChanged);
            // 
            // objectiveIdTextbox
            // 
            this.objectiveIdTextbox.Location = new System.Drawing.Point(213, 13);
            this.objectiveIdTextbox.Name = "objectiveIdTextbox";
            this.objectiveIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.objectiveIdTextbox.TabIndex = 3;
            this.objectiveIdTextbox.TextChanged += new System.EventHandler(this.objectiveIdTextbox_TextChanged);
            this.objectiveIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.objectiveIdTextbox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "objectiveId";
            // 
            // descriptionIdTextbox
            // 
            this.descriptionIdTextbox.Location = new System.Drawing.Point(76, 105);
            this.descriptionIdTextbox.Name = "descriptionIdTextbox";
            this.descriptionIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.descriptionIdTextbox.TabIndex = 9;
            this.descriptionIdTextbox.TextChanged += new System.EventHandler(this.descriptionIdTextbox_TextChanged);
            this.descriptionIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptionIdTextbox_KeyPress);
            // 
            // titleIdTextbox
            // 
            this.titleIdTextbox.Location = new System.Drawing.Point(76, 82);
            this.titleIdTextbox.Name = "titleIdTextbox";
            this.titleIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.titleIdTextbox.TabIndex = 8;
            this.titleIdTextbox.TextChanged += new System.EventHandler(this.titleIdTextbox_TextChanged);
            this.titleIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titleIdTextbox_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "DescriptionID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "titleID";
            // 
            // objectiveTypeCombobox
            // 
            this.objectiveTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectiveTypeCombobox.FormattingEnabled = true;
            this.objectiveTypeCombobox.Items.AddRange(new object[] {
            "OBJECTIVE_TASK_BUILD",
            "OBJECTIVE_TASK_COLLECT_RESOURCES",
            "OBJECTIVE_TASK_CRAFT_BUILDING",
            "OBJECTIVE_TASK_CRAFT_CAMP",
            "OBJECTIVE_TASK_HIRE_UNITS",
            "OBJECTIVE_TASK_RESEARCH",
            "OBJECTIVE_TASK_KILL_PVE",
            "OBJECTIVE_TASK_UPGRADE_BUILDING",
            "OBJECTIVE_TASK_USE_ITEM",
            "OBJECTIVE_TASK_WIN_LOCATION"});
            this.objectiveTypeCombobox.Location = new System.Drawing.Point(98, 58);
            this.objectiveTypeCombobox.Name = "objectiveTypeCombobox";
            this.objectiveTypeCombobox.Size = new System.Drawing.Size(268, 21);
            this.objectiveTypeCombobox.TabIndex = 5;
            this.objectiveTypeCombobox.TextChanged += new System.EventHandler(this.objectiveTypeCombobox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "objectiveType";
            // 
            // orderTextbox
            // 
            this.orderTextbox.Location = new System.Drawing.Point(55, 35);
            this.orderTextbox.Name = "orderTextbox";
            this.orderTextbox.Size = new System.Drawing.Size(100, 20);
            this.orderTextbox.TabIndex = 1;
            this.orderTextbox.TextChanged += new System.EventHandler(this.orderTextbox_TextChanged);
            this.orderTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderTextbox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "icon";
            // 
            // iconTextbox
            // 
            this.iconTextbox.Location = new System.Drawing.Point(71, 114);
            this.iconTextbox.Name = "iconTextbox";
            this.iconTextbox.Size = new System.Drawing.Size(158, 20);
            this.iconTextbox.TabIndex = 11;
            this.iconTextbox.TextChanged += new System.EventHandler(this.iconTextbox_TextChanged);
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(84, 13);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.ReadOnly = true;
            this.IndexBox.Size = new System.Drawing.Size(53, 20);
            this.IndexBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current index:";
            // 
            // questTypeCombobox
            // 
            this.questTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questTypeCombobox.FormattingEnabled = true;
            this.questTypeCombobox.Items.AddRange(new object[] {
            "QUEST_STORY_LINE",
            "QUEST_COMMON",
            "QUEST_PERIODIC"});
            this.questTypeCombobox.Location = new System.Drawing.Point(71, 68);
            this.questTypeCombobox.Name = "questTypeCombobox";
            this.questTypeCombobox.Size = new System.Drawing.Size(158, 21);
            this.questTypeCombobox.TabIndex = 8;
            this.questTypeCombobox.TextChanged += new System.EventHandler(this.questTypeCombobox_TextChanged);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(87, 220);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(73, 28);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Location = new System.Drawing.Point(9, 220);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(72, 28);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // questOrderTextbox
            // 
            this.questOrderTextbox.Location = new System.Drawing.Point(71, 91);
            this.questOrderTextbox.Name = "questOrderTextbox";
            this.questOrderTextbox.Size = new System.Drawing.Size(158, 20);
            this.questOrderTextbox.TabIndex = 5;
            this.questOrderTextbox.TextChanged += new System.EventHandler(this.questOrderTextbox_TextChanged);
            this.questOrderTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questOrderTextbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "QuestOrder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QuestType";
            // 
            // questIdTextbox
            // 
            this.questIdTextbox.Location = new System.Drawing.Point(71, 44);
            this.questIdTextbox.Name = "questIdTextbox";
            this.questIdTextbox.Size = new System.Drawing.Size(158, 20);
            this.questIdTextbox.TabIndex = 1;
            this.questIdTextbox.TextChanged += new System.EventHandler(this.questIdTextbox_TextChanged);
            this.questIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questIdTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuestId";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saveLinksButton);
            this.groupBox5.Controls.Add(this.linksDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(106, 432);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(926, 187);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quest links";
            // 
            // saveLinksButton
            // 
            this.saveLinksButton.Location = new System.Drawing.Point(640, 20);
            this.saveLinksButton.Name = "saveLinksButton";
            this.saveLinksButton.Size = new System.Drawing.Size(75, 47);
            this.saveLinksButton.TabIndex = 1;
            this.saveLinksButton.Text = "SAVE LINK CHANGES";
            this.saveLinksButton.UseVisualStyleBackColor = true;
            // 
            // linksDataGridView
            // 
            this.linksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.linksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linksDataGridView.Location = new System.Drawing.Point(6, 20);
            this.linksDataGridView.Name = "linksDataGridView";
            this.linksDataGridView.Size = new System.Drawing.Size(625, 161);
            this.linksDataGridView.TabIndex = 0;
            // 
            // questListBox
            // 
            this.questListBox.FormattingEnabled = true;
            this.questListBox.Location = new System.Drawing.Point(4, 13);
            this.questListBox.Name = "questListBox";
            this.questListBox.Size = new System.Drawing.Size(97, 602);
            this.questListBox.TabIndex = 25;
            this.questListBox.SelectedIndexChanged += new System.EventHandler(this.questListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 631);
            this.Controls.Add(this.questListBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentLinksFilepath);
            this.Controls.Add(this.CurrentQuestFilepath);
            this.Controls.Add(this.QuestLinksPickerButton);
            this.Controls.Add(this.QuestXmlPickerButton);
            this.MinimumSize = new System.Drawing.Size(964, 670);
            this.Name = "Form1";
            this.Text = "Citadels Quest Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuestXmlPickerButton;
        private System.Windows.Forms.Button QuestLinksPickerButton;
        private System.Windows.Forms.Label CurrentQuestFilepath;
        private System.Windows.Forms.Label CurrentLinksFilepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.TextBox questOrderTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questIdTextbox;
        private System.Windows.Forms.ComboBox questTypeCombobox;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iconTextbox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox rewardTypeCombobox;
        private System.Windows.Forms.TextBox rewardAmountTextbox;
        private System.Windows.Forms.TextBox rewardSpecTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox questDescriptionIdTextbox;
        private System.Windows.Forms.TextBox questTitleIdTextbox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ComboBox lockTypeCombobox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox hideflag;
        private System.Windows.Forms.TextBox descriptionIdTextbox;
        private System.Windows.Forms.TextBox titleIdTextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox objectiveTypeCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox objectiveIdTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox orderTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rewardIndexTextbox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox objectiveIndexTextbox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button newObjectiveButton;
        private System.Windows.Forms.Button NewRewardButton;
        private System.Windows.Forms.Button deleteObjectiveButton;
        private System.Windows.Forms.Button saveQuestsButton;
        private System.Windows.Forms.Button deleteRewardButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView linksDataGridView;
        private System.Windows.Forms.Button saveLinksButton;
        private System.Windows.Forms.ListBox questListBox;
    }
}

