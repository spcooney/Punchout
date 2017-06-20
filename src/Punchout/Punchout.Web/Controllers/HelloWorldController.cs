namespace Punchout.Web.Controllers
{
    using System.Web.Mvc;

    public class HelloWorldController : CoreController
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "<b>Welcome!<b>";
        }
    }
}
