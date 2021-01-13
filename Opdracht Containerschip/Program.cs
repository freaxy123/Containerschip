using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_Containerschip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Testing
            
            
            Console.WriteLine("test");
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));


            containers.Add(new Container(12000));
            containers.Add(new Container(12000));
            containers.Add(new Container(12000));

            containers.Add(new ContainerCooled(30000));
            containers.Add(new ContainerCooled(10000));
            containers.Add(new ContainerCooled(10000));
            containers.Add(new ContainerCooled(30000));
            containers.Add(new ContainerCooled(10000));
            containers.Add(new ContainerCooled(10000));
            containers.Add(new ContainerCooled(30000));
            containers.Add(new ContainerCooled(10000));
            containers.Add(new ContainerCooled(10000));


            containers.Add(new ContainerCooledValuable(4000));
            containers.Add(new ContainerCooledValuable(25000));
            containers.Add(new ContainerCooledValuable(4000));
            containers.Add(new ContainerCooledValuable(25000));
            containers.Add(new ContainerCooledValuable(4000));
            containers.Add(new ContainerCooledValuable(25000));

            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));
            containers.Add(new ContainerValuable(10000));

            Console.WriteLine("made list");
            ContainerShip ship = new ContainerShip(4, 4, containers);
            ship.sortContainers();
            ship.placeContainers();
            //ship.placeContainerInRow(0, new ContainerCooledValuable(25000));
            //ship.placeContainerInRow(0, new ContainerCooledValuable(25000));
            //ship.placeContainerInRow(0, new ContainerCooledValuable(25000));
            

            //ship.pyramidPattern(13);




            //Start forms
            Application.Run(new Form1());

            
        }
    }
}
