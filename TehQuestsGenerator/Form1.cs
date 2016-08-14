using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TehQuestsGenerator
{
    public partial class Form1 : Form
    {
        public static QuestList questList = new QuestList();
        public static LinkList linkList = new LinkList();

        public Form1()
        {
            InitializeComponent();
            DataTable linksTable = new DataTable();
        }

        private void QuestXmlPickerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "XML Files (.xml)|*.xml";
            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var filepath = System.IO.Path.GetFullPath(openDialog.FileName);
                CurrentQuestFilepath.Text = filepath;

                XmlSerializer serializer = new XmlSerializer(typeof (QuestList));
                FileStream fs = new FileStream(filepath, FileMode.Open);
                XmlReader xmlReader = XmlReader.Create(fs);
                try
                {
                    questList = (QuestList) serializer.Deserialize(xmlReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while deserializing!");
                    return;
                }
                fs.Close();

                DisplayQuest(0);
                nextButton.Enabled = true;
                PreviousButton.Enabled = true;
                ShowQuestList();
            }
        }

        private void QuestLinksPickerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "XML Files (.xml)|*.xml";
            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var filepath = System.IO.Path.GetFullPath(openDialog.FileName);
                CurrentLinksFilepath.Text = filepath;

                XmlSerializer serializer = new XmlSerializer(typeof (LinkList));
                FileStream fs = new FileStream(filepath, FileMode.Open);
                XmlReader xmlReader = XmlReader.Create(fs);
                try
                {
                    linkList = (LinkList) serializer.Deserialize(xmlReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error while deserializing!");
                    return;
                }

                DisplayLinks(true,0);
                fs.Close();
            }
        }

        private void DisplayLinks(bool all,int number)
        {
            if (all)
            {
                linksDataGridView.DataSource = linkList.Link; 
            }
            
            linksDataGridView.Show();
        }

        private void DisplayQuest(int number)
        {        
            if (number > questList.Quest.Count || number < 0) return;

            IndexBox.Text = number.ToString();

            questIdTextbox.Text = questList.Quest[number].QuestId;
            questTypeCombobox.Text = questList.Quest[number].QuestType;
            questOrderTextbox.Text = questList.Quest[number].Order;
            iconTextbox.Text = questList.Quest[number].QuestIconId;

            questTitleIdTextbox.Text = questList.Quest[number].QuestTitleId;
            questDescriptionIdTextbox.Text = questList.Quest[number].QuestDescId;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (questList.Quest[number].Objective != null)
            {
                foreach (var objective in questList.Quest[number].Objective)
                {
                    listBox1.Items.Add(objective.ObjectiveType);
                }
            }
            if (questList.Quest[number].Reward != null)
            {
                foreach (var reward in questList.Quest[number].Reward)
                {
                    listBox2.Items.Add(reward.Type);
                }
            }

            if (questList.Quest[int.Parse(IndexBox.Text)].Objective != null)
            {
                DisplayObjective(number, questList.Quest[int.Parse(IndexBox.Text)].Objective.Count - 1);
            }
            if (questList.Quest[int.Parse(IndexBox.Text)].Reward != null)
            {
                DisplayReward(number, questList.Quest[int.Parse(IndexBox.Text)].Reward.Count - 1);
            }
        }

        private void DisplayObjective(int questNumber, int number)
        {
            objectiveIndexTextbox.Text = number.ToString();
            orderTextbox.Text = questList.Quest[questNumber].Objective[number].Order;
            objectiveIdTextbox.Text = questList.Quest[questNumber].Objective[number].ObjectiveId;
            hideflag.Checked = questList.Quest[questNumber].Objective[number].Hide;
            objectiveTypeCombobox.Text = questList.Quest[questNumber].Objective[number].ObjectiveType;
            titleIdTextbox.Text = questList.Quest[questNumber].Objective[number].ObjectiveTitleId;
            descriptionIdTextbox.Text = questList.Quest[questNumber].Objective[number].ObjectiveDescId;
            lockTypeCombobox.Text = questList.Quest[questNumber].Objective[number].LockType;

            objectiveTypeCombobox_TextChanged(this, null);
        }

        private void DisplayReward(int questNumber, int number)
        {
            rewardIndexTextbox.Text = number.ToString();
            rewardTypeCombobox.Text = questList.Quest[questNumber].Reward[number].Type;
            rewardSpecTextbox.Text = questList.Quest[questNumber].Reward[number].Spec.ToString();
            rewardAmountTextbox.Text = questList.Quest[questNumber].Reward[number].RewardAmount.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int next = int.Parse(IndexBox.Text);
            if (++next < questList.Quest.Count) DisplayQuest(next++);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            int previous = int.Parse(IndexBox.Text);
            if (previous > 0) DisplayQuest(--previous);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int questNumber = int.Parse(IndexBox.Text);
            int number = listBox2.SelectedIndex;
            DisplayReward(questNumber, number);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int questNumber = int.Parse(IndexBox.Text);
            int number = listBox1.SelectedIndex;
            DisplayObjective(questNumber, number);
        }

        private void questIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].QuestId = questIdTextbox.Text;
            if (linkList.Link != null)
            {
                linksDataGridView.DataSource = filterLinks(int.Parse(questIdTextbox.Text)).Link;
                linksDataGridView.Refresh();
            }
        }

        private void questTypeCombobox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].QuestType = questTypeCombobox.Text;
        }

        private void questOrderTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Order = questOrderTextbox.Text;
        }

        private void iconTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].QuestIconId = iconTextbox.Text;
        }

        private void questTitleIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].QuestTitleId = questTitleIdTextbox.Text;
        }

        private void questDescriptionIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].QuestDescId = questDescriptionIdTextbox.Text;
        }

        private void saveQuestsButton_Click(object sender, EventArgs e)
        {
            clearUnusedQotTypes();

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML Files (.xml)|*.xml";

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("","");

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof (QuestList));
                var fileStream = File.Create(saveDialog.FileName);
                fileStream.Close();
                using (StringWriter stringWriter = new Utf8StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(stringWriter))
                    {
                        writer.WriteStartDocument(true);
                        serializer.Serialize(writer, questList,ns);
                        var xml = FormatXml(stringWriter.ToString());

                        using (StreamWriter outputFile = new StreamWriter(saveDialog.FileName, true))
                        {
                            outputFile.WriteLine(xml);
                        }
                    }
                }
            }
        }

        private string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                return xml;
            }
        }

        private void clearUnusedQotTypes()
        {
            foreach (var quest in questList.Quest)
            {
                foreach (var objective in quest.Objective)
                {
                    switch (objective.ObjectiveType)
                    {
                        case "OBJECTIVE_TASK_BUILD":
                            //objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_COLLECT_RESOURCES":
                            objective.QOTBuildData = null;
                            //objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_UPGRADE_BUILDING":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            //objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_HIRE_UNITS":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            //objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_RESEARCH":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            //objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_CRAFT_BUILDING":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            //objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_CRAFT_CAMP":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            //objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_WIN_LOCATION":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            //objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_KILL_PVE":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            objective.QOTUseItem = null;
                            break;
                        case "OBJECTIVE_TASK_USE_ITEM":
                            objective.QOTBuildData = null;
                            objective.QOTCollectResourceData = null;
                            objective.QOTUpgradeBuilding = null;
                            objective.QOTHireUnitsData = null;
                            objective.QOTResearch = null;
                            objective.QOTCraftBuilding = null;
                            objective.QOTCraftCamp = null;
                            objective.QOTWinLocation = null;
                            //objective.QOTUseItem = null;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Quest quest = new Quest();
            questList.Quest.Add(quest);
            int maxIndex = questList.Quest.Count-1;
            DisplayQuest(maxIndex);
            ShowQuestList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questList.Quest = new List<Quest>();
        }

        private void NewRewardButton_Click(object sender, EventArgs e)
        {
            Reward reward = new Reward();
            reward.Type = "OT_ITEM";

            if (questList.Quest[int.Parse(IndexBox.Text)].Reward == null)
            {
                questList.Quest[int.Parse(IndexBox.Text)].Reward = new List<Reward>();
            }
            questList.Quest[int.Parse(IndexBox.Text)].Reward.Add(reward);
            DisplayQuest(int.Parse(IndexBox.Text));
        }

        private void newObjectiveButton_Click(object sender, EventArgs e)
        {
            Objective objective = new Objective();
            objective.ObjectiveType = "OBJECTIVE_TASK_BUILD";
            objective.Hide = false;
            objective.LockType = "QUESTLOCK_GENERIC";

            if (questList.Quest[int.Parse(IndexBox.Text)].Objective == null)
            {
                questList.Quest[int.Parse(IndexBox.Text)].Objective = new List<Objective>();
            }
            questList.Quest[int.Parse(IndexBox.Text)].Objective.Add(objective);
            DisplayQuest(int.Parse(IndexBox.Text));
        }

        private void deleteRewardButton_Click(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Reward.RemoveAt(int.Parse(rewardIndexTextbox.Text));
            DisplayQuest(int.Parse(IndexBox.Text));
        }

        private void deleteObjectiveButton_Click(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective.RemoveAt(int.Parse(objectiveIndexTextbox.Text));
            DisplayQuest(int.Parse(IndexBox.Text));
        }

        private void EnableMetadata(string questObjectiveType)
        {
            switch (questObjectiveType)
            {
                case "OBJECTIVE_TASK_BUILD":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new BuildControl() {Location = new Point(10,20)});
                    var buildControl = groupBox4.Controls[0] as BuildControl;
                    buildControl.buildingTypeIdTextBox.TextChanged += this.updateBuildingTypeId;
                    buildControl.countTextBox.TextChanged += this.updateBuildingCount;
                    buildControl.counterTypeComboBox.TextChanged += updateBuildingCounterType; 
                    break;
                case "OBJECTIVE_TASK_COLLECT_RESOURCES":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CollectResourcesControl() {Location = new Point(10,20)});
                    var collectResourcesControl = groupBox4.Controls[0] as CollectResourcesControl;
                    collectResourcesControl.resTextBox.TextChanged += updateResTypeId;
                    collectResourcesControl.countTextBox.TextChanged += updateResCount;
                    collectResourcesControl.counterTypeComboBox.TextChanged += updateResCounterType;
                    break;
                case "OBJECTIVE_TASK_UPGRADE_BUILDING":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new UpgradeControl() { Location = new Point(10, 20) });
                    var upgradeBuildingControl = groupBox4.Controls[0] as UpgradeControl;
                    upgradeBuildingControl.buildingTypeIdTextBox.TextChanged += updateUpgradeBuildingTypeId;
                    upgradeBuildingControl.upgradeLevelTextBox.TextChanged += updateUpgradeLevel;
                    break;
                case "OBJECTIVE_TASK_HIRE_UNITS":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new HireControl() { Location = new Point(10, 20) });
                    var hireControl = groupBox4.Controls[0] as HireControl;
                    hireControl.unitTypeIdTextBox.TextChanged += updateHireUnitTypeId;
                    hireControl.countTextBox.TextChanged += updateHireCount;
                    hireControl.counterTypeComboBox.TextChanged += updateHireCounterType;
                    break;
                case "OBJECTIVE_TASK_RESEARCH":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new LearnControl() { Location = new Point(10, 20) });
                    var researchControl = groupBox4.Controls[0] as LearnControl;
                    researchControl.knowledgeTypeIdTextBox.TextChanged += updateResearchKnowledgeTypeId;
                    researchControl.levelTextBox.TextChanged += updateResearchKnowledgeLevel;
                    break;
                case "OBJECTIVE_TASK_CRAFT_BUILDING":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CraftCityControl() { Location = new Point(10, 20) });
                    var craftBuildingControl = groupBox4.Controls[0] as CraftCityControl;
                    craftBuildingControl.craftIdsListBox.TextChanged += updateCraftCityIdsList;
                    craftBuildingControl.countTextBox.TextChanged += updateCraftCityCount;
                    break;
                case "OBJECTIVE_TASK_CRAFT_CAMP":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CraftCampControl() { Location = new Point(10, 20) });
                    var craftCampControl = groupBox4.Controls[0] as CraftCampControl;
                    craftCampControl.craftIdsLlistBox.TextChanged += updateCraftCampIdsList;
                    craftCampControl.countTextBox.TextChanged += updateCraftCampCount;
                    break;
                case "OBJECTIVE_TASK_WIN_LOCATION":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new WinPveControl() { Location = new Point(10, 20) });
                    var winControl = groupBox4.Controls[0] as WinPveControl;
                    winControl.locationsListBox.TextChanged += updateWinPveLocationIdsList;
                    winControl.countTextBox.TextChanged += updateWinPveCount;
                    break;
                case "OBJECTIVE_TASK_KILL_PVE":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new KillController() { Location = new Point(10, 20) });
                    var killPveControl = groupBox4.Controls[0] as KillController;
                    killPveControl.killPveListBox.TextChanged += updateKillPveIdsList;
                    killPveControl.countTextBox.TextChanged += updateKillPveCount;
                    break;
                case "OBJECTIVE_TASK_USE_ITEM":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new UseItemController() { Location = new Point(10, 20) });
                    var useItemControl = groupBox4.Controls[0] as UseItemController;
                    useItemControl.itemIdsListBox.TextChanged += updateUseItemIdsList;
                    useItemControl.countTextBox.TextChanged += updateUseItemCount;
                    break;
                default:
                    //MessageBox.Show("The assigned objective type is not yet supported");
                    return;
            }      
        }

        private void objectiveTypeCombobox_TextChanged(object sender, EventArgs e)
        {
            EnableMetadata(objectiveTypeCombobox.Text);
            var questObjective = questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)];

            questObjective.ObjectiveType = objectiveTypeCombobox.Text;

            switch (objectiveTypeCombobox.Text)
            {
                case "OBJECTIVE_TASK_BUILD":
                    if (questObjective.QOTBuildData==null) questObjective.QOTBuildData = new QOTBuildData();
                    (groupBox4.Controls[0] as BuildControl).buildingTypeIdTextBox.Text =
                        questObjective.QOTBuildData.BuildingTypeId.ToString();
                    (groupBox4.Controls[0] as BuildControl).countTextBox.Text =
                        questObjective.QOTBuildData.Count.ToString();
                    (groupBox4.Controls[0] as BuildControl).counterTypeComboBox.Text =
                        questObjective.QOTBuildData.CounterType;
                    break;
                case "OBJECTIVE_TASK_COLLECT_RESOURCES":
                    if (questObjective.QOTCollectResourceData == null) questObjective.QOTCollectResourceData = new QOTCollectResourceData();
                    (groupBox4.Controls[0] as CollectResourcesControl).resTextBox.Text =
                        questObjective.QOTCollectResourceData.Res;
                    (groupBox4.Controls[0] as CollectResourcesControl).countTextBox.Text =
                        questObjective.QOTCollectResourceData.Count.ToString();
                    (groupBox4.Controls[0] as CollectResourcesControl).counterTypeComboBox.Text =
                        questObjective.QOTCollectResourceData.CounterType;
                    break;
                case "OBJECTIVE_TASK_UPGRADE_BUILDING":
                    if (questObjective.QOTUpgradeBuilding == null) questObjective.QOTUpgradeBuilding = new QOTUpgradeBuilding();
                    (groupBox4.Controls[0] as UpgradeControl).buildingTypeIdTextBox.Text =
                        questObjective.QOTUpgradeBuilding.BuildingTypeId.ToString();
                    (groupBox4.Controls[0] as UpgradeControl).upgradeLevelTextBox.Text =
                        questObjective.QOTUpgradeBuilding.Level.ToString();
                    break;
                case "OBJECTIVE_TASK_HIRE_UNITS":
                    if (questObjective.QOTHireUnitsData == null) questObjective.QOTHireUnitsData = new QOTHireUnitsData();
                    (groupBox4.Controls[0] as HireControl).unitTypeIdTextBox.Text =
                        questObjective.QOTHireUnitsData.UnitTypeId.ToString();
                    (groupBox4.Controls[0] as HireControl).countTextBox.Text =
                        questObjective.QOTHireUnitsData.Count.ToString();
                    (groupBox4.Controls[0] as HireControl).counterTypeComboBox.Text =
                        questObjective.QOTHireUnitsData.CounterType;
                    break;
                case "OBJECTIVE_TASK_RESEARCH":
                    if (questObjective.QOTResearch == null) questObjective.QOTResearch = new QOTResearch();
                    (groupBox4.Controls[0] as LearnControl).knowledgeTypeIdTextBox.Text =
                        questObjective.QOTResearch.KnowledgeTypeId.ToString();
                    (groupBox4.Controls[0] as LearnControl).levelTextBox.Text =
                        questObjective.QOTResearch.Level.ToString();
                    break;
                case "OBJECTIVE_TASK_CRAFT_BUILDING":
                    if (questObjective.QOTCraftBuilding == null)
                    {
                        questObjective.QOTCraftBuilding = new QOTCraftBuilding();
                        questObjective.QOTCraftBuilding.Crafts = new Crafts();
                        questObjective.QOTCraftBuilding.Crafts.CraftTypeId = new List<string>();
                    }
                    (groupBox4.Controls[0] as CraftCityControl).countTextBox.Text =
                        questObjective.QOTCraftBuilding.Count.ToString();
                    foreach (var craft in questObjective.QOTCraftBuilding.Crafts.CraftTypeId)
                    {
                        (groupBox4.Controls[0] as CraftCityControl).craftIdsListBox.Items.Add(craft);
                    }
                    break;
                case "OBJECTIVE_TASK_CRAFT_CAMP":
                    if (questObjective.QOTCraftCamp == null)
                    {
                        questObjective.QOTCraftCamp = new QOTCraftCamp();
                        questObjective.QOTCraftCamp.Crafts = new Crafts();
                        questObjective.QOTCraftCamp.Crafts.CraftTypeId = new List<string>();
                    }
                    (groupBox4.Controls[0] as CraftCampControl).countTextBox.Text =
                        questObjective.QOTCraftCamp.Count.ToString();
                    foreach (var craft in questObjective.QOTCraftCamp.Crafts.CraftTypeId)
                    {
                        (groupBox4.Controls[0] as CraftCampControl).craftIdsLlistBox.Items.Add(craft);
                    }
                    break;
                case "OBJECTIVE_TASK_WIN_LOCATION":
                    if (questObjective.QOTWinLocation == null)
                    {
                        questObjective.QOTWinLocation = new QOTWinLocation();
                        questObjective.QOTWinLocation.Locations = new Locations();
                        questObjective.QOTWinLocation.Locations.Location = new List<string>();
                    }
                    (groupBox4.Controls[0] as WinPveControl).countTextBox.Text =
                        questObjective.QOTWinLocation.Count.ToString();
                    foreach (var location in questObjective.QOTWinLocation.Locations.Location)
                    {
                        (groupBox4.Controls[0] as WinPveControl).locationsListBox.Items.Add(location);
                    }
                    break;
                case "OBJECTIVE_TASK_KILL_PVE":
                    //questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                    break;
                case "OBJECTIVE_TASK_USE_ITEM":
                    if (questObjective.QOTUseItem == null)
                    {
                        questObjective.QOTUseItem = new QOTUseItem();
                        questObjective.QOTUseItem.Items = new Items();
                        questObjective.QOTUseItem.Items.Item = new List<string>();
                    }
                    (groupBox4.Controls[0] as UseItemController).countTextBox.Text =
                        questObjective.QOTUseItem.Count.ToString();
                    foreach (var item in questObjective.QOTUseItem.Items.Item)
                    {
                        (groupBox4.Controls[0] as UseItemController).itemIdsListBox.Items.Add(item);
                    }
                    break;
                default:
                    //MessageBox.Show("The assigned objective type is not yet supported");
                    return;
            }
        }

        private void orderTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].Order =
                orderTextbox.Text;
        }

        private void objectiveIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].ObjectiveId =
                objectiveIdTextbox.Text;
        }

        private void hideflag_CheckedChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].Hide =
                hideflag.Checked;
        }

        private void lockTypeCombobox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].LockType =
                lockTypeCombobox.Text;
        }

        private void titleIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].ObjectiveTitleId =
                titleIdTextbox.Text;
        }

        private void descriptionIdTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].ObjectiveDescId =
                descriptionIdTextbox.Text;
        }

        private void rewardTypeCombobox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Reward[int.Parse(rewardIndexTextbox.Text)].Type =
                rewardTypeCombobox.Text;
        }

        private void rewardSpecTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Reward[int.Parse(rewardIndexTextbox.Text)].Spec =
                int.Parse(rewardSpecTextbox.Text);
        }

        private void rewardAmountTextbox_TextChanged(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Reward[int.Parse(rewardIndexTextbox.Text)].RewardAmount =
                int.Parse(rewardAmountTextbox.Text);
        }

        private void updateKillPveIdsList(object sender, EventArgs e)
        {
            Locations idsList = new Locations();
            //locationsList.Location = new List<string>();

            foreach (var locationId in (groupBox4.Controls[0] as KillController).killPveListBox.Items)
            {
                //locationsList.Location.Add(locationId.ToString());
            }
           // questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
               // .QOTWinLocation.Locations = locationsList;
        }

        private void updateKillPveCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTWinLocation.Count = int.Parse((groupBox4.Controls[0] as KillController).countTextBox.Text);
        }

        private void updateUseItemIdsList(object sender, EventArgs e)
        {
            Items idsList = new Items();
            idsList.Item = new List<string>();

            foreach (var locationId in (groupBox4.Controls[0] as UseItemController).itemIdsListBox.Items)
            {
                idsList.Item.Add(locationId.ToString());
            }
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].QOTUseItem.Items = idsList;
        }

        private void updateUseItemCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTUseItem.Count = int.Parse((groupBox4.Controls[0] as UseItemController).countTextBox.Text);
        }

        private void questIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void questOrderTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void questTitleIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void questDescriptionIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void objectiveIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void orderTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void titleIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void descriptionIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void rewardSpecTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void rewardAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private LinkList filterLinks(int questId)
        {
            LinkList filteredLinkList = new LinkList();
            filteredLinkList.Link = new List<Link>();

            foreach (var link in linkList.Link)
            {
                if (link.LinkFromId == questId || link.LinkToId == questId)
                {
                    Link newLink = new Link();

                    newLink.LinkFromId = link.LinkFromId;
                    newLink.LinkToId = link.LinkToId;
                    newLink.LinkId = link.LinkId;
                    newLink.LinkType = link.LinkType;
                    newLink.TriggerType = link.TriggerType;

                    filteredLinkList.Link.Add(newLink);
                }
            }

            return filteredLinkList;
        }

        private void ShowQuestList()
        {
            questListBox.Items.Clear();
            foreach (var quest in questList.Quest)
            {
                questListBox.Items.Add(quest.QuestId);
            }
        }

        private void questListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayQuest(questListBox.SelectedIndex);
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
