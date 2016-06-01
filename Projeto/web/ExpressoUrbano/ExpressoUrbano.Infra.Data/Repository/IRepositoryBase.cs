using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpressoUrbano.Infra.Data.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        int TotalRegistros(TEntity countEntity);

        IList<TEntity> ObterTodos();

        IList<TEntity> ObterTodosOrdenacaoAscendente(string campo);

        IList<TEntity> ObterTodosOrdenacaoDescendente(string campo);

        TEntity ObterPorId(int id);

        TEntity ObterPorId(string id);

        void ExcluirPorId(int id);

        void Excluir(TEntity entidadeEntity);

        void Dispose();

        void Salvar(TEntity entidadeEntity);

        void SalvarLista(IList<TEntity> entidadeEntity);

        void Atualiza(TEntity entidadeEntity);

        void AtualizaLista(IList<TEntity> entidadesEntity);

        Task<TEntity> ObterPorIdAsync(int id);
        Task<string> ExcluirPorIdAsync(int id);
        Task<string> SalvarAsync(TEntity entidadeEntity);
        Task<string> AtualizaAsync(TEntity entidadeEntity);
    }
}
