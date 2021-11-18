using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual_task_1.Shapes
{
    public class Point
    {
        private float _offsetY = 241;
        private float _offsetX = 241;
        private float _x;
        private float _y;
        static Random rnd = new Random();
        public Point(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public Point()
        {
            _x = rnd.Next(1,11);
            _y = rnd.Next(1, 11);
        }

        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }

        public override string ToString()
        {
            return $"Точка\nКоордината точки X: {X} Координаты точки Y: {Y}";
        }
    }
}
