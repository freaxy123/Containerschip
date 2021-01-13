using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class Stack
    {
        private List<IContainer> containers;
        public int weight { get; private set; }

        public Stack()
        {
            containers = new List<IContainer>();
        }

        public bool addContainer(IContainer containerInput)
        {
            if(weight < containerInput.maxWeightOnTop)
            {
                containers.Add(containerInput);
                weight += containerInput.weight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public IContainer getContainer(int height)
        {
            try
            { 
                if(containers[height] != null)
                {
                    return containers[height];
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        public int getContainerCount()
        {
            return containers.Count();
        }
    }
}
