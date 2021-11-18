using individual_task_1.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_task_1.Buttons
{
    public class ButtonRectangle: Button
    {
        private DrawTools.DrawTool drawTool;

        public ButtonRectangle(DrawTools.DrawTool drawTool, Control parent)
        {
            this.drawTool = drawTool;
            this.Text = "Прямоугольник";
            this.Parent = parent;
            this.Dock = DockStyle.Top;
        }

        protected override void OnClick(EventArgs e)
        {
            drawTool.CurrentShape = new Shapes.Polygons.Rectangle();
            base.OnClick(e);
        }

    }
}
