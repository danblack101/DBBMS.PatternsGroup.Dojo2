using System;
using System.Web;

namespace ContextSingletons.Models.Donkey
{
    public abstract class DonkeyBase
    {
        protected readonly int Age;
        protected readonly int NumberOfLegs;

        protected DonkeyBase(IContext context,int age, int numberOfLegs)
        {
            Age = age;
            NumberOfLegs = numberOfLegs;
            if (!context.IsAuthenticated())
                throw new Exception("This aint no real donkey");
        }

        public string Name
        {
            get { return HttpContext.Current.User.Identity.Name; }
        }

        public abstract int CarryingCapacity();
    }
}