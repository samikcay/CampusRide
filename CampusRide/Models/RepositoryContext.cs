﻿using Microsoft.EntityFrameworkCore;
using CampusRide.Models;

namespace CampusRide.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
