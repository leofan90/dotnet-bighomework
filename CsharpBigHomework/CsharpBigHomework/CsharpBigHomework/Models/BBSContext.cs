using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CsharpBigHomework.Models
{
    public class BBSContext : DbContext
    {
        public BBSContext(DbContextOptions<BBSContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(e => e.FavorList).HasConversion(
                v => JsonSerializer.Serialize(v, null),
                v => JsonSerializer.Deserialize<List<string>>(v, null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));

            modelBuilder.Entity<Post>().Property(e => e.NextId).HasConversion(
                v => JsonSerializer.Serialize(v, null),
                v => JsonSerializer.Deserialize<List<string>>(v, null),
                new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToList()));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
