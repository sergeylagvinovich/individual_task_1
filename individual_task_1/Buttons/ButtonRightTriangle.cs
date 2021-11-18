using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace individual_task_1.Buttons
{
    public class ButtonRightTriangle:Button
    {
        private DrawTools.DrawTool drawTool;

        public ButtonRightTriangle(DrawTools.DrawTool drawTool, Control parent)
        {
            this.drawTool = drawTool;
            this.Text = "Прямоугольный треугольник";
            this.Parent = parent;
            this.Dock = DockStyle.Top;
        }

        protected override void OnClick(EventArgs e)
        {
            drawTool.CurrentShape = new Shapes.Triangles.RightTriangle();
            base.OnClick(e);
        }
    }
}
