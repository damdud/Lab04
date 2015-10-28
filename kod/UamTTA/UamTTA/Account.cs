namespace UamTTA
{
    public class Account
    {
        public Account(string name, decimal balance, string relatedBankAccount = null,
            decimal? expectedIncomes = null, decimal? targetBalance = null)
        {
            Name = name;
            Balance = balance;
            RelatedBankAccount = relatedBankAccount;
            ExpectedIncomes = expectedIncomes;
            TargetBalance = targetBalance;
        }

        public string Name { get; }

        public string RelatedBankAccount { get; }

        public decimal Balance { get; }

        public decimal? ExpectedIncomes { get; }

        public decimal? TargetBalance { get; }

        public override string ToString()
        {
            return $"Name: {Name}, RelatedBankAccount: {RelatedBankAccount}, Balance: {Balance}, ExpectedIncomes: {ExpectedIncomes}, TargetBalance: {TargetBalance}";
        }
    }
}
