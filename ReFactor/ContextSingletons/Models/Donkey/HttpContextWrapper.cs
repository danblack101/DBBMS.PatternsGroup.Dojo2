using System.Web;

namespace ContextSingletons.Models.Donkey
{
    public class HttpContextWrapper : IContext
    {
        public bool IsAuthenticated()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}