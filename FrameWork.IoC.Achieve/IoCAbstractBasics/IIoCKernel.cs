using System;

namespace FrameWork.IoC.Achieve.IoCAbstractBasics
{
    public interface IIoCKernel
    {
        IIoCKernel Bind<T>();
        IIoCKernel To<U>() where U : class;
        V GetValue<V>() where V : class;
    }
}
