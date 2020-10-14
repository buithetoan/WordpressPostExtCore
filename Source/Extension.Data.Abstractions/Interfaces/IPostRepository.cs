using ExtCore.Data.Abstractions;
using Extension.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Data.Abstractions.Interfaces
{
    public interface IPostRepository : IRepository
    {
        IEnumerable<PostVM> All();
    }
}
