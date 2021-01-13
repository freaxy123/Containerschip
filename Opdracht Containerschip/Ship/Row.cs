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
        private List<int> placingOrder = new List<int>();

        public void initialize(int widthInContainers)
        {
            stacks = new List<Stack>();
            for(int i = 0; i < widthInContainers; i++)
            {
                stacks.Add(new Stack());
            }  
            placingOrder = new Sort().integerToEvenPlacingOrderList(widthInContainers);
        }

        public bool addContainerByStackNumber(int stackNumberInput, IContainer containerInput)
        {
            return stacks[stackNumberInput].addContainer(containerInput); 
        }

        public bool addContainer(IContainer containerInput)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[placingOrder[0]].addContainer(containerInput))
                {
                    updatePlacingOrder();
                    return true;
                }
            }
            return false;
        }

        public bool addContainerBelowValuableWhenExists(IContainer containerInput, IReadOnlyList<Stack> previousStackList)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (previousStackList[placingOrder[0]].containsValuable())
                {
                    if (stacks[placingOrder[0]].getContainerCount() + 1 < previousStackList[placingOrder[0]].getContainerCount())
                    {
                        if (stacks[placingOrder[0]].addContainer(containerInput))
                        {
                            updatePlacingOrder();
                            return true;
                        }
                        else
                        {
                            updatePlacingOrder();
                        }
                    }
                    else
                    {
                        updatePlacingOrder();
                    }
                }
                else
                {
                    if (stacks[placingOrder[0]].addContainer(containerInput))
                    {
                        updatePlacingOrder();
                        return true;
                    }
                    else
                    {
                        updatePlacingOrder();
                    }
                }

            }
            return false;
        }
      
        public void updatePlacingOrder()
        {
            if (placingOrder.Count == 1)
            {
                placingOrder = new Sort().integerToEvenPlacingOrderList(stacks.Count);
            }
            else
            {
                placingOrder.RemoveAt(0);
            }
        }

        public List<int> getAvailableStacksAtCertainHeightIndex(int height)
        {
            List<int> available = new List<int>();

            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[i].getContainer(height) == null)
                {
                    available.Add(i);
                }
            }

            return new Sort().createEvenPlacingOrder(available);
        }

        public IReadOnlyList<Stack> getStacks()
        {
            return stacks.AsReadOnly();
        }

        public int getLeftWeight()
        {
            int weight = 0;
            for (int i = 0; i < (stacks.Count/ 2); i++)
            {
                weight += stacks[i].weight;
            }
            return weight;
        }

        public int getRightWeight()
        {
            int weight = 0;
            int loopcount;
            if (stacks.Count % 2 == 0)
            {
                loopcount = (stacks.Count / 2);
            }
            else
            {
                loopcount = (stacks.Count / 2) + 1;
            }

            for (int i = loopcount; i < stacks.Count; i++)
            {
                weight += stacks[i].weight;
            }
            return weight;
        }

        public int getTotalWeight()
        {
            int weight = 0;
            foreach (Stack stack in stacks)
            {
                weight += stack.weight;
            }
            return weight;
        }
    }
}
