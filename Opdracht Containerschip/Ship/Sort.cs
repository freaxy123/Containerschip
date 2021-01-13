using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    class Sort
    {
        
        public List<Container> getContainersSorted(List<IContainer> containers)
        {
            List<IContainer> clonedList = new List<IContainer>(containers);
            List<Container> sortedList = new List<Container>();

            foreach (Container container in containers.OfType<Container>())
            {
                Container maxContainer = getMaxWeightContainer(clonedList);
                sortedList.Add(maxContainer);
                clonedList.Remove(maxContainer);
            }
            return sortedList;
        }

        public List<Container> getContainersSorted2(List<IContainer> containers)
        {
            List<IContainer> clonedList = new List<IContainer>(containers);
            List<Container> sortedList = new List<Container>();

            foreach (Container container in containers.OfType<Container>())
            {
                Container minimumContainer = getMinimumWeightContainer(clonedList);
                sortedList.Add(minimumContainer);
                clonedList.Remove(minimumContainer);
            }
            return sortedList;
        }

        public List<ContainerCooled> getContainersCooledSorted(List<IContainer> containers)
        {
            List<IContainer> clonedList = new List<IContainer>(containers);
            List<ContainerCooled> sortedList = new List<ContainerCooled>();

            foreach (ContainerCooled container in containers.OfType<ContainerCooled>())
            {
                ContainerCooled maxContainerCooled = getMaxWeightContainerCooled(clonedList);
                sortedList.Add(maxContainerCooled);
                clonedList.Remove(maxContainerCooled);
            }
            return sortedList;
        }

        public List<ContainerValuable> getContainersValuableSorted(List<IContainer> containers)
        {
            List<IContainer> clonedList = new List<IContainer>(containers);
            List<ContainerValuable> sortedList = new List<ContainerValuable>();

            foreach (ContainerValuable container in containers.OfType<ContainerValuable>())
            {
                ContainerValuable maxContainerValuable = getMaxWeightContainerValuable(clonedList);
                sortedList.Add(maxContainerValuable);
                clonedList.Remove(maxContainerValuable);
            }
            return sortedList;
        }

        public List<ContainerCooledValuable> getContainersCooledValuableSorted(List<IContainer> containers)
        {
            List<IContainer> clonedList = new List<IContainer>(containers);
            List<ContainerCooledValuable> sortedList = new List<ContainerCooledValuable>();

            foreach (ContainerCooledValuable container in containers.OfType<ContainerCooledValuable>())
            {
                ContainerCooledValuable maxContainerCooled = getMaxWeightContainerCooledValuable(clonedList);
                sortedList.Add(maxContainerCooled);
                clonedList.Remove(maxContainerCooled);
            }
            return sortedList;
        }

        public Container getMaxWeightContainer(List<IContainer> containers)
        {
            int maxWeight = 0;
            Container maxWeightContainer = null;
            foreach (Container container in containers.OfType<Container>())
            {
                if (container.weight > maxWeight)
                {
                    maxWeightContainer = container;
                    maxWeight = container.weight;
                }
            }
            return maxWeightContainer;
        }

        public Container getMinimumWeightContainer(List<IContainer> containers)
        {
            bool firstContainer = false;
            int minimumWeight = 0;
            Container minimumWeightContainer = null;
            foreach (Container container in containers.OfType<Container>())
            {
                if(firstContainer == false)
                {
                    minimumWeight = container.weight;
                    minimumWeightContainer = container;
                    firstContainer = true;
                }
                else if (container.weight < minimumWeight)
                {
                    minimumWeightContainer = container;
                    minimumWeight = container.weight;
                }
            }
            return minimumWeightContainer;
        }

        public ContainerCooled getMaxWeightContainerCooled(List<IContainer> containers)
        {
            int maxWeight = 0;
            ContainerCooled maxWeightContainer = null;
            foreach (ContainerCooled container in containers.OfType<ContainerCooled>())
            {
                if (container.weight > maxWeight)
                {
                    maxWeightContainer = container;
                    maxWeight = container.weight;
                }
            }
            return maxWeightContainer;
        }

        public ContainerValuable getMaxWeightContainerValuable(List<IContainer> containers)
        {
            int maxWeight = 0;
            ContainerValuable maxWeightContainer = null;
            foreach (ContainerValuable container in containers.OfType<ContainerValuable>())
            {
                if (container.weight > maxWeight)
                {
                    maxWeightContainer = container;
                    maxWeight = container.weight;
                }
            }
            return maxWeightContainer;
        }

        public ContainerCooledValuable getMaxWeightContainerCooledValuable(List<IContainer> containers)
        {
            int maxWeight = 0;
            ContainerCooledValuable maxWeightContainer = null;
            foreach (ContainerCooledValuable container in containers.OfType<ContainerCooledValuable>())
            {
                if (container.weight > maxWeight)
                {
                    maxWeightContainer = container;
                    maxWeight = container.weight;
                }
            }
            return maxWeightContainer;
        }

        public List<int> evenPlaceOrder(List<int> intList)
        {
            List<int> tempList = new List<int>(intList);
            List<int> rightOrder = new List<int>();
            int loopCount = tempList.Count;

            bool switcher = false;
            for (int i = 0; i < loopCount; i++)
            {
                if (switcher)
                {
                    rightOrder.Add(tempList[tempList.Count - 1]);
                    tempList.RemoveAt(tempList.Count - 1);
                    switcher = false;
                }
                else
                {
                    rightOrder.Add(tempList[0]);
                    tempList.RemoveAt(0);
                    switcher = true;
                }
            }

            return rightOrder;
        }

        public List<int> integerToEvenPlaceOrderList(int count)
        {
            List<int> intlist = new List<int>();
            for (int i = 0; i < count; i++)
            {
                intlist.Add(i);
            }
            return evenPlaceOrder(intlist);
        }
    }
}
