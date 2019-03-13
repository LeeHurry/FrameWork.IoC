using System;

namespace FrameWork.IoC.Achieve.IoCBasics
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DITypeAttribute : Attribute
    {
        public DITypeAttribute() { }
    }
}