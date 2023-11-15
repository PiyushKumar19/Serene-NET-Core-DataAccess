using Serene.DataAccess.Data;
using Serene.DataAccess.Repository.IRepositories;
using Serene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serene.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepo
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Category category)
        {
            context.Categories.Update(category);
        }
    }
}
