using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    public class IncomeSource
    {
        public int Id { get; private set; }

        public string Type { get; private set; } = string.Empty;

        public static IncomeSource CreateEntity(int id, string type)
        {
            return new IncomeSource { Id = id, Type = type ?? string.Empty };
        }
    }
}
