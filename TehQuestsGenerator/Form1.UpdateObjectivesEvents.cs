using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehQuestsGenerator
{
    public partial class Form1
    {
        private void updateBuildingTypeId(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].QOTBuildData
                .BuildingTypeId = int.Parse((groupBox4.Controls[0] as BuildControl).buildingTypeIdTextBox.Text);
        }

        private void updateBuildingCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].QOTBuildData
                .Count = int.Parse((groupBox4.Controls[0] as BuildControl).countTextBox.Text);
        }

        private void updateBuildingCounterType(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)].QOTBuildData
                .CounterType = (groupBox4.Controls[0] as BuildControl).counterTypeComboBox.Text;
        }

        private void updateResTypeId(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCollectResourceData.Res = (groupBox4.Controls[0] as CollectResourcesControl).resTextBox.Text;
        }

        private void updateResCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCollectResourceData.Count = int.Parse((groupBox4.Controls[0] as CollectResourcesControl).countTextBox.Text);
        }

        private void updateResCounterType(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCollectResourceData.CounterType = (groupBox4.Controls[0] as CollectResourcesControl).counterTypeComboBox.Text;
        }

        private void updateUpgradeBuildingTypeId(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTUpgradeBuilding.BuildingTypeId = int.Parse((groupBox4.Controls[0] as UpgradeControl).buildingTypeIdTextBox.Text);
        }

        private void updateUpgradeLevel(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTUpgradeBuilding.Level = int.Parse((groupBox4.Controls[0] as UpgradeControl).upgradeLevelTextBox.Text);
        }

        private void updateHireUnitTypeId(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTHireUnitsData.UnitTypeId = int.Parse((groupBox4.Controls[0] as HireControl).unitTypeIdTextBox.Text);
        }

        private void updateHireCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTHireUnitsData.Count = int.Parse((groupBox4.Controls[0] as HireControl).countTextBox.Text);
        }

        private void updateHireCounterType(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTHireUnitsData.CounterType = (groupBox4.Controls[0] as HireControl).counterTypeComboBox.Text;
        }

        private void updateResearchKnowledgeTypeId(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTResearch.KnowledgeTypeId = int.Parse((groupBox4.Controls[0] as LearnControl).knowledgeTypeIdTextBox.Text);
        }

        private void updateResearchKnowledgeLevel(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTResearch.Level = int.Parse((groupBox4.Controls[0] as LearnControl).levelTextBox.Text);
        }

        private void updateCraftCityIdsList(object sender, EventArgs e)
        {
            Crafts craftsList = new Crafts();
            craftsList.CraftTypeId = new List<string>();

            foreach (var craftId in (groupBox4.Controls[0] as CraftCityControl).craftIdsListBox.Items)
            {
                craftsList.CraftTypeId.Add(craftId.ToString());
            }
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCraftBuilding.Crafts = craftsList;
        }

        private void updateCraftCityCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCraftBuilding.Count = int.Parse((groupBox4.Controls[0] as CraftCityControl).countTextBox.Text);
        }

        private void updateCraftCampIdsList(object sender, EventArgs e)
        {
            Crafts craftsList = new Crafts();
            craftsList.CraftTypeId = new List<string>();

            foreach (var craftId in (groupBox4.Controls[0] as CraftCampControl).craftIdsLlistBox.Items)
            {
                craftsList.CraftTypeId.Add(craftId.ToString());
            }
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCraftCamp.Crafts = craftsList;
        }

        private void updateCraftCampCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTCraftCamp.Count = int.Parse((groupBox4.Controls[0] as CraftCampControl).countTextBox.Text);
        }

        private void updateWinPveLocationIdsList(object sender, EventArgs e)
        {
            Locations locationsList = new Locations();
            locationsList.Location = new List<string>();

            foreach (var locationId in (groupBox4.Controls[0] as WinPveControl).locationsListBox.Items)
            {
                locationsList.Location.Add(locationId.ToString());
            }
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTWinLocation.Locations = locationsList;
        }

        private void updateWinPveCount(object sender, EventArgs e)
        {
            questList.Quest[int.Parse(IndexBox.Text)].Objective[int.Parse(objectiveIndexTextbox.Text)]
                .QOTWinLocation.Count = int.Parse((groupBox4.Controls[0] as WinPveControl).countTextBox.Text);
        }


    }
}
