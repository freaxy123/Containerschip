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
            powerRow = 0;
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
                    if(!placeContainerInRowAtCertainHeight(powerRow, rows[powerRow].getAvailableStacksAtCertainHeightIndex(0), container))
                    {
                        leftovers.Add(container);
                    }
                }
                else if (container.GetType() == typeof(ContainerValuable))
                {
                    if (!placeContainerOnTopOfStacks(container))
                    {
                        leftovers.Add(container);
                    }
                }
                else if (container.GetType() == typeof(ContainerCooled))
                {
                    if (!rows[powerRow].addContainer(container))
                    {
                        leftovers.Add(container);
                    }
                }
                else
                {
                    if (!placeRemainingContainer(container))
                    {
                        leftovers.Add(container);
                    }
                }
            }
        }

        public bool placeContainerInRowAtCertainHeight(int row, List<int> availableStacks, IContainer inputContainer)
        {
            try
            {
                return rows[row].addContainerByStackNumber(availableStacks[0], inputContainer);
            }
            catch
            {
                return false;
            }            
        }


        public bool placeContainerOnTopOfStacks(IContainer inputContainer)
        {
            for (int i = 1; i < lengthInContainers; i++)
            {
                
                if (placeContainerInRowAtCertainHeight(i, rows[i].getAvailableStacksAtCertainHeightIndex(0), inputContainer))
                {
                    return true;
                }
            }
            return false;
        }

        public bool placeRemainingContainer(IContainer inputContainer)
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
                if (rows[i].addContainerBelowValuableWhenExists(inputContainer, rows[i - 1].getStacks()))
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

        public void getWeightPercentages()
        {
            decimal weightLeft = 0;
            decimal weightRight = 0;

            foreach(Row row in rows)
            {
                weightLeft += row.getLeftWeight();
                weightRight += row.getRightWeight();
            }

            decimal totalWeight = getTotalWeight();

            decimal weightPercentageLeft = (weightLeft / totalWeight) * 100;
            decimal weightPercentageRight = (weightRight / totalWeight) * 100;

            Console.WriteLine("Totalweight is: " + totalWeight);
            Console.WriteLine("Weightpercentage left is: " + weightPercentageLeft);
            Console.WriteLine("Weightpercentage right is: " + weightPercentageRight);
        }

        public int getTotalWeight()
        {
            int totalWeight = 0;
            foreach (Row row in rows)
            {
                totalWeight += row.getTotalWeight();
            }
            return totalWeight;
        }
    }
}
