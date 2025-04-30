namespace Simple_Inventory_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "Apple", "Orange", "Milk", "Bread", "Juice" }; 
            int[] quantities = { 50, 30, 100, 20, 60 }; 

            bool exit = false; 

            while (!exit)
            {
                
                Console.Clear(); 
                Console.WriteLine("=== Inventory Management System ===");
                Console.WriteLine("1. View All Products");
                Console.WriteLine("2. Add Stock");
                Console.WriteLine("3. Sell Product");
                Console.WriteLine("4. Check Product Quantity");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please choose an option (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        
                        Console.WriteLine("\n--- Available Products ---");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{products[i]} - {quantities[i]} in stock");
                        }
                        break;

                    case "2":
                        
                        Console.WriteLine("\nEnter the product name to add stock:");
                        string addProduct = Console.ReadLine();
                        bool addProductFound = false;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == addProduct.ToLower()) 
                            {
                                Console.WriteLine($"Enter the quantity to add for {products[i]}:");
                                int addQuantity;
                                while (!int.TryParse(Console.ReadLine(), out addQuantity) || addQuantity <= 0)
                                {
                                    Console.WriteLine("Please enter a valid quantity (positive number):");
                                }
                                quantities[i] += addQuantity; 
                                Console.WriteLine($"{addQuantity} {products[i]} added to stock.");
                                addProductFound = true;
                                break;
                            }
                        }
                        if (!addProductFound)
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case "3":
                        
                        Console.WriteLine("\nEnter the product name to sell:");
                        string sellProduct = Console.ReadLine();
                        bool sellProductFound = false;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == sellProduct.ToLower()) 
                            {
                                Console.WriteLine($"Enter the quantity to sell for {products[i]}:");
                                int sellQuantity;
                                while (!int.TryParse(Console.ReadLine(), out sellQuantity) || sellQuantity <= 0)
                                {
                                    Console.WriteLine("Please enter a valid quantity (positive number):");
                                }
                                if (sellQuantity <= quantities[i])
                                {
                                    quantities[i] -= sellQuantity; 
                                    Console.WriteLine($"{sellQuantity} {products[i]} sold.");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough stock to sell.");
                                }
                                sellProductFound = true;
                                break;
                            }
                        }
                        if (!sellProductFound)
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case "4":
                        
                        Console.WriteLine("\nEnter the product name to check quantity:");
                        string checkProduct = Console.ReadLine();
                        bool checkProductFound = false;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i].ToLower() == checkProduct.ToLower()) 
                            {
                                Console.WriteLine($"{products[i]} has {quantities[i]} in stock.");
                                checkProductFound = true;
                                break;
                            }
                        }
                        if (!checkProductFound)
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case "5":
                        
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;

                    default:
                       
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                
                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
