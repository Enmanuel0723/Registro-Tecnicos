using Registro_Tecnicos.Models;
using Microsoft.EntityFrameworkCore;
using Registro;
using System.Collections.Generic;

namespace Registro_Tecnicos.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Tecnicos> Tecnicos { get; set; }

    }
}