using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExelTools.Models
{
    public class ExelToolsContext :DbContext
    {
        private IConfigurationRoot config;

        public ExelToolsContext(IConfigurationRoot config, DbContextOptions options) : base(options) // video 0704 07:10
        {
            this.config = config;

        }

        public DbSet<WebProduct> WebProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(this.config["ConnectionStrings:ExelToolsConnection"]);
        }

    }
}
