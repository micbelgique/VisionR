using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VisionR.Model
{
    public class Context:DbContext
    {
        public DbSet<Image> Images { get; set; }
        public Context(DbContextOptions contextOptions) : base(contextOptions) { }
    }
}
