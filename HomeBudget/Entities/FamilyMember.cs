using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    public class FamilyMember
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public IEnumerable<FamilyMemberIncomeSourse> FamilyMemberIncomeSourses { get; private set; } = [];

        public static FamilyMember CreateEntity(int id, string name, IEnumerable<FamilyMemberIncomeSourse> familyMemberIncomeSourses)
        {
            return new FamilyMember
            {
                Id = id,
                Name = name,
                FamilyMemberIncomeSourses = familyMemberIncomeSourses
            };
        }
    }
}
