﻿using System;

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
                    endDate = AddWeek(startDate);
                    break;

                case Duration.Monthly:
                    endDate = AddMonth(startDate);
                    break;

                case Duration.Quarterly:
                    endDate = AddQuarter(startDate);
                    break;

                case Duration.Yearly:
                    endDate = AddYear(startDate);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return new Budget(startDate, endDate);
        }

        private static DateTime AddWeek(DateTime startDate)
        {
            return startDate.AddDays(6);
        }

        private static DateTime AddMonth(DateTime startDate)
        {
            DateTime endDate = startDate.AddMonths(1);
            int daysInStartDate = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            int daysInNextMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);
            if (daysInNextMonth >= 30 && (endDate.Day < daysInNextMonth || daysInNextMonth == daysInStartDate))
                endDate = endDate.AddDays(-1);
            return endDate;
        }

        private static DateTime AddQuarter(DateTime startDate)
        {
            DateTime endDate = startDate.AddMonths(3);
            endDate = endDate.AddDays(-1);
            return endDate;
        }

        private static DateTime AddYear(DateTime startDate)
        {
            DateTime endDate = startDate.AddYears(1);
            endDate = endDate.AddDays(-1);
            return endDate;
        }
    }
}