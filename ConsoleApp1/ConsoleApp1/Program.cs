using System;

namespace InventoryDataManagement
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:/BridgeLabz/Object_Oriented_Problem/Object_Oriented_Problem/ConsoleApp1/ConsoleApp1/json1.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            Console.WriteLine(data.Name);
            Console.WriteLine(data.Weight);
            Console.WriteLine(data.Price);


        }
    }
}
