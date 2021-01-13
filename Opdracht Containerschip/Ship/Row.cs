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
        int prefferedStack = 0;

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
            return stacks[stackNumberInput].addContainer(containerInput); 
        }

        public bool addContainer(IContainer containerInput)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[prefferedStack].addContainer(containerInput))
                { 
                    updatePrefferedStack();
                    return true;
                }             
            }
            return false;
        }

        public bool addContainer2(IContainer containerInput, IReadOnlyList<Stack> previousStackList)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[prefferedStack].getContainerCount() + 1 < previousStackList[prefferedStack].getContainerCount())
                {
                    if (stacks[prefferedStack].addContainer(containerInput))
                    {
                        updatePrefferedStack();
                        return true;
                    }
                    else
                    {
                        updatePrefferedStack();
                    }
                }
                else
                {
                    updatePrefferedStack();
                }
            }
            return false;
        }

        public void updatePrefferedStack()
        {
            if (prefferedStack == (stacks.Count - 1))
            {
                prefferedStack = 0;
            }
            else
            {
                prefferedStack++;
            }
        }

        public List<int> getAvailableStacksIndex(int height)
        {
            List<int> available = new List<int>();

            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[i].getContainer(height) == null)
                {
                    available.Add(i);
                }
            }

            return available;
        }

        public IReadOnlyList<Stack> getStacks()
        {
            return stacks.AsReadOnly();
        }
    }
}
