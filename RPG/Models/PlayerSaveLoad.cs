using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RPG.Models
{
    class PlayerSaveLoad
    {
        public static void WriteToBinaryFile<Player>(string filePath, Player objectToWrite, bool append = false)
        {
            if (File.Exists(filePath))
            {
                using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, objectToWrite);
                }
            }
            else
            {
                using (Stream stream = File.Create(filePath))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, objectToWrite);
                }
            }
        }

        public static Player ReadFromBinaryFile<Player>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                return (Player)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
