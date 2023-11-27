using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLIB_Mindbox_.Interfaces
{
    public interface IFigure<T>
    {
        T Area { get; set; }
        T MathArea();
        bool IsValid();
    }
}
