using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Data;
using SistemasDeTarefas.Models;
using SistemasDeTarefas.Repositories.Interfaces;

namespace SistemasDeTarefas.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaDeTarefasDBContex _dbcontext;

        public UsuarioRepositorio(SistemaDeTarefasDBContex sistemaDeTarefasDBContex)
        {
            _dbcontext = sistemaDeTarefasDBContex;
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            _dbcontext.Usuarios.Add(usuario);
            _dbcontext.SaveChanges();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            return ok();
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbcontext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbcontext.Usuarios.ToListAsync();
        }
    }
}
