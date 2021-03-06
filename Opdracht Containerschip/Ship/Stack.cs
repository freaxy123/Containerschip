﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    public class Stack
    {
        private int StackNumber;
        private List<IContainer> containers;
        public int weight { get; private set; }

        public Stack(int stackNumber)
        {
            StackNumber = stackNumber;
            containers = new List<IContainer>();
        }

        public bool TryAddContainer(IContainer containerInput)
        {
            if(weight < containerInput.maxWeightOnTop && ContainsValuable() == false)
            {
                containers.Add(containerInput);
                weight += containerInput.weight;
                return true;
            }
            else
            {
                return false;
            }
        }

        public IContainer GetContainer(int height)
        {
            try
            { 
                if(containers[height] != null)
                {
                    return containers[height];
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        public int GetContainerCount()
        {
            return containers.Count();
        }

        public bool ContainsValuable()
        {
            foreach (IContainer container in containers)
            {
                if (container.GetType() == typeof(ContainerValuable))
                {
                    return true;
                }
            }
            return false;
        }

        public IContainer GetAndRemoveLowestContainer()
        {
            IContainer container = containers[containers.Count - 1];
            weight -= containers[containers.Count - 1].weight;
            containers.RemoveAt(containers.Count - 1);
            return container;
        }

        public IReadOnlyList<IContainer> GetContainers()
        {
            return containers.AsReadOnly();
        }

        public override string ToString()
        {
            return $"Stack {StackNumber + 1}"; 
        }

        public string GetStackNumber()
        {
            return $"{StackNumber}";
        }

        public int GetStackNumberAsInt()
        {
            return StackNumber;
        }
    }
}
