using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA_ETAP1
{
    public delegate bool WherePredicate(Shape shape);
    static class ShapeExtension
    {
        public static List<Shape> WhereContains(this List<Shape> shapes, WherePredicate wherePredicate)
        {
            var resultShapes = new List<Shape>();
            foreach (var s in shapes)
                if (wherePredicate(s))
                    resultShapes.Add(s);

            return resultShapes;
        }
    }
}
