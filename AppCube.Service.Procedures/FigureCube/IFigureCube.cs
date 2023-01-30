using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNV.Service.Procedures.FigureCube
{
    public  interface IFigureCube
    {
        bool CollidTwoCubes(FigureCube fdto1, FigureCube fdto2);
    }
}
