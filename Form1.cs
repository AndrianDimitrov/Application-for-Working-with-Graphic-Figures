using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using KURSOVA_ETAP1;


namespace KURSOVA_ETAP1
{
    public partial class FormScene : Form
    {
        private List<Shape>_shape = new List<Shape>();
      
        public FormScene()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var s in _shape)
                s.Paint(e.Graphics);
            var centerPoint=new Point
            { 
            
              X=Width/2,
              Y=Height/2
            
            };
            using (var pen = new Pen(Color.Gray))
            { 
              pen.DashStyle=System.Drawing.Drawing2D.DashStyle.DashDot;
                e.Graphics.DrawLine(pen, centerPoint.X, 0, centerPoint.X, Height);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pen.Width = 2;
                e.Graphics.DrawEllipse(pen, centerPoint.X - 2,centerPoint.Y - 2, 4, 4);
            }
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            Shape temp = null;
            if (e.Button == MouseButtons.XButton1)
                temp = new Rectangle()
                {
                    Location = e.Location,
                    Width = 200,
                    Height = 100
                };

            else if (e.Button == MouseButtons.Left)

                temp = new Circle()
                {
                    Location = e.Location,
                    Radius = 100
                };

            else if (e.Button == MouseButtons.Middle)

                temp = new Parallelogram()
                {
                    Location = e.Location,
                    WidthP = 200,
                    HeightP = 100,
                    Lean = 60
                };
            else
                for (int i = 0; i < _shape.Count(); i++)
                    _shape[i].Selected = false;
            for (int i = _shape.Count - 1; i >= 0; i--)
                if (_shape[i].PointInShape(e.Location))
                {
                    _shape[i].Selected = true;
                    toolStripStatusArea.Text=CalculateShapesArea().ToString();
                    toolStripStatusPerimeter.Text = CalculateShapesParameter().ToString();
                    break;
                    
                }
              
            if (temp != null)
            {
                var random = new Random();
                temp.Location = e.Location;
                temp.ColorBorder = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                temp.ColorFill = Color.FromArgb(100, temp.ColorBorder);
                _shape.Add(temp);
            }
            Invalidate();
        }

        private double CalculateShapesArea()
        {
            var area = 0.0;
            for (int s = 0; s < _shape.Count(); s++)
                area += _shape[s].Area;

            return area;
        }

        private double CalculateShapesParameter()
        {
            var parameter = 0.0;
            for (int s = 0; s < _shape.Count(); s++)
                parameter += _shape[s].Parameter;

            return parameter;
        
        }
        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter) 
            {

                PointF[] coordinates = new PointF[3];

                coordinates[0].X = MousePosition.X;
                coordinates[0].Y = MousePosition.Y;

                coordinates[1].X = MousePosition.X + 60;
                coordinates[1].Y = MousePosition.Y + 60;

                coordinates[2].X = MousePosition.X - 60;
                coordinates[2].Y = MousePosition.Y + 60;

                Shape shape = new Triangle(coordinates)
                {
                    Location = MousePosition,
                };
                var random = new Random();
                shape.Location = MousePosition;
                shape.ColorBorder = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                shape.ColorFill = Color.FromArgb(100, shape.ColorBorder);
                _shape.Add(shape);
            }
            else
            {
                for (int s = _shape.Count() - 1; s >= 0; s--)
                {
                    if (_shape[s].Selected)
                        _shape.RemoveAt(s);
                }
            }
            Invalidate();

        }
        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            foreach (var shape in _shape)
            {

                if (shape.Selected && shape.Tag == "rectangle")
                {

                    var fr = new RectangleEdit();
                    fr.Rectangle = (Rectangle)shape;
                    fr.ShowDialog();
                    break;
                }

                else if (shape.Selected && shape.Tag == "triangle")
                {
                    var ft = new TriangleEdit();
                    ft.Triangle = (Triangle)shape;
                    ft.ShowDialog();
                    break;
                }

                else if (shape.Selected && shape.Tag == "circle")
                {
                    var fc = new CircleEdit();
                    fc.Circle = (Circle)shape;
                    fc.ShowDialog();
                    break;

                }

                else if (shape.Selected && shape.Tag == "parallelogram")
                {
                    var fp = new ParallelogramEdit();
                    fp.Parallelogram = (Parallelogram)shape;
                    fp.ShowDialog();
                    break;

                }
                Invalidate();
            }
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
                formatter.Serialize(fs, _shape);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

           if (!File.Exists("data"))
                return;
           IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Open))
                _shape = (List<Shape>)formatter.Deserialize(fs);
        }
        private void SelectShapes(List<Shape> _shape)
        {
            foreach (var s in _shape)
                s.Selected = true;
            Invalidate();
        }

        private void rightToolStripMenuRight_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var RightShapes = _shape.WhereContains(
                delegate (Shape s)
                {
                    return s.Location.X + s.Width > centerX;
                });
            SelectShapes(RightShapes);
        }

        private void leftToolStripMenuLeft_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var LeftShapes = _shape.WhereContains(s => s.Location.X <= centerX);

            SelectShapes(LeftShapes);
        }
    }
}

