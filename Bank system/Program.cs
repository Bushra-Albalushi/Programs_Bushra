using System;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing arrays for usernames, passwords, and balances
            string[] usernames = { "Sara", "Reem", "Noor" };
            string[] passwords = { "pass1", "pass2", "pass3" };
            decimal[] balances = { 2000, 2500, 3000 };

            string username;
            string password;
            bool isLoggedIn = false;
            int loggedInUserIndex = -1;

            // User login section
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            // Check login credentials
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    isLoggedIn = true;
                    loggedInUserIndex = i;
                    break;
                }
            }

            if (!isLoggedIn)
            {
                Console.WriteLine("Invalid username or password. Exiting program.");
                return;
            }

            Console.WriteLine($"Welcome to the Bank App, {usernames[loggedInUserIndex]}!");

            // Main menu loop after successful login
            int choice;
            do
            {
                // Displaying the menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");
                Console.Write("Please choose an option (1-5): ");

                // Validate user input for menu choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please choose a number between 1 and 5.");
                }

                // Handle the user's menu choice
                switch (choice)
                {
                    case 1:
                        // Check Balance
                        Console.WriteLine($"Your balance is: {balances[loggedInUserIndex]:C}");
                        break;

                    case 2:
                        // Deposit
                        Console.Write("Enter amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                        {
                            balances[loggedInUserIndex] += depositAmount;
                            Console.WriteLine($"Deposit successful! New balance: {balances[loggedInUserIndex]:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please try again.");
                        }
                        break;

                    case 3:
                        // Withdraw
                        Console.Write("Enter amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balances[loggedInUserIndex])
                            {
                                balances[loggedInUserIndex] -= withdrawAmount;
                                Console.WriteLine($"Withdrawal successful! New balance: {balances[loggedInUserIndex]:C}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case 4:
                        // Transfer
                        Console.Write("Enter recipient username: ");
                        string recipient = Console.ReadLine();

                        int recipientIndex = Array.IndexOf(usernames, recipient);

                        if (recipientIndex == -1)
                        {
                            Console.WriteLine("Recipient not found.");
                        }
                        else if (recipientIndex == loggedInUserIndex)
                        {
                            Console.WriteLine("You cannot transfer to yourself.");
                        }
                        else
                        {
                            Console.Write("Enter amount to transfer: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal transferAmount) && transferAmount > 0)
                            {
                                if (transferAmount <= balances[loggedInUserIndex])
                                {
                                    balances[loggedInUserIndex] -= transferAmount;
                                    balances[recipientIndex] += transferAmount;
                                    Console.WriteLine($"Transfer successful! New balance: {balances[loggedInUserIndex]:C}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance for transfer!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                        }
                        break;

                    case 5:
                        // Exit
                        Console.WriteLine("Thank you for using the Bank App. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }

            } while (choice != 5); // Keep showing the menu until user chooses to exit
        }
    }
}         