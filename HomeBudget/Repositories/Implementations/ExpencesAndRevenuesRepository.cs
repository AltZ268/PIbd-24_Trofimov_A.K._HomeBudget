using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Implementations
{
    public class ExpencesAndRevenuesRepository : IExpencesAndRevenuesRepository
    {
        public IEnumerable<ExpencesAndRevenues> ReadExpencesAndRevenues(DateTime? dateFrom = null, DateTime? dateTo = null, int? incomeFrom = null, int? incomeTo = null, int ? familyMemberId = null, int? budgetPlanId = null)
        {
            return [];
        }

        public void CreateExpencesAndRevenues(ExpencesAndRevenues expencesAndRevenues) { }
    }
}
