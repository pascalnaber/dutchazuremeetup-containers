using DutchAzureMeetup.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchAzureMeetup.WebApi.Data
{
    public class DataInitializer
    {
        public async static Task Initialize(DutchAzureMeetupContext context)
        {
            context.Database.EnsureCreated();
            if (context.Organizers.Any())
            {
                return;
            }

            context.Organizers.Add(new Organizer() { Name = "Pascal Naber", Company = "Xpirit" });
            context.Organizers.Add(new Organizer() { Name = "Marco Mansi", Company = "SoftAware" });
            context.Organizers.Add(new Organizer() { Name = "Sander Molenkamp", Company = "InfoSupport" });
            await context.SaveChangesAsync();

            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2019, 3, 7, 18, 0, 0), Location = "Xpirit HQ, Hilversum", Title = "Running containers on Azure, which, what and when", Presenter = "Marco Mansi" });
            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2019, 4, 17, 18, 0, 0), Location = "Xebia, Amsterdam", Title = "Running real world, mission critical systems on Azure", Presenter = "Loek Duys" });
            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2019, 1, 24, 18, 0, 0), Location = "Xebia, Amsterdam", Title = "DevOps on Azure with Azure DevOps", Presenter = "Peter Toonen" });
            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2018, 12, 12, 18, 0, 0), Location = "Xebia, Amsterdam", Title = "Building Awesome 8-bit Adventure Games with Microsoft Bot Framework", Presenter = "Sander Molenkamp" });
            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2018, 11, 8, 18, 0, 0), Location = "Xebia, Amsterdam", Title = "Smack your Batch up! Everything about Azure Batch with the power of Docker", Presenter = "Marco Mansi" });
            context.Meetups.Add(new Meetup() { DateTime = new DateTime(2018, 7, 5, 18, 0, 0), Location = "Xebia, Amsterdam", Title = "Orchestrate containers with Azure Kubernetes Service (AKS)", Presenter = "Pascal Naber" });
            await context.SaveChangesAsync();
        }
    }
}
