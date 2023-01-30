using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNV.Model.Figure
{
public abstract class Figure
    {

        protected int coordinate_x; //coordena
        protected int coordinate_y;
        protected int coordinate_z;
        protected int numberDimension;

        public Figure(int coordinate_x, int coordinate_y, int coordinate_z,int numberDimension) {
        
            this.coordinate_x = coordinate_x;            
            this.coordinate_y = coordinate_y;
            this.coordinate_z= coordinate_z;
            this.numberDimension = numberDimension;
        }

        /// <summary>
        /// Calculate figure's volume 
        /// </summary>
        /// <returns></returns>
        public abstract float  GetVolume();


    }
}
