using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial setup
            PlayerXml player = new PlayerXml()
            {
                AttackPoints = 20,
                BaseHealth = 100,
                PlayerName = "Test Player 1"
            };

            // Serialize object
            player.SaveXml();

            // Deserialize object and print output
            PlayerXml playerFromXml = PlayerXml.LoadXml();
        
            if ( playerFromXml != null )
                Console.WriteLine(string.Format("Name: {0}\nHealth: {1}\nAttackPoints: {2}\n", playerFromXml.PlayerName, playerFromXml.BaseHealth, playerFromXml.AttackPoints));
        }
    }
}
