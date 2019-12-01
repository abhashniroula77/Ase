using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Component_I
{
    /// <summary>
    /// making circle class and inhereting from it
    /// </summary>
   public class Circle: Shape//inhereting  shape class
    {
        public int r, x, y;//initializing variables
        /// <summary>
        /// method for taking values
        /// </summary>
        /// <param name="q"></param>
        /// <param name="w"></param>
        /// <param name="e"></param>
        public void values(int q, int w, int e) { //method for saving values
            x = q;
            y = w;
            r = e;
        }
        /// <summary>
        /// method for drawing circle
        /// </summary>
        /// <param name="g"></param>
        public override void shaped(Graphics g)//overriding drawshape method
        {
            Pen dpen = new Pen(Color.Black,3);
            g.DrawEllipse(dpen, x, y, r, r);//drawing circle 
        }
    }
}
