namespace LockExample.Entities
{
    public class BankAccount
    {
        private object padLock = new();
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            lock (padLock)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            lock (padLock)
            {
                Balance -= amount;
            }

        }
    }
}
