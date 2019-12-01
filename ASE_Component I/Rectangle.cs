using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Component_I
{
    /// <summary>
    /// making class rectangle and inhereting from shape
    /// </summary>
    public class Rectangle:Shape//inhereting shape class 
    {
        public int l,b,x,y;//defining variable
        /// <summary>
        /// method for taking values of rectangle
        /// </summary>
        /// <param name="q"></param>
        /// <param name="w"></param>
        /// <param name="e"></param>
        /// <param name="r"></param>
        public void values(int q, int w, int e,int r)
        {
            x = q;
            y = w;
            b = e;
            l = r;
        }
        /// <summary>
        /// over riding shaped method for drawing rectangle
        /// </summary>
        /// <param name="g"></param>
        public override void shaped(Graphics g)//for drawing rectangle
        {
            Pen dpen = new Pen(Color.Black, 3);
            g.DrawRectangle(dpen, x, y, b, l);//drawing rectangle 
        }
    }
}
