using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class Row
    {
        private int RowNumber;
        private List<Stack> stacks;
        private List<int> stackPlacingOrder = new List<int>();

        public void Initialize(int rowNumber, int widthInContainers)
        {
            RowNumber = rowNumber;
            stacks = new List<Stack>();
            for(int i = 0; i < widthInContainers; i++)
            {
                stacks.Add(new Stack(i));
            }  
            stackPlacingOrder = new Sort().integerToEvenPlacingOrderList(widthInContainers);
        }

        public bool AddContainerByStackNumber(int stackNumberInput, IContainer containerInput)
        {
            return stacks[stackNumberInput].TryAddContainer(containerInput); 
        }

        public bool AddContainerToRow(IContainer containerInput)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[stackPlacingOrder[0]].TryAddContainer(containerInput))
                {
                    UpdateStackPlacingOrder();
                    return true;
                }
            }
            return false;
        }

        public bool AddContainerBelowValuableWhenExists(IContainer containerInput, IReadOnlyList<Stack> previousRowStackList)
        {
            for (int i = 0; i < stacks.Count; i++)
            {
                if (IsPreviousRowValuable(stackPlacingOrder[0], previousRowStackList))
                {
                    if (IsPreviousRowHigher(stackPlacingOrder[0], previousRowStackList))
                    {
                        if (stacks[stackPlacingOrder[0]].TryAddContainer(containerInput))
                        {
                            UpdateStackPlacingOrder();
                            return true;
                        }
                        else
                        {
                            UpdateStackPlacingOrder();
                        }
                    }
                    else
                    {
                        UpdateStackPlacingOrder();
                    }
                }
                else
                {
                    if (stacks[stackPlacingOrder[0]].TryAddContainer(containerInput))
                    {
                        UpdateStackPlacingOrder();
                        return true;
                    }
                    else
                    {
                        UpdateStackPlacingOrder();
                    }
                }
            }
            return false;
        }

        public bool IsPreviousRowValuable(int stack, IReadOnlyList<Stack> previousStackList)
        {
            try
            {
                return previousStackList[stack].ContainsValuable();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<int> AreTwoValuableContainersNextToEachother(IReadOnlyList<Stack> previousStackList)
        {
            List<int> nextToValuable = new List<int>();
            for (int i = 0; i < stacks.Count; i++)
            {
                if(stacks[i].ContainsValuable() & previousStackList[i].ContainsValuable())
                {
                    if(stacks[i].GetContainerCount() == previousStackList[i].GetContainerCount())
                    {
                        nextToValuable.Add(i);
                    }
                }
            }

            return nextToValuable;
        }

        public bool IsPreviousRowHigher(int stack, IReadOnlyList<Stack> previousStackList)
        {
            if (stacks[stack].GetContainerCount() + 1 < previousStackList[stack].GetContainerCount())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateStackPlacingOrder()
        {
            if (stackPlacingOrder.Count == 1)
            {
                stackPlacingOrder = new Sort().integerToEvenPlacingOrderList(stacks.Count);
            }
            else
            {
                stackPlacingOrder.RemoveAt(0);
            }
        }

        public List<int> GetAvailableStacksAtCertainHeight(int height)
        {
            List<int> available = new List<int>();

            for (int i = 0; i < stacks.Count; i++)
            {
                if (stacks[i].GetContainer(height) == null)
                {
                    available.Add(i);
                }
            }

            return new Sort().createEvenPlacingOrder(available);
        }

        public IReadOnlyList<Stack> GetStacks()
        {
            return stacks.AsReadOnly();
        }

        public int GetLeftWeight()
        {
            int weight = 0;
            for (int i = 0; i < (stacks.Count/ 2); i++)
            {
                weight += stacks[i].weight;
            }
            return weight;
        }

        public int GetRightWeight()
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

        public int GetTotalWeight()
        {
            int weight = 0;
            foreach (Stack stack in stacks)
            {
                weight += stack.weight;
            }
            return weight;
        }

        public override string ToString()
        {
            return $"Row {RowNumber + 1}";
        }
    }
}
