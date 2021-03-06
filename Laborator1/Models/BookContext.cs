﻿using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class BookContext : DbContext
    {
        

        public BookContext(DbContextOptions<BookContext> options)
           : base(options)
        {
        }
        public DbSet<BookItem> BookItems { get; set; }


    }
}
