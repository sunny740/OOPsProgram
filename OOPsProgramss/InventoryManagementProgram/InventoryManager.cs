using OOPsProgramss.InventryDataManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProgramss.InventoryManagementProgram
{
    public class InventoryManager
    {
        InventoryFactory factory = new InventoryFactory();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        List<InventoryData> pulsesList = new List<InventoryData>();
        public void ReadData(string filePath)
        {
            InventoryDetails details = factory.ReadJson(filePath);
            this.riceList = details.RiceList;
            this.wheatList = details.WheatList;
            this.pulsesList = details.PulsesList;
        }
        public void AddInventory(InventoryData data,string inventoryName, string filePath)
        {
            if (inventoryName.Equals("Rice"))
            {
                riceList.Add(data);
            }
            if (inventoryName.Equals("Wheat"))
            {
                wheatList.Add(data);
            }
            if (inventoryName.Equals("Pulses"))
            {
                pulsesList.Add(data);
            }
            SaveInventory(filePath);
        }
        public void SaveInventory(string filePath)
        {
            InventoryDetails details = new InventoryDetails();
            details.RiceList = riceList;
            details.WheatList = wheatList;
            details.PulsesList = pulsesList;
            factory.WriteToJson(filePath, details);
        }
        public void EditInventory(string inventoryName, string rice, string filePath)
        {
            if (inventoryName.Equals("Rice"))
            {
                foreach(var data in riceList)
                {
                    if (data.Equals(rice))
                    {
                        Console.WriteLine("Choose An Option To Edit:");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("wheat"))
            {
                foreach (var data in riceList)
                {
                    if (data.Equals(rice))
                    {
                        Console.WriteLine("Choose An Option To Edit:");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("pulses"))
            {
                foreach (var data in riceList)
                {
                    if (data.Equals(rice))
                    {
                        Console.WriteLine("Choose An Option To Edit:");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                                data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
        }
    }
}