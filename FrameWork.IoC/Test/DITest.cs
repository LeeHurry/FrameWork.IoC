using FrameWork.IoC.Achieve.IoCBasics;
using FrameWork.IoC.Achieve.IoCAbstractBasics;

using FrameWork.IoC;
using FrameWork.IoC.Test.TestOne;
using FrameWork.IoC.Test.TestTwo;

namespace FrameWork.IoC.Test
{
    public class DITest
    {
        private IAbstractOne _AbstractOne;
        public DITest(IAbstractOne abstractone)
        {
            _AbstractOne = abstractone;
        }

        private IAbstractTwo _AbstractTwo;

        [DIType]
        public IAbstractTwo AbstractTwo
        {
            get
            {
                return _AbstractTwo;
            }
            set
            {
                _AbstractTwo = value;
            }
        }

        public void Writer(string meg)
        {
            _AbstractOne.WriterLine(meg);
            _AbstractTwo.WriterLine(meg);
        }
    }
}