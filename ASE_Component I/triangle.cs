using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Component_I
{
  public class Triangle : Shape
    {
        /// <summary>
        ///
        /// </summary>
        public int val1 , val2, bas, perp, hypt;

        /// <summary>
        ///
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>

        public void values(int x, int y, int z, int w)
        {
            val1 = x;
            val2 = y;
            bas = z;
            perp = w;
        }

        public override void shaped(Graphics g)
        {
            Pen tri1 = new Pen(Color.Black, 3);
            PointF A = new Point(val1, val2);
            PointF B = new PointF(val1 + perp, val2);
            PointF C = new PointF(B.X, B.Y + perp);
            PointF[] cho = { A, B, C };
            g.DrawPolygon(tri1, cho);

        }

        
    }
}
