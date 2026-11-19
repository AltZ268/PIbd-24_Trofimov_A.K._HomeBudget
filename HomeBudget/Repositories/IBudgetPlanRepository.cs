using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories
{
    public interface IBudgetPlanRepository
    {
        IEnumerable<BudgetPlan> BudgetPlans(DateTime? dateFrom = null, DateTime? dateTo = null, BudgetStatus? budgetStatus = null);

        BudgetPlan ReadBudgetPlanById(int id);

        void CreateBudgetPlan(BudgetPlan budgetPlan);

        void UpdateBudgetPlan(BudgetPlan budgetPlan);
    }
}
