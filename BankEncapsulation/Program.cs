namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount jm = new BankAccount();

            Console.WriteLine("How much  money woud you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            jm.Deposit(amountToDeposit);
            double userbalance = jm.GetBalance();
            
            Console.WriteLine($"Now your current balance is: {userbalance}");
        }
    }
}
