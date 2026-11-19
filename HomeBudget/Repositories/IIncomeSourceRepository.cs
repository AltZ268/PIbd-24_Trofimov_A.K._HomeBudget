using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories
{
    public interface IIncomeSourceRepository
    {
        IEnumerable<IncomeSource> ReadIncomeSources();

        IncomeSource ReadIncomeSourceById(int id);

        void CreateIncomeSource(IncomeSource incomeSource);

        void UpdateIncomeSource(IncomeSource incomeSource);

        void DeleteIncomeSource(int id);
    }
}
