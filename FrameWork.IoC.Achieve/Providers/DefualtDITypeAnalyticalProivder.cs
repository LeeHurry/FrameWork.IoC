using FrameWork.IoC.Achieve.IoCAbstractBasics;
using FrameWork.IoC.Achieve.IoCBasics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWork.IoC.Achieve.Providers
{
    public class DefualtDITypeAnalyticalProivder : IDITypeAnalyticalProvider
    {
        public IDITypeAnalytical CreteDITypeAnalaytical()
        {
            return new DITypeAnalytical();
        }
    }
}
