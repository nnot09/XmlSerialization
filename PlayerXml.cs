using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    [XmlRoot("PlayerConfiguration")]
    public class PlayerXml
    {
        [XmlElement]
        public string PlayerName { get; set; }

        [XmlElement]
        public int BaseHealth { get; set; }

        [XmlElement]
        public int AttackPoints { get; set; }

        public void SaveXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlayerXml));

            using (FileStream fs = new FileStream("players.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                serializer.Serialize(fs, this);
            }
        }

        public static PlayerXml LoadXml()
        {
            PlayerXml deserialized;

            XmlSerializer serializer = new XmlSerializer(typeof(PlayerXml));
            using (FileStream stream = new FileStream("players.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                deserialized = (PlayerXml)serializer.Deserialize(stream);
            }

            return deserialized;
        }
    }
}
