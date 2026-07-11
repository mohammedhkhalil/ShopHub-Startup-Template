using DAL.Data;
using DAL.Repositories;

namespace DAL.Models
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
