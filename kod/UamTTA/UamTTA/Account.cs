namespace UamTTA
{
    public class Account
    {
        public Account(string name, decimal balance, string relatedBankAccount = null,
            decimal? expectedIncomes = null, decimal? targetBalance = null)
        {
            Balance = balance;
            RelatedBankAccount = relatedBankAccount;
            ExpectedIncomes = expectedIncomes;
            Name = name;
            TargetBalance = targetBalance;
        }

        public string Name { get; set; }

        public string RelatedBankAccount { get; set; }

        public decimal Balance { get; set; }

        public decimal? ExpectedIncomes { get; set; }

        public decimal? TargetBalance { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, RelatedBankAccount: {RelatedBankAccount}, Balance: {Balance}, ExpectedIncomes: {ExpectedIncomes}, TargetBalance: {TargetBalance}";
        }
    }
}