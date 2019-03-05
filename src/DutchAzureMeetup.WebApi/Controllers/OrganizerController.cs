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
        [HttpGet]
        public async Task<IEnumerable<Organizer>> Get()
        {
            return await Task.Run(() =>
            new List<Organizer>()
            {
                new Organizer() { Id=1, Name="Pascal Naber", Company="Xpirit" },
                new Organizer() { Id=2, Name="Marco Mansi", Company="SoftAware" },
                new Organizer() { Id=3, Name="Sander Molenkamp", Company="InfoSupport"}
            });           
        }
    }
}