using DutchAzureMeetup.WebApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchAzureMeetup.WebApp.Proxies
{
    public interface IMeetup
    {        
        [Get("/api/meetup")]
        Task<IEnumerable<dynamic>> GetMeetups();
    }
}
