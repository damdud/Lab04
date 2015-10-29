using System;

namespace UamTTA
{
    public class BudgetFactory
    {
        public Budget CreateBudget(BudgetTemplate template, DateTime startDate)
        {
            DateTime endDate = default(DateTime);
            switch (template.DefaultDuration)
            {
                case Duration.Weekly:
                    endDate = startDate.AddDays(6);
                    break;

                case Duration.Monthly:
                    endDate = startDate.AddMonths(1);
                    int daysInStartDate = DateTime.DaysInMonth(startDate.Year, startDate.Month);
                    int daysInNextMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);
                    if (daysInNextMonth >= 30 && (endDate.Day < daysInNextMonth || daysInNextMonth == daysInStartDate))
                        endDate = endDate.AddDays(-1);
                    break;

                case Duration.Quarterly:
                    break;

                case Duration.Yearly:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return new Budget(startDate, endDate);
        }
    }
}