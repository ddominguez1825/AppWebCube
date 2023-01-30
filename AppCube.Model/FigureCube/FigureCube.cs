using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNV.Model.FigureCube
{
    public class FigureCube : DNV.Model.Figure.Figure
    {

        public FigureCube(int coordinate_x, int coordinate_y, int coordinate_z, int numberDimension):base(coordinate_x, coordinate_y, coordinate_z, numberDimension) { }   


        public override  float GetVolume() 
        { 
            //Calculate volume cube
            return 0; 
        }
    }
}
