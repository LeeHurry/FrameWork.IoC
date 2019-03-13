using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork.IoC.Achieve.IoCAbstractBasics
{
    public interface IDITypeAnalytical
    {
        T GetValue<T>();
    }
}
