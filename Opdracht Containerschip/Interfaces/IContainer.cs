using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    public interface IContainer
    {
        int weight { get; }
        int maxWeight { get; }
        int maxWeightOnTop { get; }
        bool cooled { get; }
        bool valuable { get; }
        string Containername();
    }
}
