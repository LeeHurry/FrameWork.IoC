using System;

namespace FrameWork.IoC.Test.TestTwo
{
    public interface IAbstractTwo
    {
        void WriterLine(string meg);
    }

    public class AchieveTwo : IAbstractTwo
    {
        public void WriterLine(string meg)
        {
            Console.WriteLine(meg + "-This is TestTwo");
        }
    }

}