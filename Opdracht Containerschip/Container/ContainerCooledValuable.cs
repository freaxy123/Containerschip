using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class ContainerCooledValuable : IContainer
    {
        public int weight { get; private set; }
        public int maxWeight { get; private set; }
        public int maxWeightOnTop { get; private set; }
        public bool cooled { get; private set; }
        public bool valuable { get; private set; }

        public ContainerCooledValuable(int weight = 4000)
        {
            this.weight = weight;
            this.maxWeightOnTop = 120000;
            this.maxWeight = 30000;
            this.cooled = true;
            this.valuable = true;
        }
    }
}
