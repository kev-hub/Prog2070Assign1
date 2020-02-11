using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2070Assign1
{
       public  class Circle
       {
        public int radius;

        public Circle()
        {
            radius = 1;
        }
        /// <summary>
        /// Gets the Radis of the circle
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            int currentRadius;
            currentRadius = radius;
            return currentRadius;
        }
        /// <summary>
        /// Sets the radius the user Selected
        /// </summary>
        /// <param name="radius"></param>
        public void SetRadius(int radius2)
        {


            radius = radius2;
        }
        /// <summary>
        /// gets the circumfrence of the radius
        /// </summary>
        /// <returns></returns>
        public double GetCircumference()
        {
            double Circumfrence;
            Circumfrence = (GetRadius() * 2) * Math.PI;
            Circumfrence = Math.Round(Circumfrence, 2);
            return Circumfrence;
        }
        /// <summary>
        /// gets the area
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double area;
            area = Math.PI * GetRadius() * GetRadius();
            area = Math.Round(area, 2);
            return area;
        }
    }
}
