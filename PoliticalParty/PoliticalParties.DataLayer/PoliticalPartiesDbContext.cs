﻿using Microsoft.EntityFrameworkCore;
using PoliticalParties.Entities;
using System;

namespace PoliticalParties.DataLayer
{
    public class PoliticalPartiesDbContext : DbContext
    {
        public PoliticalPartiesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PoliticalParty> PoliticalParties { get; set; }
        public DbSet<PoliticalLeader> PoliticalLeaders { get; set; }
        public DbSet<Development> Developments { get; set; }
    }
}


