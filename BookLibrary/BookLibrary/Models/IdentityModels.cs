﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using BookLibrary.Dtos;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BookLibrary.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<BookLanguage> BookLanguages { get; set; }

        public DbSet<BookType> BookTypes { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}