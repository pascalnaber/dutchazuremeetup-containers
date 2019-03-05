using DutchAzureMeetup.WebApp.Model;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DutchAzureMeetup.WebApp.Proxies
{
    public interface IOrganizer
    {        
        [Get("/api/organizer")]
        Task<IEnumerable<dynamic>> GetOrganizers();
    }
}
