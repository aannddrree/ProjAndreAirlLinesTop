using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAndreAirlLinesTop.Model;

namespace ProjAndreAirlLinesTop.Data
{
    public class ProjAndreAirlLinesTopContext : DbContext
    {
        public ProjAndreAirlLinesTopContext (DbContextOptions<ProjAndreAirlLinesTopContext> options)
            : base(options)
        {
        }

        public DbSet<ProjAndreAirlLinesTop.Model.Client> Client { get; set; }

        public DbSet<ProjAndreAirlLinesTop.Model.Address> Address { get; set; }
    }
}
