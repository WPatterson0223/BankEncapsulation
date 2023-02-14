namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            int command = 0;
            Console.WriteLine("Please create a PIN");
            var pin = Console.ReadLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Deposite\n2- Withdraw\n3- Check Balance\n4- Exit");
                var canParse = int.TryParse(Console.ReadLine(), out command);
                if (canParse)
                {
                    switch (command)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Please enter your PIN");
                            var depositPin = Console.ReadLine();
                            if (pin == depositPin)
                            {
                                Console.WriteLine();
                                Console.WriteLine("How much would you like to deposit?");
                                var depositParse = double.TryParse(Console.ReadLine(), out double deposite);
                                if (depositParse)
                                {
                                    myAccount.Deposit(deposite);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("That is not a valid amount. Try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("That PIN is incorrect.");
                            }
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Please enter your PIN");
                            var withdrawPin = Console.ReadLine();
                            if (pin == withdrawPin)
                            {
                                Console.WriteLine();
                                Console.WriteLine("How much would you like to withdraw?");
                                var withdrawParse = double.TryParse(Console.ReadLine(), out double withdraw);
                                if (withdrawParse)
                                {
                                    myAccount.Withdraw(withdraw);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("That is not a valid amount. Try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("That PIN is incorrect.");
                            }
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Please enter your PIN");
                            var balancePin = Console.ReadLine();
                            if (pin == balancePin)
                            {
                                myAccount.GetBalance();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("That PIN is incorrect.");
                            }
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Have a nice day!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please select a valid option.");
                }
            }while (command != 4);
        }
    }
}
