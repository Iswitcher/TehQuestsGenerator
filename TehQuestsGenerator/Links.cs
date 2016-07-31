using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace TehQuestsGenerator
{
    [XmlRoot(ElementName = "link")]
    public class Link
    {
        [XmlAttribute(AttributeName = "linkToId")]
        public string LinkToId { get; set; }
        [XmlAttribute(AttributeName = "linkType")]
        public string LinkType { get; set; }
        [XmlAttribute(AttributeName = "triggerType")]
        public string TriggerType { get; set; }
        [XmlAttribute(AttributeName = "linkId")]
        public string LinkId { get; set; }
        [XmlAttribute(AttributeName = "linkFromId")]
        public string LinkFromId { get; set; }
    }

    [XmlRoot(ElementName = "linkList")]
    public class LinkList
    {
        [XmlElement(ElementName = "link")]
        public List<Link> Link { get; set; }
    }

}