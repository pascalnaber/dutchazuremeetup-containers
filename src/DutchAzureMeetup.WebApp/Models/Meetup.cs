using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchAzureMeetup.WebApp.Model
{
    public class Meetup
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        public string Location { get; set; }

        public string Presenter { get; set; }
    }
}
