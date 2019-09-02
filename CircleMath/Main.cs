using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleMath
{
    public partial class Main : Form
    {
        static Thread thread;
        static Bitmap bitmap;

        static Int16 timesTable = 0;
        static Double theta = 0;
        static Double increment = 0; //number of points on circle circumfrence
        static float radius = 0.0f;

        static PointF originPoint = new PointF(0, 0);
        static PointF pointStart = new PointF(0, 0);//Where the bitmap being displayed will start
        static PointF nextPoint = Point.Empty;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Main_Resize(sender, e);//Get the intial size of the canvas

            timesTable = Int16.Parse(txtTimesTable.Text);
            theta = 360 / Int64.Parse(txtCircleDivisions.Text);
        }

        private void DoMath_Click(object sender, EventArgs e)
        {
            DoMath();
        }

        private void DoMath()
        {
            Main_Resize(this, new EventArgs());//making sure the canvas is the correct size when the go button is clicked

            timesTable = Int16.Parse(txtTimesTable.Text);
            theta = 360 / Int64.Parse(txtCircleDivisions.Text);//workes out the number of evenly sized slices needed
            increment = theta;//increment to store the angle of each section of the circle

            bitmap = new Bitmap(canvas.Width, canvas.Height);

            thread = new Thread(Draw);//Creating a new thread to avoid locking UI and prevent the image from flickering
            thread.IsBackground = true;
            thread.Start();
        }

        private void Draw()
        {
            Bitmap buffer = new Bitmap(canvas.Width, canvas.Height);
            var valuePairs = new Dictionary<Int64, PointF>();
            Int64 temp = 0;

            canvas.BackColor = Color.Black;

            do
            {
                //points.Add(CirclePoint(radius, theta, originPoint));
                valuePairs.Add(temp, CirclePoint(radius, theta, originPoint));

                temp++;
                theta += increment;
            } while (theta <= 360);

            //Draw a line between two points
            using (Graphics g = Graphics.FromImage(buffer))
            using (Pen pen = new Pen(Color.White))
            {
                for (int i = 0; i < valuePairs.Count; i++)
                {
                    temp = (i * timesTable) % 10;//gets last digit of result as index of the line destination
                    nextPoint = valuePairs[temp];

                    g.DrawLine(pen, valuePairs[i], nextPoint);

                    lock (bitmap)
                    {
                        bitmap = buffer;
                    }
                }
            }

            canvas.Invalidate();//So the last line gets drawn
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap != null)
            {
                e.Graphics.DrawImage(bitmap, pointStart);
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            canvas.Height = this.Height - (panel2.Height * 2);
            canvas.Width = this.Width;
            originPoint.X = canvas.Width / 2;
            originPoint.Y = canvas.Height / 2;

            radius = (canvas.Height / 2) - 50; //keep the point a bit from the edge of the canvas, we have less height than width
        }

        private void BtnDivisionIncrease_Click(object sender, EventArgs e)
        {
            Int16 temp;

            temp = Int16.Parse(txtCircleDivisions.Text);
            temp++;
            txtCircleDivisions.Text = temp.ToString();

            DoMath();
        }

        private void BtnDivisionDecrease_Click(object sender, EventArgs e)
        {
            Int16 temp;

            temp = Int16.Parse(txtCircleDivisions.Text);
            temp--;
            txtCircleDivisions.Text = temp.ToString();

            DoMath();
        }

        private void BtnTimesTableIncrease_Click(object sender, EventArgs e)
        {
            Int16 temp;

            temp = Int16.Parse(txtTimesTable.Text);
            temp++;
            txtTimesTable.Text = temp.ToString();

            DoMath();
        }

        private void BtnTimesTableDecrease_Click(object sender, EventArgs e)
        {
            Int16 temp;

            temp = Int16.Parse(txtTimesTable.Text);
            temp--;
            txtTimesTable.Text = temp.ToString();

            DoMath();
        }

        private PointF CirclePoint(float radius, double theta, PointF originPoint)
        {
            float x = -(float)(radius * Math.Cos(theta * Math.PI / 180f)) + originPoint.X;
            float y = -(float)(radius * Math.Sin(theta * Math.PI / 180f)) + originPoint.Y;

            return new PointF(x, y);
        }
    }
}
