﻿using Microsoft.EntityFrameworkCore;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.Data
{
    public class WeightWatchersContext: DbContext
    {
        public WeightWatchersContext(DbContextOptions<WeightWatchersContext> options) : base(options)
        {

        }
        public DbSet<SubscriberTable> SubscriberTable { get; set; }
        public DbSet<CardTable> CardTable { get; set; }
    }
}
