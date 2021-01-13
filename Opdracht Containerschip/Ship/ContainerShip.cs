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
            tempList.AddRange(sort.getContainersSorted2(containers));
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
                    if (!rows[0].addContainer(container))
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
                            if (rows[0].addContainer(leftover))
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
                return rows[row].addContainer(availableStacks[0], inputContainer);
            }
            catch
            {
                return false;
            }            
        }

        public List<int> getAvailableSpotsInStacksAtHeight(int row, int height)
        {
            //if (row > 1 && row < lengthInContainers - 1)
            //{
            //    IReadOnlyList<Stack> test = rows[row - 1].getStacks();
            //    //int aantal = test[row].getContainerCount();
            //    int i = 0;
            //    foreach (Stack stack in test)
            //    {
            //        if ((rows[row].getStacks()[i].getContainerCount() + 1) >= test[i].getContainerCount())
            //        {
            //            available.Remove(i);
            //        }
            //        i++;
            //    }
            //}

            return rows[row].getAvailableStacksIndex(height);
        }


        public bool placeContainerInRowOnTop(int row, IContainer inputContainer)
        {
            return placeContainer(row, getAvailableSpotsInStacksAtHeight(row, 0), inputContainer);
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
            for (int i = 1; i < lengthInContainers; i++)
            {
                if(i == 1)
                {
                    if (rows[i].addContainer(inputContainer))
                    {
                        return true;
                    }
                }
                if (rows[i].addContainer2(inputContainer, rows[i - 1].getStacks()))
                {
                    return true;
                }
            }

            //First row at last
            if (rows[0].addContainer(inputContainer))
            {
                return true;
            }
            return false;
        }
    }
}
