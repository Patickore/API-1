using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Models
{
    public class API_1Context :DbContext 
    {
        public API_1Context(DbContextOptions<API_1Context> options) : base(options)
        {

        }

        public DbSet<Items> Items { get; set; }
    }
}
