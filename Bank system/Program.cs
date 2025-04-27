namespace Bank_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many users you want to create? ");
            int userCount = int.Parse(Console.ReadLine());
            string[] usernames =  {"Sara" , "Reem" , "Noor"};
            string[] passwords =  { "pass1" , "pass2" , "pass3"};
            decimal[] balances = {2000 , 2500, 3000};

            string username;
            string password;
            bool isLoggedIn = false;
            int userIndex = -1;

            while(isLoggedIn)
            {
                Console.WriteLine($"Enter username ");
                usernames = Console.ReadLine();
                Console.WriteLine($"Enter password  ");
                passwords= Console.ReadLine();
                Console.WriteLine($"Enter initial balance for user {i + 1}: ");
                balances= decimal.Parse(Console.ReadLine());


                int loggedInUserIndex = -1;
                Console.WriteLine(" \nWelcome to the  Bank App: ");
                Console .WriteLine("Enter your username");
                string inputUsername = Console.ReadLine();

                for (int i = 0; i < usernames.Length; i++)
                {
                    if (usernames == usernames[i] && password == password[i])
                    {
                       isLoggedIn = true;
                        userIndex = i;
                        break;

                        if (isLoggedIn)
                        {
                            Console.WriteLine("Invalid username or password. Exiting program");
                            return;
                            int choice;
                            do
                            {
                                Console.WriteLine("\nMenu");
                                Console.WriteLine("1. Check Balance");
                                Console.WriteLine("2. Deposit ");
                                Console.WriteLine("3. Withdraw ");
                                Console.WriteLine("4. Transfer ");
                                Console.WriteLine("5. Exit ");
                                choice(Console.ReadLine());
                                
                                {
                                  
                                    switch (choice)
                                    {
                                        case 1:
                                            Console.WriteLine($"Your balance is: {balances[loggedInUserIndex]:c}");
                                            break;

                                        case 2:
                                            Console.WriteLine("Enter amount to deposit: ");
                                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                                            {

                                                balances[loggedInUserIndex] += depositAmount;
                                                Console.WriteLine($"Deposited successful! New balance is: {balances[loggedInUserIndex]:c}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid amount. Please try again.");
                                            }
                                            break;

                                        case 3:
                                            Console.WriteLine("Enter amount to withdraw: ");
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

                                            Console.Write("Enter recipient username: ");

                                            string recipient = Console.ReadLine();

                                            int recipientIndex = Array.IndexOf(usernames, recipient);



                                            if (recipientIndex == -1)

                                            {

                                                Console.WriteLine("Recipient not found.");
                                            }

                                            else if (recipientIndex == loggedInUserIndex)

                                            {

                                                Console.WriteLine("Cannot transfer to yourself.");

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
                                                        Console.WriteLine("Insufficient balance!");
                                                    }
                                                }

                                                else

                                                {

                                                    Console.WriteLine("Invalid amount.");
                                                }
                                            }

                                            break;

                                        case 5:

                                            Console.WriteLine("Thank you for using the Bank App. Goodbye!");
                                            break;

                                        default:
                                            Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");

                                            break;
                                    }
                                }
                                while (choice != 5) ;
                            }
                            }