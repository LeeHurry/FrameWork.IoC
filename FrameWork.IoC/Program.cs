using FrameWork.IoC.Achieve.IoCBasics;
using FrameWork.IoC.Achieve.IoCAbstractBasics;
using FrameWork.IoC.Case;
using FrameWork.IoC.Test;
using FrameWork.IoC.Test.TestOne;
using FrameWork.IoC.Test.TestTwo;
using System;

namespace FrameWork.IoC.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IoCTest
            IIoCKernel iocKernel = new IoCKernel();
            iocKernel.Bind<IAbstractOne>().To<AchieveOne>();
            iocKernel.Bind<IAbstractTwo>().To<AchieveTwo>();
            iocKernel.Bind<IAbstractOne_One>().To<AbstractOne_One>();
            iocKernel.Bind<IAbstractOne_Two>().To<AbstractOne_Two>();
            DITest diType = iocKernel.GetValue<DITest>();
            diType.Writer("IoCFrameWorkTest");
            #endregion
            Console.ReadLine();
        }
    }
}