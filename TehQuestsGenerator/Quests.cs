using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace TehQuestsGenerator
{
    [XmlRoot(ElementName = "QOTUpgradeBuilding")]
    public class QOTUpgradeBuilding
    {
        [XmlElement(ElementName = "buildingTypeId")]
        public string BuildingTypeId { get; set; }
        [XmlElement(ElementName = "level")]
        public string Level { get; set; }
    }

    [XmlRoot(ElementName = "objective")]
    public class Objective
    {
        [XmlElement(ElementName = "objectiveTitleId")]
        public string ObjectiveTitleId { get; set; }
        [XmlElement(ElementName = "objectiveDescId")]
        public string ObjectiveDescId { get; set; }
        [XmlElement(ElementName = "hide")]
        public bool Hide { get; set; }
        [XmlElement(ElementName = "QOTUpgradeBuilding")]
        public QOTUpgradeBuilding QOTUpgradeBuilding { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
        [XmlAttribute(AttributeName = "objectiveType")]
        public string ObjectiveType { get; set; }
        [XmlAttribute(AttributeName = "objectiveId")]
        public string ObjectiveId { get; set; }
        [XmlElement(ElementName = "QOTCollectResourceData")]
        public QOTCollectResourceData QOTCollectResourceData { get; set; }
        [XmlElement(ElementName = "QOTBuildData")]
        public QOTBuildData QOTBuildData { get; set; }
        [XmlElement(ElementName = "QOTHireUnitsData")]
        public QOTHireUnitsData QOTHireUnitsData { get; set; }
        [XmlElement(ElementName = "QOTCraftBuilding")]
        public QOTCraftBuilding QOTCraftBuilding { get; set; }
        [XmlElement(ElementName = "QOTResearch")]
        public QOTResearch QOTResearch { get; set; }
        [XmlElement(ElementName = "QOTCraftCamp")]
        public QOTCraftCamp QOTCraftCamp { get; set; }
        [XmlElement(ElementName = "QOTWinLocation")]
        public QOTWinLocation QOTWinLocation { get; set; }
        [XmlElement(ElementName = "QOTUseItem")]
        public QOTUseItem QOTUseItem { get; set; }
        [XmlElement(ElementName = "lockType")]
        public string LockType { get; set; }
    }

    [XmlRoot(ElementName = "reward")]
    public class Reward
    {
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "spec")]
        public int Spec { get; set; }
        [XmlElement(ElementName = "rewardAmount")]
        public int RewardAmount { get; set; }
    }

    [XmlRoot(ElementName = "quest")]
    public class Quest
    {
        [XmlElement(ElementName = "questTitleId")]
        public string QuestTitleId { get; set; }
        [XmlElement(ElementName = "questDescId")]
        public string QuestDescId { get; set; }
        [XmlElement(ElementName = "questIconId")]
        public string QuestIconId { get; set; }
        [XmlElement(ElementName = "objective")]
        public List<Objective> Objective { get; set; }
        [XmlElement(ElementName = "reward")]
        public List<Reward> Reward { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
        [XmlAttribute(AttributeName = "questType")]
        public string QuestType { get; set; }
        [XmlAttribute(AttributeName = "questId")]
        public string QuestId { get; set; }
    }

    [XmlRoot(ElementName = "QOTCollectResourceData")]
    public class QOTCollectResourceData
    {
        [XmlElement(ElementName = "res")]
        public string Res { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
        [XmlElement(ElementName = "counterType")]
        public string CounterType { get; set; }
    }

    [XmlRoot(ElementName = "QOTBuildData")]
    public class QOTBuildData
    {
        [XmlElement(ElementName = "buildingTypeId")]
        public int BuildingTypeId { get; set; }
        [XmlElement(ElementName = "count")]
        public int Count { get; set; }
        [XmlElement(ElementName = "counterType")]
        public string CounterType { get; set; }
    }

    [XmlRoot(ElementName = "QOTHireUnitsData")]
    public class QOTHireUnitsData
    {
        [XmlElement(ElementName = "unitTypeId")]
        public string UnitTypeId { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
        [XmlElement(ElementName = "counterType")]
        public string CounterType { get; set; }
    }

    [XmlRoot(ElementName = "crafts")]
    public class Crafts
    {
        [XmlElement(ElementName = "craftTypeId")]
        public List<string> CraftTypeId { get; set; }
    }

    [XmlRoot(ElementName = "QOTCraftBuilding")]
    public class QOTCraftBuilding
    {
        [XmlElement(ElementName = "crafts")]
        public Crafts Crafts { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "QOTResearch")]
    public class QOTResearch
    {
        [XmlElement(ElementName = "knowledgeTypeId")]
        public string KnowledgeTypeId { get; set; }
        [XmlElement(ElementName = "level")]
        public string Level { get; set; }
    }

    [XmlRoot(ElementName = "QOTCraftCamp")]
    public class QOTCraftCamp
    {
        [XmlElement(ElementName = "crafts")]
        public Crafts Crafts { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "locations")]
    public class Locations
    {
        [XmlElement(ElementName = "location")]
        public List<string> Location { get; set; }
    }

    [XmlRoot(ElementName = "QOTWinLocation")]
    public class QOTWinLocation
    {
        [XmlElement(ElementName = "locations")]
        public Locations Locations { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "items")]
    public class Items
    {
        [XmlElement(ElementName = "item")]
        public string Item { get; set; }
    }

    [XmlRoot(ElementName = "QOTUseItem")]
    public class QOTUseItem
    {
        [XmlElement(ElementName = "items")]
        public Items Items { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "questList")]
    public class QuestList
    {
        [XmlElement(ElementName = "quest")]
        public List<Quest> Quest { get; set; }
    }

}
