using ExtCore.Data.Abstractions;
using Extension.Data.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Data.Abstractions.Interfaces
{
    public interface IEmployeeRepository : IRepository
    {
        IEnumerable<EmployeeVM> All();
    }
}
