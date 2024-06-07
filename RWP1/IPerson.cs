using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWP1
{
    public interface IPerson
    {
        int CardNumber { get; set; }
        string Name { get; set; }
        DateTime Bithday { get; set; }
        IPerson Couple { get; }
        List<IPerson> Parents { get; }
        List<IPerson> Children { get; }
        int calcAge(DateTime date);
        void addChild(IPerson child);
        void addCouple(IPerson couple);
        void addParents(IPerson parent);
        void removeChild(IPerson child);
        void removeCouple(IPerson couple);
        void removeParents(IPerson parent);

    }
}
