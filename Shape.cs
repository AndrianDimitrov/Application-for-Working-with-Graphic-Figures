using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KURSOVA_ETAP1.Exceptions;

namespace KURSOVA_ETAP1
{
    [Serializable]
    public abstract class Shape
    {
        private int _Width;
        public int Width { get => _Width ;
            set
            {
                if (value < 0)
                    throw new Exception();
                _Width = value;
            }
        }
        private int _Height;
        public int Height {
            get => _Height;
            set
            {
                if (value < 0)
                    throw new Exception();
                _Height = value;
            }
        }
        private int _Radius;
        public int Radius {
            get => _Radius;
            set
            {
                if (value < 0)
                    throw new Exception();
                _Radius = value;
            }
        }

        private int _y;
        public int y {
            get => _y;
            set
            {
                if (value < 0)
                    throw new Exception();
                _y = value;
            }
        }
        private int _Lean;
        public int Lean {
            get => _Lean;
            set
            {
                if (value < 0)
                    throw new Exception();
                _Lean = value;
            }
        }
        private int _HeightP;
        public int HeightP {
            get => _HeightP;
            set
            {
                if (value < 0)
                    throw new Exception();
                _HeightP = value;
            }
        }
        private int _WidthP;
        public int WidthP {
            get => _WidthP;
            set
            {
                if (value < 0)
                    throw new Exception();
                _WidthP = value;
            }
        } 
        public Point Location { get; set; }
        public Color Color { get; set; }
        public Color ColorBorder { get; set; }
        public Color ColorFill { get; set; }
        public bool Selected { get; set; }
        public abstract double Area { get; }
        public abstract bool PointInShape(Point point);
        public abstract void Paint(Graphics graphics);
        public abstract double Parameter { get; }
        public PointF[] TrianglePoints { get; set; }

        private int _TriangleSide;
        public int TriangleSide {
            get => _TriangleSide;
            set
            {
                if (value < 0)
                    throw new Exception();
                _TriangleSide = value;
            }
        }
        public virtual string Tag { get; }

    }
}
