using HomeBudget.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Repositories
{
    public interface IFamilyMemberRepository
    {
        IEnumerable<FamilyMember> ReadFamilyMembers();

        FamilyMember ReadFamilyMemberById(int id);

        void CreateFamilyMember(FamilyMember familyMember);

        void UpdateFamilyMember(FamilyMember familyMember);

        void DeleteFamilyMember(int id);
    }
}
