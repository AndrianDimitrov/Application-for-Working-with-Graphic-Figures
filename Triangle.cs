using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_ETAP1
{
    [Serializable]
    public  class Triangle:Shape
    {

        public override string Tag
        {
            get
            {
                return "triangle";
            }
        }
        public override void Paint(Graphics graphics)
        {
            var colorBorder = Selected
              ? Color.Red
              : ColorBorder;
            using (Brush brush = new SolidBrush(ColorFill))
            {
                graphics.FillPolygon(brush, TrianglePoints);
            }
            using (Pen pen = new Pen(colorBorder))
            {
                graphics.DrawPolygon(pen, TrianglePoints);
            }

        }
        public Triangle(PointF[] trainglePoints)
        {
            TrianglePoints = trainglePoints;
        }

        public override double Parameter
        {
            get
            {
                return 3 *TriangleSide;

            }
        }
        public override double Area
        {
            get
            {

                return (Math.Sqrt(3) / 4) * TriangleSide * TriangleSide;

            }
        }
        public override bool PointInShape(Point point)
        {

            return Location.X - 50 <= point.X && point.X - 50 <= Location.X &&
                  Location.Y <= point.Y && point.Y <= Location.Y + 50;
        }
    }
}