using individual_task_1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual_task_1.Buttons.DrawTools
{
    public class DrawTool
    {
        private Shapes.Shape currentShape;

        public Shape CurrentShape { get => currentShape; set => currentShape = value; }
    }
}
