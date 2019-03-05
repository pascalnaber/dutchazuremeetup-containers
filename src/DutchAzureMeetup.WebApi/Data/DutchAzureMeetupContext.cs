using DutchAzureMeetup.WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchAzureMeetup.WebApi.Data
{
    public class DutchAzureMeetupContext : DbContext
    {
        public DutchAzureMeetupContext(DbContextOptions<DutchAzureMeetupContext> options)
            : base(options)
        {
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Meetup> Meetups { get; set; }
    }
}
