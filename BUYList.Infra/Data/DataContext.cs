using BUYList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BUYList.Infra.Data
{
    public class DataContext :
    DbContext
    {
        public DataContext
        (DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating
        (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] {
                new User
                {
                   Id=Guid.Parse("dd080e3b-1d46-4c48-bf27-adc079f36732"),
                   Name="Pedro Octávio",
                   Email="pedrooctavio@email.com",
                   Password="pedropassword",
                   IsDeleted=false
                },
                new User
                {
                   Id=Guid.Parse("95ae172e-1e77-4df6-993c-2b20302c6e02"),
                   Name="Ígor Andrade",
                   Email="igorandrade@email.com",
                   Password="igorpassword",
                   IsDeleted=false
                },
                new User
                {
                   Id=Guid.Parse("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35"),
                   Name="Júlia da Silva",
                   Email="juliasilva@email.com",
                   Password="juliapassword",
                   IsDeleted=false
                }
            });

            modelBuilder.Entity<Item>().HasData(new Item[] {
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Toradora",
                  Description="Buy a Toradora volume 8 in Amazon.",
                  CreateDate=Convert.ToDateTime("05-08-2020"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("dd080e3b-1d46-4c48-bf27-adc079f36732")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Re: Zero",
                  Description="Buy a Re: Zero volume 13 in Amazon.",
                  CreateDate=Convert.ToDateTime("12-08-2020"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("dd080e3b-1d46-4c48-bf27-adc079f36732")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Re: Zero",
                  Description="Buy a Re: Zero volume 12 in Amazon.",
                  CreateDate=Convert.ToDateTime("23-04-2020"),
                  IsActive=false,
                  IsDeleted=true,
                  UserId=Guid.Parse("dd080e3b-1d46-4c48-bf27-adc079f36732")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Car",
                  Description="Buy a Car in WebMotors.",
                  CreateDate=Convert.ToDateTime("25-12-2021"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("95ae172e-1e77-4df6-993c-2b20302c6e02")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="TV",
                  Description="Buy a TV in Amazon.",
                  CreateDate=Convert.ToDateTime("25-06-2020"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("95ae172e-1e77-4df6-993c-2b20302c6e02")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Mouse",
                  Description="Buy a Mouse in Razer.",
                  CreateDate=Convert.ToDateTime("12-07-2020"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35")
                },
                new Item
                {
                  Id=Guid.NewGuid(),
                  Name="Mousepad",
                  Description="Buy a Mousepad in Razer.",
                  CreateDate=Convert.ToDateTime("12-07-2020"),
                  IsActive=true,
                  IsDeleted=false,
                  UserId=Guid.Parse("4d523b1f-4ce0-43b3-a3a0-09dad5a90e35")
                }
            });
        }
    }
}
