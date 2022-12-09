using PVPBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVPBook.DataAccess.Repositorty.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
