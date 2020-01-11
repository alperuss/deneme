using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relationship_deneme
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Page> Pages { get; set; }
        public DbSet<Models.Vote> Votes { get; set; }

    }
}
