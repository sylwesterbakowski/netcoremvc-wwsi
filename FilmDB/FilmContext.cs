﻿using FilmDB2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB2
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = FilmDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(con);
        }

    }
}
