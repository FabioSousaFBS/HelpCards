using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpCards
{
    public class Contexto : DbContext
    {
        public DbSet<OrdemServico> OrdemServicos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["conection"].ConnectionString);
        }
    }
}
