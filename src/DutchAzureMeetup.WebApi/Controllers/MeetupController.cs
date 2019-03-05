using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchAzureMeetup.WebApi.Data;
using DutchAzureMeetup.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DutchAzureMeetup.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetupController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Meetup>> Get()
        {
            return await Task.Run(() =>
            new List<Meetup>()
            {
                new Meetup() { Id=1, DateTime=new DateTime(2019, 3, 7, 18, 0, 0), Location="Xpirit HQ, Hilversum", Title="Running containers on Azure, which, what and when", Presenter="Marco Mansi" },
                new Meetup() { Id=2, DateTime=new DateTime(2019, 4, 17, 18, 0, 0), Location="Xebia, Amsterdam", Title="Running real world, mission critical systems on Azure", Presenter="Loek Duys" }
            });            
        }
    }
}