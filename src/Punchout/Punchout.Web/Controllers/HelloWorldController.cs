namespace Punchout.Web.Controllers
{
    using System.Web.Mvc;

    public class HelloWorldController : CoreController
    {
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my very first <b>controller!<b>";
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "<b>Welcome!<b>";
        }
    }
}
