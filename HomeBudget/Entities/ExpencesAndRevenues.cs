using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    public class ExpencesAndRevenues
    {
        public int Id { get; private set; }

        public int Income {  get; private set; }

        public int FamilyMemberId { get; private set; }

        public string Description { get; private set; } = string.Empty;

        public DateTime Date {  get; private set; }

        public int BudgetPlanId { get; private set; }

        public static ExpencesAndRevenues CreateOperation(int id, int income, int familyMemberId, string description, int budgetPlanId)
        {
            return new ExpencesAndRevenues
            {
                Id = id,
                Income = income,
                FamilyMemberId = familyMemberId,
                Description = description,
                Date = DateTime.Now,
                BudgetPlanId = budgetPlanId
            };
        }
    }
}
