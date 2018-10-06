using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGraphics
{
    public partial class MainForm : Form
    {
        private int width;
        private int height;
        private Graphics graphics;
        private Font font = new Font("Arial", 20);
        private Boolean endRequested = false;

        private Point squareManualPoint = new Point(0, 0);
        private Size squareManualSize = new Size(10, 10);

        private Point squareAutonomousPoint = new Point(0, 0);
        private Size squareAutonomousSize = new Size(10, 10);
        private Boolean squareAutonomousTurn = false;

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.UserPaint, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("MainForm_Load");

            width = ClientRectangle.Width;
            height = ClientRectangle.Height;

            Debug.WriteLine("window width: " + width + ", height: " + height);

            Thread thread = new Thread(Engine_ThreadFunction);

            thread.Start();

            //backgroundWorker.RunWorkerAsync();

            timer.Interval = 200;

            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("timer_Tick");

            Refresh();
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

            // Draw text

            SizeF stringSize = g.MeasureString("Canvas sample", font);

            Point stringPoint = new Point(width - (int) stringSize.Width - 1, height - (int) stringSize.Height - 1);

            g.DrawString("Canvas sample", font, Brushes.Black, stringPoint);

            DrawCircle(g);

            DrawManualSquare(g);

            DrawAutonomousSquare(g);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine("MainForm_Resize");

            width = ClientRectangle.Width;
            height = ClientRectangle.Height;

            Debug.WriteLine("window width: " + width + ", height: " + height);
        }

        private void DrawCircle(Graphics g)
        {
            Debug.WriteLine("DrawCircle");

            SolidBrush brush = new SolidBrush(Color.Red);

            Pen pen = new Pen(brush);

            Point point1 = new Point(0, 0);
            Point point2 = new Point(width / 2, height / 2);

            int limitSize = (width > height) ? height : width;

            int circleRadius = (limitSize > 200) ? 100 : limitSize / 3;

            Debug.WriteLine("limitSize=" + limitSize + ", circleRadius=" + circleRadius);

            g.DrawEllipse(pen,
                          width / 2 - circleRadius,
                          height / 2 - circleRadius,
                          circleRadius * 2,
                          circleRadius * 2);

            brush.Dispose();
        }

        private void DrawManualSquare(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);

            Pen pen = new Pen(brush);

            squareManualPoint.X = 1;
            squareManualPoint.Y = height - squareManualSize.Height - 2;

            Rectangle rectangle = new Rectangle(squareManualPoint, squareManualSize);

            g.DrawRectangle(pen, rectangle);
        }

        private void DrawAutonomousSquare(Graphics g)
        {
            Debug.WriteLine("DrawAutonomousSquare");

            SolidBrush brush = new SolidBrush(Color.Green);

            Pen pen = new Pen(brush);

            Rectangle rectangle = new Rectangle(squareAutonomousPoint, squareAutonomousSize);

            g.DrawRectangle(pen, rectangle);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            endRequested = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("MainForm_KeyDown keyCode=" + e.KeyCode);

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (squareManualPoint.X >= squareManualSize.Width)
                    {
                        squareManualPoint.X -= squareManualSize.Width;

                        Refresh();
                    }

                    break;
                case Keys.Right:
                    if ((squareManualPoint.X + squareManualSize.Width) < width)
                    {
                        squareManualPoint.X += squareManualSize.Width;

                        Refresh();
                    }

                    break;
                case Keys.Down:
                    if ((squareManualPoint.Y + squareManualSize.Height) < height)
                    {
                        squareManualPoint.Y += squareManualSize.Height;

                        Refresh();
                    }

                    break;
                case Keys.Up:
                    if (squareManualPoint.Y >= squareManualSize.Height)
                    {
                        squareManualPoint.Y -= squareManualSize.Height;

                        Refresh();
                    }

                    break;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("MainForm_KeyPress");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("backgroundWorker_DoWork");
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("backgroundWorker_RunWorkerCompleted");
        }

        private void Engine_ThreadFunction()
        {
            Debug.WriteLine("Engine_ThreadFunction");

            while (!endRequested)
            {
                if (squareAutonomousTurn) {
                    Debug.WriteLine("Ascending");

                    // Ascending

                    if ((squareAutonomousPoint.X + squareAutonomousSize.Width) <= width)
                    {
                        squareAutonomousPoint.X += squareAutonomousSize.Width;
                    }
                    else
                    {
                        squareAutonomousTurn = !squareAutonomousTurn;
                    }
                }
                else
                {
                    Debug.WriteLine("Descending");

                    // Descending

                    if ((squareAutonomousPoint.X - squareAutonomousSize.Width) >= 0)
                    {
                        squareAutonomousPoint.X -= squareAutonomousSize.Width;
                    }
                    else
                    {
                        squareAutonomousTurn = !squareAutonomousTurn;
                    }
                }

                Thread.Sleep(200);
            }

            Debug.WriteLine("Exiting from thread.");
        }
    }
}
