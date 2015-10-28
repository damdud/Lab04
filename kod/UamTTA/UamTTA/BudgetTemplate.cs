using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace UamTTA
{
    public class BudgetTemplate
    {
        public BudgetTemplate(IEnumerable<Account> defaultAccounts, Duration defaultDuration, string defaultName)
        {
            DefaultAccounts = defaultAccounts;
            DefaultDuration = defaultDuration;
            DefaultName = defaultName;
        }

        public string DefaultName { get; }

        public IEnumerable<Account> DefaultAccounts { get; }

        public Duration DefaultDuration { get; }

        public override string ToString()
        {
            return $"DefaultName: {DefaultName}, DefaultAccounts: {DefaultAccounts.ToElementsString()}, DefaultDuration: {DefaultDuration}";
        }
    }
}