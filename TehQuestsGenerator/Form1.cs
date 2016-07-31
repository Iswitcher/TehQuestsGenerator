using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TehQuestsGenerator
{
    public partial class Form1 : Form
    {
        public static QuestList questList = new QuestList();
        public static LinkList linkList;

        public Form1()
        {
            InitializeComponent();
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
                fs.Close();
            }
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
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML Files (.xml)|*.xml";

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

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
                        var xml = stringWriter.ToString();

                        using (StreamWriter outputFile = new StreamWriter(saveDialog.FileName, true))
                        {
                            outputFile.WriteLine(xml);
                        }
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

        }

        private void deleteObjectiveButton_Click(object sender, EventArgs e)
        {

        }

        private void EnableMetadata(string questObjectiveType)
        {
            switch (questObjectiveType)
            {
                case "OBJECTIVE_TASK_BUILD":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new BuildControl() {Location = new Point(10,20)});
                    break;
                case "OBJECTIVE_TASK_COLLECT_RESOURCES":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CollectResourcesControl() {Location = new Point(10,20)});
                    break;
                case "OBJECTIVE_TASK_UPGRADE_BUILDING":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new UpgradeControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_HIRE_UNITS":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new HireControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_RESEARCH":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new LearnControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_CRAFT_BUILDING":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CraftCityControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_CRAFT_CAMP":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new CraftCampControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_WIN_LOCATION":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new WinPveControl() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_KILL_PVE":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new KillPveController() { Location = new Point(10, 20) });
                    break;
                case "OBJECTIVE_TASK_USE_ITEM":
                    groupBox4.Controls.Clear();
                    groupBox4.Controls.Add(new UseItemController() { Location = new Point(10, 20) });
                    break;
                default:
                    MessageBox.Show("The assigned objective type is not yet supported");
                    return;
            }
                
                
        }

        private void objectiveTypeCombobox_TextChanged_1(object sender, EventArgs e)
        {
            EnableMetadata(objectiveTypeCombobox.Text);
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].ObjectiveType =
                objectiveTypeCombobox.Text;
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

        public void updateBuildingTypeId(int buildingTypeId)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].QOTBuildData
                .BuildingTypeId = buildingTypeId;
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
