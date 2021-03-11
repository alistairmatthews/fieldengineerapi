using System;
using Microsoft.EntityFrameworkCore;

namespace FieldEngineerApi.Models
{

    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options)
            : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ScheduleEngineer> Engineers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentStatus>().HasData(
                new AppointmentStatus {Id = 1, StatusName = "Unresolved"},
                new AppointmentStatus {Id = 2, StatusName = "Parts Ordered"},
                new AppointmentStatus {Id = 3, StatusName = "Fixed"}
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer {
                    Id = 1, 
                    Name = "Damayanti Basumatary",
                    Address = "4567 Main St Buffalo, NY 98052",
                    ContactNumber = "555-0199"
                },
                new Customer {
                    Id = 2,
                    Name = "Deepali Haloi",
                    Address = "4568 Main St Buffalo, NY 98052",
                    ContactNumber = "555-0200"
                },
                new Customer {
                    Id = 3,
                    Name = "Hua Long",
                    Address = "4569 Main St Buffalo, NY 98052",
                    ContactNumber = "555-0201"
                },
                new Customer {
                    Id = 4,
                    Name = "Volha Pashkevich",
                    Address = "4570 Main St Buffalo, NY 98052",
                    ContactNumber = "555-0202"
                },
                new Customer {
                    Id = 5,
                    Name = "Veselin Iliev",
                    Address = "4571 Main St Buffalo, NY 98053",
                    ContactNumber = "555-0203"
                },
                new Customer {
                    Id = 6,
                    Name = "Tsehayetu Abera",
                    Address = "4571 Main St Buffalo, NY 98054",
                    ContactNumber = "555-0204"
                }
            );

            modelBuilder.Entity<ScheduleEngineer>().HasData(
                new ScheduleEngineer {
                    Id = 1,
                    Name = "Sara Perez",
                    ContactNumber = "554-1000"
                },
                new ScheduleEngineer {
                    Id = 2,
                    Name = "Michelle Harris",
                    ContactNumber = "554-1001"
                },
                new ScheduleEngineer {
                    Id = 3,
                    Name = "Quincy Watson",
                    ContactNumber = "554-1002"
                }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment {
                    Id = 1,
                    CustomerId = 1,
                    ProblemDetails = "Boiler wont start",
                    AppointmentStatusId = 3, 
                    EngineerId = 1, 
                    StartDateTime = DateTime.Now.AddDays(-10),
                    Notes = "Installed a new diverter valve"
                },
                new Appointment {
                    Id = 2,
                    CustomerId = 2,
                    ProblemDetails = "Can't change temperature",
                    AppointmentStatusId = 2,
                    EngineerId = 2,
                    StartDateTime = DateTime.Now.AddDays(-8),
                    Notes = "Needed a new heat exchanger"
                },
                new Appointment {
                    Id = 3,
                    CustomerId = 3,
                    ProblemDetails = "Radiators aren't working",
                    AppointmentStatusId = 2,
                    EngineerId = 2,
                    StartDateTime = DateTime.Now.AddDays(-7),
                    Notes = "Bled radiators."
                },
                new Appointment {
                    Id = 4,
                    CustomerId = 1,
                    ProblemDetails = "Boiler wont start",
                    AppointmentStatusId = 3, 
                    EngineerId = 1, 
                    StartDateTime = DateTime.Now.AddDays(-5),
                    Notes = "Installed a second new diverter valve"
                }
            );
        }

    }
}