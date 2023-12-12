using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
            new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
            new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
            new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
            new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7}
        });

        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
            new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl Tent Site", ImageUrl="https://images.pexels.com/photos/2609954/pexels-photo-2609954.jpeg?auto=compress&cs=tinysrgb&w=800"},
            new Campsite {Id = 2, CampsiteTypeId = 3, Nickname = "Backwoods Primitive Site", ImageUrl="https://images.pexels.com/photos/2603681/pexels-photo-2603681.jpeg?auto=compress&cs=tinysrgb&w=800"},
            new Campsite {Id = 3, CampsiteTypeId = 4, Nickname = "Hemlock Hammock Helm", ImageUrl="https://images.pexels.com/photos/1590042/pexels-photo-1590042.jpeg?auto=compress&cs=tinysrgb&w=800"},
            new Campsite {Id = 4, CampsiteTypeId = 2, Nickname = "Glamping Central", ImageUrl="https://images.pexels.com/photos/17592460/pexels-photo-17592460/free-photo-of-parking-lot-for-motorhomes-and-caravans.jpeg?auto=compress&cs=tinysrgb&w=800"},
            new Campsite {Id = 5, CampsiteTypeId = 1, Nickname = "Creekside Family Tent Site", ImageUrl="https://images.pexels.com/photos/2662816/pexels-photo-2662816.jpeg?auto=compress&cs=tinysrgb&w=800"}
        });

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new UserProfile {
                Id = 1, 
                FirstName="Ricky", 
                LastName="Bobby", 
                Email="uaintfirsturlast@gmail.com"

            },
            new UserProfile {Id = 2, FirstName="Rodney", LastName="Rogers", Email="bigbuckman@gmail.com"},
            new UserProfile {Id = 3, FirstName="Sarah", LastName="Johnson", Email="sarah.j@gmail.com"},
            new UserProfile {Id = 4, FirstName="Mike", LastName="Smith", Email="mike.smith@gmail.com"},
            new UserProfile {Id = 5, FirstName="Emily", LastName="Davis", Email="emily.d@gmail.com"},
            new UserProfile {Id = 6, FirstName="John", LastName="Anderson", Email="john.a@gmail.com"},
            new UserProfile {Id = 7, FirstName="Olivia", LastName="Taylor", Email="olivia.t@gmail.com"},
            new UserProfile {Id = 8, FirstName="Daniel", LastName="Brown", Email="daniel.b@gmail.com"},
            new UserProfile {Id = 9, FirstName="Sophia", LastName="Martin", Email="sophia.m@gmail.com"},
            new UserProfile {Id = 10, FirstName="David", LastName="Miller", Email="david.m@gmail.com"},
        });

        modelBuilder.Entity<Reservation>().HasData(new Reservation[]
        {
            new Reservation {Id = 1, CampsiteId = 1, UserProfileId = 1, CheckinDate = new DateTime(2023, 06, 09, 10, 00, 00), CheckoutDate = new DateTime(2023, 06, 12, 10, 00, 00)},
            new Reservation {Id = 2, CampsiteId = 3, UserProfileId = 2, CheckinDate = new DateTime(2023, 04, 11, 11, 11, 00), CheckoutDate = new DateTime(2023, 04, 14, 11, 11, 00)},
            new Reservation {Id = 3, CampsiteId = 4, UserProfileId = 3, CheckinDate = new DateTime(2023, 07, 15, 12, 00, 00), CheckoutDate = new DateTime(2023, 07, 18, 12, 00, 00)},
            new Reservation {Id = 4, CampsiteId = 2, UserProfileId = 4, CheckinDate = new DateTime(2023, 08, 20, 10, 30, 00), CheckoutDate = new DateTime(2023, 08, 25, 10, 30, 00)},
            new Reservation {Id = 5, CampsiteId = 2, UserProfileId = 5, CheckinDate = new DateTime(2023, 09, 10, 14, 00, 00), CheckoutDate = new DateTime(2023, 09, 14, 14, 00, 00)},
            // new Reservation {Id = 6, CampsiteId = 3, UserProfileId = 6, CheckinDate = new DateTime(2023, 10, 05, 11, 00, 00), CheckoutDate = new DateTime(2023, 10, 08, 11, 00, 00)},
            // new Reservation {Id = 7, CampsiteId = 2, UserProfileId = 7, CheckinDate = new DateTime(2023, 11, 15, 09, 30, 00), CheckoutDate = new DateTime(2023, 11, 18, 09, 30, 00)},
            // new Reservation {Id = 8, CampsiteId = 1, UserProfileId = 8, CheckinDate = new DateTime(2023, 12, 01, 15, 30, 00), CheckoutDate = new DateTime(2023, 12, 05, 15, 30, 00)},
            // new Reservation {Id = 9, CampsiteId = 4, UserProfileId = 9, CheckinDate = new DateTime(2024, 01, 10, 12, 00, 00), CheckoutDate = new DateTime(2024, 01, 15, 12, 00, 00)},
            // new Reservation {Id = 10, CampsiteId = 1, UserProfileId = 10, CheckinDate = new DateTime(2024, 02, 20, 08, 00, 00), CheckoutDate = new DateTime(2024, 02, 25, 08, 00, 00)},
            // new Reservation {Id = 11, CampsiteId = 9, UserProfileId = 1, CheckinDate = new DateTime(2024, 03, 10, 14, 30, 00), CheckoutDate = new DateTime(2024, 03, 15, 14, 30, 00)},
            // new Reservation {Id = 12, CampsiteId = 11, UserProfileId = 2, CheckinDate = new DateTime(2024, 04, 05, 10, 00, 00), CheckoutDate = new DateTime(2024, 04, 08, 10, 00, 00)},
            // new Reservation {Id = 13, CampsiteId = 14, UserProfileId = 3, CheckinDate = new DateTime(2024, 05, 15, 11, 30, 00), CheckoutDate = new DateTime(2024, 05, 18, 11, 30, 00)},
        });
    }
}