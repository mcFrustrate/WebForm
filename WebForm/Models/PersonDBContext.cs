﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebForm.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PersonModel> PersonModels { get; set; }
    }
}
