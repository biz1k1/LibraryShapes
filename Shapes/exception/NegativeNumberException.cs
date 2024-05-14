using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes.exception
{
    public class NegativeNumberException:Exception
    {
        public override string Message => "Отрицательное число";
    }
}
