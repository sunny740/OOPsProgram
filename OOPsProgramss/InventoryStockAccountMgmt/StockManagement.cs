using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProgramss.InventoryStockAccountMgmt
{
    public class StockManagement
    {
        public void DisplayInventory(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<StockData>>(json);
                Console.WriteLine("ShareName" + "\t" + "NumberofShare " + "\t" + "SharePrice" + "\t" + "TotalShareValue");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.ShareName + "\t\t " + data.NumberofShare + "\t\t" + data.SharePrice + "\t\t" + (data.NumberofShare * data.SharePrice));
                }
            }
        }
    }
}
