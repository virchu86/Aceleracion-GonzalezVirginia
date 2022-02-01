using Microsoft.EntityFrameworkCore;

namespace ChallengeIngreso.Repository
{
    public abstract class BaseRepository<TEntity, TContex>
        where TEntity : class
        where TContex : DbContext 
    {
        private readonly TContex _dbContext;
        private DbSet<TEntity> _dbSet;

        protected BaseRepository(TContex dbcontext)
        {
            _dbContext = dbcontext;
        } 
        protected DbSet<TEntity> DbSet
        {
            get { return _dbSet ??= _dbContext.Set<TEntity>(); }
        }
        public List<TEntity> GetAllEntities()
        {
            return DbSet.ToList();
        }
        public TEntity GetEntities(int id)
        {
            return DbSet.Find();
        }
        public TEntity Add(TEntity entity)
        {
            DbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
       
        public TEntity Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            DbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
