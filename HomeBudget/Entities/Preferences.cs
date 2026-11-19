using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Entities
{
    [Flags]
    public enum Preferences
    {
        None = 0,
        
        Sports = 1,

        Education = 2,

        Entertainments = 4,

        Tourism = 8,

        Arts = 16
    }
}
