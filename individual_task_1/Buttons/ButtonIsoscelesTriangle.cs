using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_task_1.Buttons
{
    public class ButtonIsoscelesTriangle:Button
    {
        private DrawTools.DrawTool drawTool;

        public ButtonIsoscelesTriangle(DrawTools.DrawTool drawTool, Control parent)
        {
            this.drawTool = drawTool;
            this.Text = "Равнобедренный треугольник";
            this.Parent = parent;
            this.Dock = DockStyle.Top;
        }

        protected override void OnClick(EventArgs e)
        {
            drawTool.CurrentShape = new Shapes.Triangles.IsoscelesTriangle();
            base.OnClick(e);
        }
    }
}
