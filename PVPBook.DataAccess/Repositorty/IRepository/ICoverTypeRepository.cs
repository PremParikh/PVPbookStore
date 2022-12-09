using PVPBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVPBook.DataAccess.Repositorty.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
