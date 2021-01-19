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
        public int MaxWeight { get; private set; }
        public int MinimumWeight { get; private set; }
        public int weightbalancePercentage { get; private set; }
        public int lengthInContainers { get; private set; }
        public int widthInContainers { get; private set; }
        public List<Row> rows { get; private set; }
        private List<IContainer> containers;
        List<IContainer> leftoverContainers;

        public ContainerShip(int lengthInContainers, int widthInContainers, List<IContainer> containers)
        {
            powerRow = 0;
            capsizeWeightPercentage = 50;
            weightbalancePercentage = 20;
            this.lengthInContainers = lengthInContainers;
            this.widthInContainers = widthInContainers;
            this.containers = containers;
            leftoverContainers = new List<IContainer>();
            MaxWeight = lengthInContainers * widthInContainers * 150000;
            MinimumWeight = MaxWeight / 2;

            InitializeRows();
            InitializeStacks();

            SortContainers();
            PlaceContainers();

            TryMakePyramidIfDoesntExist();
            deleteLeftOverValuableNextToValuable(getValuablenextToValuable());
        }

        public void SortContainers()
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

        public void InitializeRows()
        {
            rows = new List<Row>();

            for(int i = 0; i < lengthInContainers; i++)
            {
                rows.Add(new Row());
            }
        }

        public void InitializeStacks()
        {
            for (int i = 0; i < rows.Count; i++)
            {
                rows[i].Initialize(i, widthInContainers);
            }
        }

        public void PlaceContainers()
        {
            foreach (IContainer container in containers)
            {
                switch (container.Containername())
                {
                    case "ContainerCooledValuable":
                        if (!PlaceContainerInRowAtCertainHeight(powerRow, rows[powerRow].GetAvailableStacksAtCertainHeight(0), container))
                        {
                            leftoverContainers.Add(container);
                        }
                        break;
                    case "ContainerValuable":
                        if (!PlaceContainerOnTopOfStacks(container))
                        {
                            leftoverContainers.Add(container);
                        }
                        break;
                    case "ContainerCooled":
                        if (!rows[powerRow].AddContainerToRow(container))
                        {
                            leftoverContainers.Add(container);
                        }
                        break;
                    case "Container":
                        if (!PlaceRemainingContainer(container))
                        {
                            leftoverContainers.Add(container);
                        }
                        break;
                    default:
                        if (!PlaceRemainingContainer(container))
                        {
                            leftoverContainers.Add(container);
                        }
                        break;
                }
            }
        }

        public bool PlaceContainerInRowAtCertainHeight(int row, List<int> availableStacks, IContainer inputContainer)
        {
            try
            {
                return rows[row].AddContainerByStackNumber(availableStacks[0], inputContainer);
            }
            catch
            {
                return false;
            }            
        }

        public bool PlaceContainerOnTopOfStacks(IContainer inputContainer)
        {
            for (int i = 1; i < lengthInContainers; i++)
            {
                if (PlaceContainerInRowAtCertainHeight(i, rows[i].GetAvailableStacksAtCertainHeight(0), inputContainer))
                {
                    return true;
                }
            }
            return false;

        }

        public bool PlaceRemainingContainer(IContainer inputContainer)
        {
            for (int i = 1; i < lengthInContainers; i++)
            {
                if (rows[i].AddContainerBelowValuableWhenExists(inputContainer, rows[i - 1].GetStacks()))
                {
                    return true;
                }
            }

            //First row at last, 2nd row gets small weight high pile
            if (rows[0].AddContainerToRow(inputContainer))
            {
                return true;
            }
            return false;
        }

        public int GetLeftWeightPercentage()
        {
            decimal weightLeft = 0;

            foreach (Row row in rows)
            {
                weightLeft += row.GetLeftWeight();
            }

            decimal totalWeight = GetTotalWeight();

            decimal weightPercentageLeft = (weightLeft / totalWeight) * 100;

            return Convert.ToInt32(weightPercentageLeft); 
        }

        public int GetRightWeightPercentage()
        {
            decimal weightRight = 0;

            foreach (Row row in rows)
            {
                weightRight += row.GetRightWeight();
            }

            decimal totalWeight = GetTotalWeight();

            decimal weightPercentageRight = (weightRight / totalWeight) * 100;

            return Convert.ToInt32(weightPercentageRight);
        }

        public int GetTotalWeight()
        {
            int totalWeight = 0;
            foreach (Row row in rows)
            {
                totalWeight += row.GetTotalWeight();
            }
            return totalWeight;
        }

        public IReadOnlyList<Row> GetRows()
        {
            return rows.AsReadOnly();
        }

        public IReadOnlyList<IContainer> GetLeftoverContainers()
        {
            return leftoverContainers.AsReadOnly();
        }

        public bool WeightBalanceCheck()
        {
            int sum1 = GetLeftWeightPercentage() - GetRightWeightPercentage();
            if (sum1 < 0)
            {
                if(sum1 > -20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (sum1 < 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string FinalCheck()
        {
            if (!WeightBalanceCheck()) 
            {
                return "Ship is not in balance";
            }
            else if(!(GetTotalWeight() >= MinimumWeight))
            {
                return "Need more weight!";
            }
            else
            {
                return "Ship is ready to go";
            }

        }

        public List<Row> getValuablenextToValuable()
        {
            List<Row> data1 = new List<Row>();
            for (int i = 2; i < rows.Count; i++)
            {
                data1.Add(rows[i].AreTwoValuableContainersNextToEachother(rows[i - 1].GetStacks()));
            }
            return data1;
        }

        public void TryMakePyramidIfDoesntExist()
        {
            for (int i = 1; i < (rows.Count + 1); i++)//Aantal rows
            {
                try
                {
                    for (int j = 0; j < rows[i - 1].GetStacks().Count; j++)//Per stack(i-1, want index begint 0)
                    {
                        while (true)
                        {
                            if ((rows[i + 1].GetStacks()[j].GetContainerCount() + 1) < (rows[i].GetStacks()[j].GetContainerCount() - 1))
                            {
                                IContainer tempcontainer = rows[i].GetAndRemoveContainerFromStack(j);

                                if (!rows[i + 1].AddContainerByStackNumber(j, tempcontainer))
                                {
                                    leftoverContainers.Add(tempcontainer);
                                }
                            }
                            if ((rows[i].GetStacks()[j].GetContainerCount() + 1) < (rows[i - 1].GetStacks()[j].GetContainerCount() - 1))
                            {
                                IContainer tempcontainer = rows[i - 1].GetAndRemoveContainerFromStack(j);

                                if (!rows[i].AddContainerByStackNumber(j, tempcontainer))
                                {
                                    leftoverContainers.Add(tempcontainer);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
                catch (Exception)
                {

                }
            }

        }

        public void deleteLeftOverValuableNextToValuable(List<Row> rowsWithValuable)
        {
            int OmdeTweeRows = 0;
            for (int i = 1; i < (rowsWithValuable.Count + 1); i++)//Aantal rows
            {
                for (int j = 0; j < rowsWithValuable[i - 1].GetStacks().Count; j++)//Per stack(i-1, want index begint 0)
                {
                    if (OmdeTweeRows == 0)
                    {
                        leftoverContainers.Add(rows[i].GetAndRemoveContainerFromStack(j));
                        OmdeTweeRows++;
                    }
                    else if (OmdeTweeRows == 2)
                    {
                        OmdeTweeRows = 0;
                    }
                    else
                    {
                        OmdeTweeRows++;
                    }

                }
            }
        }
    }
}

