using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace individual_task_1.Shapes
{
    public abstract class Shape: Object
    {

        protected Color drawColor;
        protected List<PointF> _points;

        public abstract void StartDraw(float x, float y);
        public abstract void Adjustment(float x, float y);
        public abstract void Draw(Graphics g);


        public void SetColor(Color color)
        {
            drawColor = color;
        }

        protected virtual PointF[] GetPoints()
        {
            PointF[] result = _points.ToArray();
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = result[0];
            return result;
        }

        public Shape Clone()
        {
            return MemberwiseClone() as Shape;
        }

        public override string ToString()
        {
            return String.Join("\n", _points);
        }

    }
}
