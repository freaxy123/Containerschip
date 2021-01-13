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
        int stackCounter = 0;

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

        public bool addContainer(IContainer containerInput)
        {
            for (int i = stackCounter; i < stacks.Count; i++)
            {
                if ((stacks[i].weight + containerInput.weight) < containerInput.maxWeightOnTop)
                {
                    stacks[i].addContainer(containerInput);

                    if(stackCounter == (stacks.Count - 1))
                    {
                        stackCounter = 0;
                    }
                    else
                    {
                        stackCounter++;
                    }
                    
                    return true;
                }             
            }
            return false;

            //foreach (Stack stack in stacks)
            //{
            //    if ((stack.weight + containerInput.weight) < containerInput.maxWeightOnTop)
            //    {
            //        stack.addContainer(containerInput);
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return false;
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
