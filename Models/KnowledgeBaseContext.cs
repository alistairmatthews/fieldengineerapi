using Microsoft.EntityFrameworkCore;

namespace FieldEngineerApi.Models
{

    public class KnowledgeBaseContext : DbContext
    {
        public KnowledgeBaseContext(DbContextOptions<KnowledgeBaseContext> options)
            : base(options)
        {

        }

        public DbSet<KnowledgeBaseBoilerPart> BoilerParts { get; set; }
        public DbSet<KnowledgeBaseEngineer> Engineers { get; set; }
        public DbSet<KnowledgeBaseTip> Tips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KnowledgeBaseEngineer>().HasData(
                new KnowledgeBaseEngineer {
                    Id = 1,
                    Name = "Sara Perez",
                    ContactNumber = "554-1000"
                },
                new KnowledgeBaseEngineer {
                    Id = 2,
                    Name = "Michelle Harris",
                    ContactNumber = "554-1001"
                },
                new KnowledgeBaseEngineer {
                    Id = 3,
                    Name = "Quincy Watson",
                    ContactNumber = "554-1002"
                }
            );

            modelBuilder.Entity<KnowledgeBaseBoilerPart>().HasData(
                new KnowledgeBaseBoilerPart {
                    Id = 1,
                    Name = "Caserta Stone Beige",
                    Overview = "Extreme Series 18 in. x 18 in. carpet tiles are a durable and beautiful carpet solution specially engineered for both indoor and outdoor residential installations."
                },
                new KnowledgeBaseBoilerPart {
                    Id = 2,
                    Name = "Caserta Sky Grey",
                    Overview = "Extreme Series 18 in. x 18 in. carpet tiles are a durable and beautiful carpet solution specially engineered for both indoor and outdoor residential installations."
                },
                new KnowledgeBaseBoilerPart {
                    Id = 3, 
                    Name = "Ageless Beauty Clay",
                    Overview = "Add some fashion to your floors with the Shaw Ageless Beauty Carpet collection."
                },
                new KnowledgeBaseBoilerPart {
                    Id = 4,
                    Name = "Lush II Tundra",
                    Overview = "Made with 100% premium nylon fiber, this textured carpet creates a warm, casual atmosphere that invites you to relax and thoroughly enjoy your home."
                }
            );

            modelBuilder.Entity<KnowledgeBaseTip>().HasData(
                new KnowledgeBaseTip {
                    Id = 1,
                    KnowledgeBaseBoilerPartId = 1,
                    KnowledgeBaseEngineerId = 3,
                    Subject = "How to get water to the right temperature",
                    Body = "If water doesn't get hot when radiators are on, replace the diverter valve."
                },
                new KnowledgeBaseTip {
                    Id = 2,
                    KnowledgeBaseBoilerPartId = 1,
                    KnowledgeBaseEngineerId = 3,
                    Subject = "Where to site this boiler",
                    Body = "When installing this unit, don't place it more that 5 feet higher than the fuel tank, without a fuel pump."
                },
                new KnowledgeBaseTip {
                    Id = 3,
                    KnowledgeBaseBoilerPartId = 3,
                    KnowledgeBaseEngineerId = 1,
                    Subject = "How to get this nozzle to light the furnace correctly",
                    Body = "Sometimes the nozzle gets clogged with old oil or dirt. You can use a fine point to clear it, or replace."
                }
            );
        }

    }

}