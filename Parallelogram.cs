using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_ETAP1
{
    [Serializable]
    public class Parallelogram : Shape
    {

        public override string Tag
        {
            get
            {
                return "parallelogram";
            }
        }

        public override double Area
        {
            get
            {

                return WidthP * HeightP;
            }

        }
        public override double Parameter
        {
            get
            {
                return 2 * WidthP + 2 * y;

            }
        }

        public override void Paint(Graphics graphic)

        {
            var colorborder = Selected
                ? Color.Red
                : ColorBorder;

           
            using (var brush = new SolidBrush(ColorFill))
                graphic.FillPolygon(brush, new Point[] { new Point(Location.X, Location.Y),
                                               new Point(Location.X + Lean, Location.Y + HeightP),
                                               new Point(Location.X + Lean + WidthP, Location.Y + HeightP),
                                               new Point(Location.X + WidthP, Location.Y )});

            using (var pen = new Pen(colorborder))
                graphic.DrawPolygon(pen, new Point[] {new Point(Location.X, Location.Y),
                                               new Point(Location.X + Lean, Location.Y + HeightP),
                                               new Point(Location.X + Lean + WidthP, Location.Y + HeightP),
                                               new Point(Location.X + WidthP, Location.Y )});
        }

       
        public override bool PointInShape(Point point)
        {
            return Location.X <= point.X && Location.X +Lean<=point.X && point.X<=Location.X + Lean + WidthP && point.X<= Location.X + WidthP&&
                Location.Y <= point.Y && Location.Y + HeightP-50<=point.Y ;
        }

    }
}
