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
    public class OrganizerController : ControllerBase
    {
        private readonly DutchAzureMeetupContext context;

        public OrganizerController(DutchAzureMeetupContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Organizer>> Get()
        {
            var organizers = from organizer in context.Organizers
                             select organizer;

            return await organizers.ToListAsync();
        }
    }
}