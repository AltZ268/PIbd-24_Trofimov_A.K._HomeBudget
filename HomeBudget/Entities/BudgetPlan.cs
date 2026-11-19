using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    public class BudgetPlan
    {
        public int Id { get; private set; }

        public int TotalExpences { get; private set; }

        public int TotalRevenue { get; private set; }

        public DateTime StartingDate { get; private set; }

        public DateTime EndingDate { get; private set; }

        public BudgetStatus Status { get; private set; }

        public static BudgetPlan CreateOperation(int id, int totalExpences, int totalRevenue, DateTime startingDate, DateTime endingDate, BudgetStatus status = BudgetStatus.WorkInProgress)
        {
            return new BudgetPlan
            {
                Id = id,
                TotalExpences = totalExpences,
                TotalRevenue = totalRevenue,
                StartingDate = startingDate,
                EndingDate = endingDate,
                Status = status
            };
        }
    }
}
