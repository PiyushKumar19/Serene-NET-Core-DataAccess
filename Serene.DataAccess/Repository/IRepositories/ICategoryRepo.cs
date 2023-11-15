using Serene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serene.DataAccess.Repository.IRepositories
{
    public interface ICategoryRepo: IRepository<Category>
    {
        void Update(Category category);
        void Save();
    }
}
