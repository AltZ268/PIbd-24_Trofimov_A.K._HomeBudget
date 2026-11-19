using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Implementations
{
    public class IncomeSourceRepository : IIncomeSourceRepository
    {
        public IEnumerable<IncomeSource> ReadIncomeSources()
        {
            return [];
        }

        public IncomeSource ReadIncomeSourceById(int id)
        {
            return IncomeSource.CreateEntity(0, string.Empty);
        }

        public void CreateIncomeSource(IncomeSource incomeSource) { }

        public void UpdateIncomeSource(IncomeSource incomeSource) { }

        public void DeleteIncomeSource(int id) { }
    }
}
