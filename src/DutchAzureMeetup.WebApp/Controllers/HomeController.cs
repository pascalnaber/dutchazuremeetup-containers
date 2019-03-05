using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DutchAzureMeetup.WebApp.Models;
using DutchAzureMeetup.WebApp.Proxies;
using Refit;

namespace DutchAzureMeetup.WebApp.Controllers
{
    public class HomeController : Controller
    {
        IMeetup meetupProxy = null;
        IOrganizer organizerProxy = null;

        public HomeController(IMeetup meetupProxy, IOrganizer organizerProxy)
        {
            this.meetupProxy = meetupProxy;
            this.organizerProxy = organizerProxy;
        }

        public async Task<IActionResult> Index()
        {
            var meetups = await meetupProxy.GetMeetupsDyn();

            return View(meetups);
        }

        public async Task<IActionResult> Organizers()
        {         
            var organizers = await organizerProxy.GetOrganizers();

            return View(organizers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
