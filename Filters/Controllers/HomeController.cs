using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    //[HttpsOnly]
    //[Profile]
    //[ViewResultDetails]
    //[RangeException]
    //[TypeFilter(typeof(DiagnosticsFilter))]
    //[TypeFilter(typeof(TimeFilter))]
    //[ServiceFilter(typeof(TimeFilter))]
    [Message("this is the Controller-scoped filter ")]
    public class HomeController : Controller
    {
        //public ViewResult Index() =>
        //    View("Message","This is the Index action on the home controller");
        //public IActionResult Index()
        //{
        //    if (!Request.IsHttps)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else
        //    {
        //        return View("Message","This is the Index action on the Home controller");
        //    }
        //}

        //public IActionResult SecondAction()
        //{
        //    if (!Request.IsHttps)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status403Forbidden);
        //    }
        //    else;
        //    {
        //        return View("Message","This is the SecondAction action on the Home controller");
        //    }
        //}
        //[RequireHttps]
        //public ViewResult Index() =>
        //    View("Message","This is the Index action on the Home controller");

        ////[RequireHttps]
        //public ViewResult SecondAction() =>
        //    View("Message", "This is the second action on the Home controller");

        //public ViewResult GenerateException(int? id)
        //{
        //    if (id==null)
        //    {
        //        throw new ArgumentNullException(nameof(id));
        //    }
        //    else if(id>10)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(id));
        //    }
        //    else
        //    {
        //        return View("Message",$"The value is {id}");
        //    }
        //}
        [Message("this is the First-Scoped Filter ")]
        [Message("this is the Second-Scoped Filter")]
        public ViewResult Index() =>
            View("Message","This is the action mesthod in the HomeController");
    }
}
