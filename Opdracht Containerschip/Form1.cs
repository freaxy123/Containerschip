using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_Containerschip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<IContainer> containers = new List<IContainer>();
        ContainerShip ship;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddContainer_Click(object sender, EventArgs e)
        {
            if (radioButtonContainer.Checked)
            {
                for (int i = 0; i < Convert.ToInt32(numericUpDownContainerAmount.Value); i++)
                {
                    containers.Add(new Container(Convert.ToInt32(numericUpDownContainerWeight.Value)));
                }
                
            }
            else if (radioButtonCooledContainer.Checked)
            {
                for (int i = 0; i < Convert.ToInt32(numericUpDownContainerAmount.Value); i++)
                {
                    containers.Add(new ContainerCooled(Convert.ToInt32(numericUpDownContainerWeight.Value)));
                }
            }
            else if (radioButtonValuableContainer.Checked)
            {
                for (int i = 0; i < Convert.ToInt32(numericUpDownContainerAmount.Value); i++)
                {
                    containers.Add(new ContainerValuable(Convert.ToInt32(numericUpDownContainerWeight.Value)));
                }
            }
            else if (radioButtonCooledValuableContainer.Checked)
            {
                for (int i = 0; i < Convert.ToInt32(numericUpDownContainerAmount.Value); i++)
                {
                    containers.Add(new ContainerCooledValuable(Convert.ToInt32(numericUpDownContainerWeight.Value)));
                }
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(numericUpDownContainerAmount.Value); i++)
                {
                    containers.Add(new Container(Convert.ToInt32(numericUpDownContainerWeight.Value)));
                }
            }

            //Change listbox
            listBoxContainersInput.DataSource = null;
            listBoxContainersInput.DataSource = containers;

        }

        private void buttonGenerateLayout_Click(object sender, EventArgs e)
        {
            labelCalculating.Text = "Calculating...";

            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(30000));
            //containers.Add(new Container(4000));
            //containers.Add(new Container(4000));


            //containers.Add(new ContainerCooled(4000));
            //containers.Add(new ContainerCooled(4000));
            //containers.Add(new ContainerCooled(4000));
            //containers.Add(new ContainerCooled(4000));

            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(30000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));
            //containers.Add(new ContainerValuable(4000));

            //containers.Add(new ContainerCooledValuable(4000));
            //containers.Add(new ContainerCooledValuable(25000));
            //containers.Add(new ContainerCooledValuable(4000));

            

            //ship = new ContainerShip(4, 4, containers);

            //Stop testing

            ship = new ContainerShip(Convert.ToInt32(numericUpDownShipLength.Value), Convert.ToInt32(numericUpDownShipWidth.Value), containers);

            listBoxRows.DataSource = ship.GetRows();
            listBoxLeftoverContainers.DataSource = ship.GetLeftoverContainers();

            //Set labels
            labelWeightPercentageLeft.Text = $"Weightpercentage Left: {ship.GetLeftWeightPercentage()}";
            labelWeightPercentageRight.Text = $"Weightpercentage Right: {ship.GetRightWeightPercentage()}";
            labelTotalWeight.Text = $"Total Used Weight: {ship.GetTotalWeight()}";
            labelFinalCheck.Text = ship.FinalCheck();
            labelCalculating.Text = "";
        }

        private void listBoxStacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stack selected = (Stack)Convert.ChangeType(listBoxStacks.SelectedItem, typeof(Stack));
            listBoxContainers.DataSource = selected.GetContainers(); 
        }

        private void listBoxRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row selected = (Row)Convert.ChangeType(listBoxRows.SelectedItem, typeof(Row));
            listBoxStacks.DataSource = selected.GetStacks();
            
        }
        
    }
}
