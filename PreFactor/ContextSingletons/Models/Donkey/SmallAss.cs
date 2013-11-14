using System;
using System.Web;

namespace ContextSingletons.Models.Donkey
{
    public abstract class DonkeyBase
    {
        protected readonly int Age;
        protected readonly int NumberOfLegs;

        protected DonkeyBase(int age, int numberOfLegs)
        {
            Age = age;
            NumberOfLegs = numberOfLegs;
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                throw new Exception("This aint no real donkey");
        }

        public string Name
        {
            get { return HttpContext.Current.User.Identity.Name; }
        }

        public abstract int CarryingCapacity();
    }

    public class SmallAss : DonkeyBase
    {
        private const int MAX_CARRYING_CAPACITY = 30;
        private static SmallAss _instance;

        private SmallAss(int age, int numberOfLegs) : base(age, numberOfLegs)
        {
        }

        public static SmallAss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SmallAss(5, 4);
                }
                return _instance;
            }
        }

        public override int CarryingCapacity()
        {
            if (Age < 5)
                return 0;
            return (5 - NumberOfLegs)*MAX_CARRYING_CAPACITY;
        }
    }
}
