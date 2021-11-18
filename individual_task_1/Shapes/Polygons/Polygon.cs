using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace individual_task_1.Shapes.Polygons
{
    public class Polygon: Shape
    {
        

        public Polygon()
        {

        }
        public override void StartDraw(float x, float y)
        {
            _points = new List<PointF>();
            int count = 6;  //текстбокс "Количество вершин"
            float length = 5;//текстбокс "Длина стороны"
            double R = length / (2 * Math.Sin(Math.PI / count)); //Радиус описанной окружности
            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / count) //цикл по углу
            {
                float pointX = (float)(R * Math.Cos(angle)); //расчет координаты x точки
                float pointY = (float)(R * Math.Sin(angle)); //расчет координаты y точки
                _points.Add(new PointF((float)(R + pointX+x), (float)(R + pointY+y))); //добавление точки в список точек
            }

        }

        public override void Adjustment(float x, float y)
        {
            int count = 6;  //текстбокс "Количество вершин"
            float length = 5;//текстбокс "Длина стороны"
            double R = length / (2 * Math.Sin(Math.PI / count)); //Радиус описанной окружности
            for (double angle = 0.0; angle <= 2 * Math.PI; angle += 2 * Math.PI / count) //цикл по углу
            {
                float pointX = (float)(R * Math.Cos(angle)); //расчет координаты x точки
                float pointY = (float)(R * Math.Sin(angle)); //расчет координаты y точки
                _points.Add(new PointF((float)(R + pointX + x), (float)(R + pointY + y))); //добавление точки в список точек
            }
            //_points[1] = new PointF(x, _points[0].Y);
            //_points[2] = new PointF(x, y);
            //_points[3] = new PointF(_points[0].X, y);
            //_points[4] = new PointF(x, _points[0].Y);
            //_points[5] = new PointF(x, y);

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
            g.DrawPolygon(Pens.Red, _points.ToArray());

        }

        public override string ToString()
        {
            return "Прямоугольник\n" + base.ToString();
        }

    }
}
