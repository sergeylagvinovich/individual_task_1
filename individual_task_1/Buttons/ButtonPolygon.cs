using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace individual_task_1.Buttons
{
    public class ButtonPolygon: Button
    {
        private DrawTools.DrawTool drawTool;
        delegate void AccountHandler(string message);
        event AccountHandler Notify;
        public ButtonPolygon(DrawTools.DrawTool drawTool, Control parent)
        {
            this.drawTool = drawTool;
            this.Text = "Правильный многоугольник";
            this.Parent = parent;
            this.Dock = DockStyle.Top;
        }

        protected override void OnClick(EventArgs e)
        {
            drawTool.CurrentShape = new Shapes.Polygons.Polygon();
            base.OnClick(e);
        }
    }
}
