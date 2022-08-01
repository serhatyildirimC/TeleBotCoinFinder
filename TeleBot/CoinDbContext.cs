using CoinFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeleBot
{
    public class CoinDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CoinDatabase;Trusted_Connection=True");

        }
        public DbSet<Coin> Coins { get; set; }
    }
}