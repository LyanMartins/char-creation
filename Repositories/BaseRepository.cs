using char_creation.Models;
using Microsoft.EntityFrameworkCore;

namespace char_creation.Repositories
{
    class BaseRepository<T> where T: BaseModel
    {

        protected readonly DatabaseContext databaseContext;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(DatabaseContext context)
        {
            this.databaseContext = context;
            this.dbSet = context.Set<T>();
        }
    }
}