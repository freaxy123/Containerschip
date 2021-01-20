using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht_Containerschip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip.Tests
{
    [TestClass()]
    public class RowTests
    {
        [TestMethod()]
        public void AddContainerByStackNumberTest_Twovaluables_ShouldReturnFalse()
        {
            //Arrange
            bool expected = false;
            Row row = new Row();
            row.Initialize(0, 2);

            //Act
            row.AddContainerByStackNumber(0, new ContainerValuable(4000));
            bool actual = row.AddContainerByStackNumber(0, new ContainerValuable(4000));

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddContainerToRowTest_AddContainerToRow_ShouldReturnTrue()
        {
            //Arrange
            bool expected = true;
            bool actual = false;
            Row row = new Row();
            row.Initialize(0, 2);
            Container container = new Container(4000);

            //Act
            row.AddContainerToRow(container);

            //Assert
            if (row.GetStacks()[0].GetContainers()[0] == container)
            {
                actual = true;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddContainerBelowValuableWhenExistsTest_AddValuableNextToValuable_ShouldReturnFalse()
        {
            //Arrange
            bool expected = false;

            Row row = new Row();
            row.Initialize(0, 2);

 
            Stack stack = new Stack(0);
            List<Stack> stacks = new List<Stack>();
            stacks.Add(stack);
            stacks.Add(stack);
            stack.TryAddContainer(new ContainerValuable(4000));

            //Act
            bool actual = row.AddContainerBelowValuableWhenExists(new ContainerValuable(4000), stacks);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}