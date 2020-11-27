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
        public void addContainer(IContainer containerInput)
        {
            containers.Add(containerInput);
            weight += containerInput.weight;
        }

        public IContainer getContainer(int floor)
        {
            try
            { 
                if(containers[floor] != null)
                {
                    return containers[floor];
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
