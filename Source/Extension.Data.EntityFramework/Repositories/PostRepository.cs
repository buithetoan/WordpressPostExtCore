using ExtCore.Data.EntityFramework;
using Extension.Common.ViewModels;
using Extension.Data.Abstractions.Interfaces;
using Extension.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension.Data.EntityFramework.Repositories
{
    public class PostRepository : RepositoryBase<TblPost>, IPostRepository
    {
        public IEnumerable<PostVM> All()
        {
            var posts = this.dbSet.OrderBy(p => p.Id).Select(p => new PostVM { Id = p.Id, Title = p.Content });
            return posts;
        }
    }
}
