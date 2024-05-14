using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes.interfaces
{
    public interface IShapeHandler
    {
        double CalculateArea(IShape shape);
    }
}
