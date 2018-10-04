using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGraphics
{
    public partial class MainForm : Form
    {
        private int width;
        private int height;

        public MainForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.UserPaint, true);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("MainForm_Paint");

            Graphics g = e.Graphics;

            g.Clear(Color.White);

            Pen pen = new Pen(Brushes.DeepSkyBlue);

            Point point1 = new Point(0, 0);
            Point point2 = new Point(width / 2, height / 2);

            g.DrawLine(pen, point1, point2);

            Font font = new Font("Arial", 20);

            g.DrawString("Test", font, Brushes.Black, point1);

            DrawCircle(g);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine("MainForm_Resize");

            width = Size.Width;
            height = Size.Height;

            Debug.WriteLine("window width: " + width + ", height: " + height);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("MainForm_Load");

            width = Size.Width;
            height = Size.Height;

            Debug.WriteLine("window width: " + width + ", height: " + height);
        }

        private void DrawCircle(Graphics g)
        {
            Pen pen = new Pen(Brushes.DeepSkyBlue);

            Point point1 = new Point(0, 0);
            Point point2 = new Point(width / 2, height / 2);

            int circleRadius = 100;

            g.DrawEllipse(pen,
                          width / 2 - circleRadius,
                          height / 2 - circleRadius,
                          circleRadius * 2,
                          circleRadius * 2);
        }
    }
}
