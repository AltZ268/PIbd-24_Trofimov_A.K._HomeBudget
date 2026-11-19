using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    public class FamilyMemberIncomeSourse
    {
        public int Id { get; private set; }

        public int IncomeSourseId { get; private set; }

        public static FamilyMemberIncomeSourse CreateElement(int id, int incomeSourceId)
        {
            return new FamilyMemberIncomeSourse { Id = id, IncomeSourseId = incomeSourceId };
        }
    }
}
