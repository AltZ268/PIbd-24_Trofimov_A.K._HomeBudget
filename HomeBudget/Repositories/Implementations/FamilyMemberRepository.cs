using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories.Implementations
{
    public class FamilyMemberRepository : IFamilyMemberRepository
    {
        public IEnumerable<FamilyMember> ReadFamilyMembers()
        {
            return [];
        }

        public FamilyMember ReadFamilyMemberById(int id)
        {
            return FamilyMember.CreateEntity(0, string.Empty, []);
        }

        public void CreateFamilyMember(FamilyMember familyMember) { }

        public void UpdateFamilyMember(FamilyMember familyMember) { }

        public void DeleteFamilyMember(int id) { }
    }
}
