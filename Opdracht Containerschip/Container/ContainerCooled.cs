using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class ContainerCooled : IContainer
    {
        public int weight { get; private set; }
        public int maxWeight { get; private set; }
        public int maxWeightOnTop { get; private set; }
        public bool cooled { get; private set; }
        public bool valuable { get; private set; }

        public ContainerCooled(int weight = 4000)
        {
            this.weight = weight;
            this.maxWeightOnTop = 120000;
            this.maxWeight = 30000;
            this.cooled = true;
            this.valuable = false;
        }

        public override string ToString()
        {
            return $"ContainerCooled  (Weight: {weight})";
        }

        public string Containername()
        {
            return "ContainerCooled";
        }
    }
}
