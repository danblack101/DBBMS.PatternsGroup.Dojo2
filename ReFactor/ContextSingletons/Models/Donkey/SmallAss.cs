namespace ContextSingletons.Models.Donkey
{
    public class SmallAss : DonkeyBase
    {
        private const int MAX_CARRYING_CAPACITY = 30;

        public SmallAss(IContext context,int age, int numberOfLegs) : base(context,age, numberOfLegs)
        {
        }

        public SmallAss(IContext context, int numberOfLegs) : base(context, 5,numberOfLegs)
        {
            
        }

        public SmallAss(IContext context) : base(context, 5,4)
        {
            
        }

        public override int CarryingCapacity()
        {
            if (Age < 5)
                return 0;
            return MAX_CARRYING_CAPACITY / (5 - NumberOfLegs);
        }

      
    }
}
