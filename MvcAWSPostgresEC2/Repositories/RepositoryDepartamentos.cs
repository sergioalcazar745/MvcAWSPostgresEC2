using Microsoft.EntityFrameworkCore;
using MvcAWSPostgresEC2.Data;
using MvcAWSPostgresEC2.Models;

namespace MvcAWSPostgresEC2.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            return await this.context.Departamentos.ToListAsync();
        }

        public async Task<Departamento> FindDepartamentoAsync(int id)
        {
            return await this.context.Departamentos.FirstOrDefaultAsync(x => x.IdDepartamento == id);
        }

        public async Task InsertDepartamento(int id, string nombre, string localidad)
        {
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            this.context.Departamentos.Add(departamento);
            await this.context.SaveChangesAsync();
        }
    }
}
