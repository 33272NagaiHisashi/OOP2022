using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class Novelist {
    public string Name { get; set; }
    public DateTime Birth { get; set; }
    [XmlArray("masterpieces")]
    [XmlArrayItem("title",typeof(string))]
    public string[] Masterpieces { get; set; }
}
