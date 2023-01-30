using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNV.Model.Interface
{
    public  interface FabricFigure
    {
        FigureCube.FigureCube createCube(int coordinate_x, int coordinate_y, int coordinate_z, int numberDimension);

    }
}
