using JimmyConcepcion_P1_AP1.DAL;
using JimmyConcepcion_P1_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JimmyConcepcion_P1_AP1.Services
{
    public class RegistroServices
    {
        private readonly Contexto _context;
        public RegistroServices(Contexto contexto) => _context = contexto;

        public async Task<bool> Guardar(Registro registro)
        {
            return false;
        }

        public async Task<bool> Insertar(Registro registro)
        {
            return false;
        }

        public async Task<bool> Modificar(Registro registro)
        {
            return false;
        }

        public async Task<bool> Existe(int id)
        {
            return false;
        }

        public async Task<bool> Existe(string? nombre, int? id = null)
        {
            return false;
        }

        public async Task<bool> Existe(int id, string? nombre)
        {
            return false;
        }

        public async Task<bool> Eliminar(int id)
        {
            return false;
        }

        public async Task<Registro?> Buscar(int id)
        {
            return null;
        }

        public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
        {
            return new List<Registro>();
        }

    }


}
