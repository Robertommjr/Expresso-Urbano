using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ExpressoUrbano.Infra.Data.Context;

namespace ExpressoUrbano.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ExpressoUrbanoContext Db = new ExpressoUrbanoContext();

        public int TotalRegistros(TEntity entidadeEntity)
        {
            return Db.Set<TEntity>().Count();
        }

        public IList<TEntity> ObterTodos()
        {
            return Db.Set<TEntity>().ToList();
        }

        public IList<TEntity> ObterTodosOrdenacaoAscendente(string campo)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ObterTodosOrdenacaoDescendente(string campo)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public virtual TEntity ObterPorId(string id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void ExcluirPorId(int id)
        {
            var entidade = Db.Set<TEntity>().Find(id);
            Db.Set<TEntity>().Remove(entidade);
            Db.SaveChanges();
        }

        public void Excluir(TEntity entidadeEntity)
        {
            Db.Set<TEntity>().Remove(entidadeEntity);
            Db.SaveChanges();
        }

        public void ExcluirLista(IList<TEntity> entidadeEntity)
        {
            foreach (var Entity in entidadeEntity)
            {
                Db.Set<TEntity>().Remove(Entity);
            }
            Db.SaveChanges();
        }

        public void Salvar(TEntity entidadeEntity)
        {
            Db.Set<TEntity>().Add(entidadeEntity);
            Db.SaveChanges();
        }

        public void SalvarLista(IList<TEntity> entidadeEntity)
        {
            foreach (var Entity in entidadeEntity)
            {
                Db.Set<TEntity>().Add(Entity);
            }
            Db.SaveChanges();
        }

        public void Atualiza(TEntity entidadeEntity)
        {
            Db.Entry(entidadeEntity).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void AtualizaLista(IList<TEntity> entidadesEntity)
        {
            foreach (var Entity in entidadesEntity)
            {
                Db.Entry(Entity).State = EntityState.Modified;
            }

            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public virtual async Task<TEntity> ObterPorIdAsync(int id)
        {
            return await Db.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IList<TEntity>> ObterTodosAsync()
        {
            return await Db.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<string> ExcluirPorIdAsync(int id)
        {
            TEntity entidade = await Db.Set<TEntity>().FindAsync(id);
            Db.Set<TEntity>().Remove(entidade);
            await Db.SaveChangesAsync();
            return "Entidade removida com sucesso";
        }

        public virtual async Task<string> SalvarAsync(TEntity entidadeEntity)
        {
            Db.Set<TEntity>().Add(entidadeEntity);
            await Db.SaveChangesAsync();
            return "Entidade adicionada com sucesso";
        }

        public virtual async Task<string> AtualizaAsync(TEntity entidadeEntity)
        {
            Db.Entry(entidadeEntity).State = EntityState.Modified;
            await Db.SaveChangesAsync();
            return "Entidade atualizada com sucesso";
        }
    }
}
