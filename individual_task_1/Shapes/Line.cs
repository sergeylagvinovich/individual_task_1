using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using individual_task_1.Shapes;

namespace individual_task_1.Shapes
{
    public class Line: Shape
    {
        public Line()
        {

        }

        public override void Adjustment(float x, float y)
        {
            _points[1] = new PointF(x, y);
        }
     
        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLines(new Pen(drawColor, 2), _points.ToArray());
        }

        public override void StartDraw(float x, float y)
        {
            _points = new List<PointF>();
            _points.Add(new PointF(x,y));
            _points.Add(new PointF(x, y));
        }

        public override string ToString()
        {
            return $"";
        }




    }
}
