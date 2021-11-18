using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace individual_task_1.Shapes.Polygons
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public override void StartDraw(float x, float y)
        {
            _points = new List<PointF>();
            _points.Add(new PointF(x, y));
            _points.Add(new PointF(x, y));
            _points.Add(new PointF(x, y));
            _points.Add(new PointF(x, y));
        }

        public override void Adjustment(float x, float y)
        {
            _points[1] = new PointF(x, _points[0].Y);
            _points[2] = new PointF(x, y);
            _points[3] = new PointF(_points[0].X, y);
        }

        protected override PointF[] GetPoints()
        {
            PointF[] result = _points.ToArray();
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = result[0];
            return result;
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLines(new Pen(drawColor, 2), this.GetPoints());
        }

        public override string ToString()
        {
            return "Прямоугольник\n" + base.ToString();
        }
    }
}
