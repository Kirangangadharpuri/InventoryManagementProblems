using InventoryManagement1;

namespace InventoryManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory problems");

            string path = "C:\\Users\\kiran\\source\\repos\\InventoryManagement1\\InventoryManagement1\\Inventory.json";
            ReadInventory obj = new ReadInventory();

            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Stock 1");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock1.Count; i++)
            {
                Console.WriteLine(data.stock1[i].name);
                Console.WriteLine(data.stock1[i].weight);
                Console.WriteLine(data.stock1[i].price);

                int val = data.stock1[i].weight * data.stock1[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock1[i].name, data.stock1[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 2");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock2.Count; i++)
            {
                Console.WriteLine(data.stock2[i].name);
                Console.WriteLine(data.stock2[i].weight);
                Console.WriteLine(data.stock2[i].price);

                int val = data.stock2[i].weight * data.stock2[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock2[i].name, data.stock2[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 3");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock3.Count; i++)
            {
                Console.WriteLine(data.stock3[i].name);
                Console.WriteLine(data.stock3[i].weight);
                Console.WriteLine(data.stock3[i].price);

                int val = data.stock3[i].weight * data.stock3[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock3[i].name, data.stock3[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

        }
    }



}
    




