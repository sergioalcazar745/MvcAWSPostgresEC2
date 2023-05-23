using Microsoft.EntityFrameworkCore;
using MvcAWSPostgresEC2.Models;

namespace MvcAWSPostgresEC2.Data
{
    public class DepartamentosContext:DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext> options)
            :base(options) {}

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
