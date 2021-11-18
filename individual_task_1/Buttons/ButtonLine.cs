using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using individual_task_1.Shapes;
namespace individual_task_1.Buttons
{
    public class ButtonLine: Button
    {
        private DrawTools.DrawTool drawTool;

        public ButtonLine(DrawTools.DrawTool drawTool, Control parent)
        {
            this.drawTool = drawTool;
            this.Text = "Линия";
            this.Parent = parent;
            this.Dock = DockStyle.Top;
        }

        protected override void OnClick(EventArgs e)
        {
            drawTool.CurrentShape = new Line();
            base.OnClick(e);
        }

    }
}
