using JimmyConcepcion_P1_AP1.DAL;
using JimmyConcepcion_P1_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JimmyConcepcion_P1_AP1.Services
{
    public class RegistroServices
    {
        private readonly IDbContextFactory<Contexto> _dbFactory;
        public RegistroServices(IDbContextFactory<Contexto> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<bool> Guardar(Registro registro)
        {
            if (!await Existe(registro.AporteId))
                return await Insertar(registro);
            else
                return await Modificar(registro);
        }

        public async Task<bool> Insertar(Registro registro)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            contexto.Registro.Add(registro);
            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Registro registro)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            contexto.Registro.Update(registro);
            return await contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Registro.AnyAsync(t => t.AporteId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            var eliminados = await contexto.Registro
                .Where(t => t.AporteId == id)
                .ExecuteDeleteAsync();
            return eliminados > 0;
        }

        public async Task<Registro?> Buscar(int id)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Registro.AsNoTracking()
                .FirstOrDefaultAsync(t => t.AporteId == id);
        }

        public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
        {
            await using var contexto = await _dbFactory.CreateDbContextAsync();
            return await contexto.Registro.AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

    }


}
