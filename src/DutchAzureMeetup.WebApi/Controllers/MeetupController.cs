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
        private readonly DutchAzureMeetupContext context;

        public MeetupController(DutchAzureMeetupContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Meetup>> Get()
        {
            var meetups = from meetup in context.Meetups
                          orderby meetup.DateTime descending
                          select meetup;

            return await meetups.ToListAsync();
        }
    }
}