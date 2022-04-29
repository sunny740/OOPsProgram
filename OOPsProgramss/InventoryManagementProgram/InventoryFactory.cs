using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OOPsProgramss.InventryDataManagement;

namespace OOPsProgramss.InventoryManagementProgram
{
    public class InventoryFactory
    {
        public InventoryDetails ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
            return inventory;
        }
        public void WriteToJson(string filePath, InventoryDetails details)
        {
            var serializeJson = JsonConvert.SerializeObject(details);
            File.WriteAllText(filePath, serializeJson);
        }
    }
}
