using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Soccer.Shared.Entities;

public static class Seed
{
    public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasData(
            new Team { Id = new Guid("1eff24d7-208c-4fdc-85e2-decd064a98cd"), Name = "Arsenal", Country = "England", Founded = new(1886), CoachName = "Mikel Arteta", Logo = null! },
            new Team { Id = new Guid("0c3b24cd-cc84-4a1c-86f8-2810b0b3bfcc"), Name = "Chelsea", Country = "England", Founded = new(1905), CoachName = "Thomas Tuchel", Logo = null! },
            new Team { Id = new Guid("26f3407d-f3f2-4b6a-8cae-73f12328967f"), Name = "Liverpool", Country = "England", Founded = new(1892), CoachName = "Jurgen Klopp", Logo = null! },
            new Team { Id = new Guid("6744ffd8-e113-4a25-bb84-89b9372e3b06"), Name = "Manchester City", Country = "England", Founded = new(1880), CoachName = "Pep Guardiola", Logo = null! },
            new Team { Id = new Guid("f9c228df-128e-4160-8f85-c6af9a188071"), Name = "Manchester United", Country = "England", Founded = new(1878), CoachName = "Ole Gunnar Solskjaer", Logo = null! },
            new Team { Id = new Guid("ac2fe540-1126-4a64-abba-54fa7480da4c"), Name = "Tottenham Hotspur", Country = "England", Founded = new(1882), CoachName = "Jose Mourinho", Logo = null! },
            new Team { Id = new Guid("189f2330-0fcd-4e69-954f-5f690ea24b63"), Name = "Real Madrid", Country = "Spain", Founded = new(1902), CoachName = "Carlo Ancelotti", Logo = null! },
            new Team { Id = new Guid("7a5746ec-1709-46f9-be21-ca259a143f89"), Name = "Barcelona", Country = "Spain", Founded = new(1899), CoachName = "Ronald Koeman", Logo = null! }
        );
        modelBuilder.Entity<Player>().HasData(
            new Player { Id = new Guid("19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c"), Name = "Messi", Nationality = "Argentine", TeamId = new Guid("e4f8840a-04c3-4ef8-8df2-c5176967ce84"), DateOfBirth = new(1987), Image = null! },
            new Player { Id = new Guid("7cbad38c-3289-4857-a832-993ca4d672b7"), Name = "Ronaldo", Nationality = "Spain", TeamId = new Guid("c059bf61-5521-4c7d-aa1d-2fdfddfaa3b1"), DateOfBirth = new(1985), Image = null! }
        );

        return modelBuilder;
    }
    public static ModelBuilder SeedRoles(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "7a5746ec-1709-46f9-be21-ca259a143f89", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Name = "User", NormalizedName = "USER" }
        );
        return modelBuilder;
    }
}