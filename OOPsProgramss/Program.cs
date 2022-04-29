using OOPsProgramss.InventryDataManagement;
using System;
namespace OOPsProgramss
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome To The OOPs Programs *****");
            const string Inventory_File_path = @"E:\BridgeLabzProject\OOPsPrograms\OOPsProgram\OOPsProgramss\InventryDataManagement\Inventory.json";
            InventoryManagement Data = new InventoryManagement();
            Console.WriteLine("1. Display \n");
            bool check = true;
            while (check)
            {
                //Console.WriteLine("Enter The Input That Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Data.DisplayInventory(Inventory_File_path);
                        break;
                }
            }
        }
    }
}