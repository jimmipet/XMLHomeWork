using System.Xml.Serialization;

namespace Свалка_суперфинальная
{
    [XmlRoot("Dump")]

    public class Dump
    {
        [XmlElement("Wastes")]
        public Wastes Wastes { get; set; }

        [XmlElement("Equipments")]
        public Equipments Equipments { get; set; }

        [XmlElement("Workers")]
        public Workers Workers { get; set; }

        [XmlElement("Repairs")]
        public Repairs Repairs { get; set; }

        [XmlElement("Decompositionperiods")]
        public Decompositionperiods Decompositionperiods { get; set; }

    }

    public class Wastes
    {
        [XmlElement("Waste")]

        public Waste[] WastesArray { get; set; }
    }
    public class Equipments
    {
        [XmlElement("Equipment")]

        public Equipment[] EquipmentsArray { get; set; }
    }
    public class Workers
    {
        [XmlElement("Worker")]

        public Worker[] WorkersArray { get; set; }
    }
    public class Decompositionperiods
    {
        [XmlElement("Decompositionperiod")]
        public Decompositionperiod[] DecompositionperiodsArray { get; set; }
    }
    public class Repairs
    {
        [XmlElement("Repair")]
        public Repair[] RepairsArray { get; set; }
    }

    [XmlRoot("Wastes")]
    public class Waste
    {
        [XmlAttribute("id", Namespace = "")]

        public int vId { get; set; }

        [XmlElement("Condition", Namespace = "")]

        public string vCondition { get; set; }

        [XmlElement("State", Namespace = "")]

        public string vState { get; set; }

        [XmlElement("Type", Namespace = "")]

        public string vType { get; set; }

        [XmlElement("Decompositionperiod", Namespace = "")]

        public Decompositionperiod Decompositionperiod { get; set; }
    }

    [XmlRoot("Equipments")]
    public class Equipment
    {
        [XmlAttribute("id", Namespace = "")]

        public int tId { get; set; }

        [XmlElement("name", Namespace = "")]

        public string tName { get; set; }

        [XmlElement("year", Namespace = "")]

        public string tyear { get; set; }

        [XmlElement("Condition", Namespace = "")]

        public string tCondition { get; set; }

        [XmlElement("Repair", Namespace = "")]

        public Repair Repairs { get; set; }
    }

    [XmlRoot("Workers")]
    public class Worker
    {
        [XmlAttribute("id", Namespace = "")]

        public int sId { get; set; }

        [XmlElement("name", Namespace = "")]

        public string sName { get; set; }

        [XmlElement("surname", Namespace = "")]

        public string ssurname { get; set; }

        [XmlElement("post", Namespace = "")]

        public string spost { get; set; }

        [XmlElement("Salary", Namespace = "")]

        public string sSalary { get; set; }
    }
    [XmlRoot("Repairs")]
    public class Repair
    {
        [XmlElement("Status",Namespace ="")]
        public string gStatus { get; set; }
    }
    [XmlRoot("Decompositionperiods")]
    public class Decompositionperiod
    {
        [XmlElement("age", Namespace = "")]
        public string fage { get; set; }
    }

}

