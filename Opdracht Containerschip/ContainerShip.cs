using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class ContainerShip : IContainerTransport
    {
        public int powerRow { get; private set; }
        public int capsizeWeightPercentage { get; private set; }
        public int weightbalancePercentage { get; private set; }
        public int lengthInContainers { get; private set; }
        public int widthInContainers { get; private set; }
        public List<Row> rows { get; private set; }
        private List<IContainer> containers;

        public ContainerShip(int lengthInContainers, int widthInContainers, List<IContainer> containers)
        {
            powerRow = 1;
            capsizeWeightPercentage = 50;
            weightbalancePercentage = 20;
            this.lengthInContainers = lengthInContainers;
            this.widthInContainers = widthInContainers;
            this.containers = containers;
            initialize();
        }

        public void sortContainers()
        {
            Sort sort = new Sort();
            List<IContainer> tempList = new List<IContainer>();

            //Sort
            tempList.AddRange(sort.getContainersCooledValuableSorted(containers));
            tempList.AddRange(sort.getContainersValuableSorted(containers));
            tempList.AddRange(sort.getContainersCooledSorted(containers));
            tempList.AddRange(sort.getContainersSorted(containers));
            containers = tempList;  //Update ship list
        }

        public void initialize()
        {
            rows = new List<Row>();
            for(int i = 0; i < lengthInContainers; i++)
            {
                rows.Add(new Row());
            }
            foreach(Row row in rows)
            {
                row.initialize(widthInContainers);
            }    
        }

        public void placeContainers()
        {
            List<IContainer> leftovers = new List<IContainer>();
            foreach (IContainer container in containers)
            {
                if (container.GetType() == typeof(ContainerCooledValuable))
                {
                    if(!placeContainerInRowOnTop(0, container))
                    {
                        leftovers.Add(container);
                    }
                }
                else if (container.GetType() == typeof(ContainerValuable))
                {
                    if (!placeValuableContainer(container))
                    {
                        leftovers.Add(container);
                    }
                }
                else if (container.GetType() == typeof(ContainerCooled))
                {
                    if (!placeContainerInRow(0, container))
                    {
                        leftovers.Add(container);
                    }
                }
                else
                {
                    if (!placeNormalContainers(container))
                    {
                        leftovers.Add(container);
                    }
                }
            }
            if (leftovers.Count > 1)
            {

                int previousleftovercount = 0;
                while (leftovers.Count != previousleftovercount)
                {
                    List<IContainer> tempLeftovers = new List<IContainer>(leftovers);
                    previousleftovercount = leftovers.Count;
                    foreach (IContainer leftover in leftovers)
                    {
                        if (leftover.GetType() == typeof(ContainerCooledValuable))
                        {
                            if (placeContainerInRowOnTop(0, leftover))
                            {
                                tempLeftovers.Remove(leftover);
                            }
                        }
                        else if (leftover.GetType() == typeof(ContainerValuable))
                        {
                            if (placeValuableContainer(leftover))
                            {
                                tempLeftovers.Remove(leftover);
                            }
                        }
                        else if (leftover.GetType() == typeof(ContainerCooled))
                        {
                            if (placeContainerInRow(0, leftover))
                            {
                                tempLeftovers.Remove(leftover);
                            }
                        }
                        else
                        {
                            if (placeNormalContainers(leftover))
                            {
                                tempLeftovers.Remove(leftover);
                            }
                        }
                    }
                    leftovers = tempLeftovers;
                }
            }
        }

        public bool placeContainer(int row, List<int> availableStacks, IContainer inputContainer)
        {
            try
            {
                if(rows[row].addContainer(availableStacks[0], inputContainer) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }            
        }

        public List<int> getAvailableSpots(int row, int height)
        {
            List<int> available = rows[row].getAvailableStacks(height);
            if(row > 1 && row < lengthInContainers - 1)
            {
                IReadOnlyList<Stack> test = rows[row - 1].getStacks();
                //int aantal = test[row].getContainerCount();
                int i = 0;
                foreach(Stack stack in test)
                {
                    if((rows[row].getStacks()[i].getContainerCount() + 1) >= test[i].getContainerCount())
                    {
                        available.Remove(i);
                    }
                    i++;
                }                
            }
            //Stacks opeenvolgende rij is groter dan stacks vorige rij, remove top availability
            return available;
        }

        public bool placeContainerInRow(int row, IContainer inputContainer)
        {
            for(int i = 0; i < widthInContainers; i++)
            {
                if(placeContainer(row, getAvailableSpots(row, i), inputContainer))
                {
                    return true;
                }
            }
            return false;
        }

        public bool placeContainerInRowOnTop(int row, IContainer inputContainer)
        {
            if (placeContainer(row, getAvailableSpots(row, 0), inputContainer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool placeValuableContainer(IContainer inputContainer)
        {
            if (placeContainerInRowOnTop(lengthInContainers - 1, inputContainer) == true)
            {
                return true;
            }
            else
            {
                for (int i = 1; i < lengthInContainers; i++)
                {
                    if (placeContainerInRowOnTop(i, inputContainer))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool placeNormalContainers(IContainer inputContainer)
        {
            for (int i = 0; i < lengthInContainers; i++)
            {
                if(placeContainerInRow(i, inputContainer))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
