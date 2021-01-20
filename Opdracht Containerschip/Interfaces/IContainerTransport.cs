using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Containerschip
{
    public interface IContainerTransport
    {
        int powerRow { get; }
        int capsizeWeightPercentage{ get; }
        int weightbalancePercentage { get; }
        int lengthInContainers { get; }
        int widthInContainers { get; }
        List<Row> rows { get; }
    }
}
