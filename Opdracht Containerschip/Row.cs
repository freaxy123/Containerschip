using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class Row
    {
        private List<Stack> stacks;

        public void initialize(int widthInContainers)
        {
            stacks = new List<Stack>();
            for(int i = 0; i < widthInContainers; i++)
            {
                stacks.Add(new Stack());
            }  
        }

        public bool addContainer(int stackNumberInput, IContainer containerInput)
        {
            if((stacks[stackNumberInput].weight + containerInput.weight) < containerInput.maxWeightOnTop)
            {
                stacks[stackNumberInput].addContainer(containerInput);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> getAvailableStacks(int floor)
        {
            List<int> available = new List<int>();
            int i = 0;
            foreach(Stack stack in stacks)
            {
                if(stack.getContainer(floor) == null)
                {
                    available.Add(i);
                }
                i++;
            }
            return available;

        }

        public IReadOnlyList<Stack> getStacks()
        {
            return stacks.AsReadOnly();
        }
    }
}
