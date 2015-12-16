using System.Data.Entity;

namespace PandaWeb.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public DbSet<Appointment> Appointments { get; set; }
    }
}