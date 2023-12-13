using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CategoryEFDal: BaseRepositoryEF<Category,FilmDbContext>,ICategoryDAL
    {
    }
}
