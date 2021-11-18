using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using individual_task_1.Shapes.Polygons;
using individual_task_1.Buttons.DrawTools;
using individual_task_1.Buttons;
namespace individual_task_1
{
    public partial class Form1 : Form
    {
        private List<Shapes.Shape> shapes;
        private bool draw = false;
        private DrawTool DT;
        private Shapes.Shape currentShape;
        private Color drawColor;
        public Form1()
        {
            InitializeComponent();

            DT = new DrawTool();
            ButtonRectangle btnRect = new ButtonRectangle(DT,panel1);
            ButtonLine btnLine = new ButtonLine(DT, panel1);
            ButtonRightTriangle btnRightTriangle = new ButtonRightTriangle(DT, panel1);
            ButtonIsoscelesTriangle btnIsoscelesTriangle = new ButtonIsoscelesTriangle(DT, panel1);
            ButtonPolygon btnPolygon = new ButtonPolygon(DT, panel1);
            shapes = new List<Shapes.Shape>();
            colorDialog1.Color = Color.Black;
            drawColor = Color.Black;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

          
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (DT.CurrentShape != null)
            {
                currentShape = DT.CurrentShape;
                currentShape.StartDraw(e.Location.X, e.Location.Y);
                currentShape.SetColor(drawColor);
                draw = true;
            }
        }

        private Bitmap Draw(PictureBox p)
        {
            Bitmap b = new Bitmap(p.Width, p.Height,System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(b);
            currentShape.Draw(g);
            foreach (Shapes.Shape item in shapes)
            {
                item.Draw(g);
            }
            return b;
        }

        private void DrawAll()
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                currentShape.Adjustment(e.Location.X, e.Location.Y);
                pictureBox1.Image = Draw(pictureBox1);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                shapes.Add(currentShape.Clone());
                draw = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                drawColor = colorDialog1.Color;
            }
        }
    }
}
