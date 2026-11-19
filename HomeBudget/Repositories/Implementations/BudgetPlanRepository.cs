using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Implementations
{
    public class BudgetPlanRepository : IBudgetPlanRepository
    {
        public IEnumerable<BudgetPlan> BudgetPlans(DateTime? dateFrom = null, DateTime? dateTo = null, BudgetStatus? budgetStatus = null)
        {
            return [];
        }

        public BudgetPlan ReadBudgetPlanById(int id)
        {
            return BudgetPlan.CreateOperation(0, 0, 0, DateTime.Now, DateTime.Now, BudgetStatus.WorkInProgress);
        }

        public void CreateBudgetPlan(BudgetPlan budgetPlan) { }

        public void UpdateBudgetPlan(BudgetPlan budgetPlan) { }
    }
}
