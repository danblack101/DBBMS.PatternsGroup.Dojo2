using ContextSingletons.Models.Donkey;

namespace ContextSingletronsTest
{
    public class FakeContext : IContext
    {
        public bool IsAuthenticated()
        {
            return true;
        }
    }
}