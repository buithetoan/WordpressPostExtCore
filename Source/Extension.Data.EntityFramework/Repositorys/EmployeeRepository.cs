using ExtCore.Data.EntityFramework;
using Extension.Data.Abstractions.Interfaces;
using Extension.Data.Entities.Models;
using Extension.Data.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Data.EntityFramework.Repositorys
{
    public class EmployeeRepository : RepositoryBase<TblEmployee>, IEmployeeRepository
    {
        public IEnumerable<EmployeeVM> All()
        {
            var employees = this.dbSet.OrderBy(p => p.EmpNo).Select(p => new EmployeeVM { 
                EmpNo = p.EmpNo,
                EmpAddress = p.EmpAddress,
                EmpBirthday = p.EmpBirthday,
                EmpBussinessExp = p.EmpBussinessExp,
                EmpChatId = p.EmpChatId,
                EmpContractFrom = p.EmpContractFrom,
                EmpContractTo = p.EmpContractTo,
                EmpContractType = p.EmpContractType,
                EmpCreateBy = p.EmpCreateBy,
                EmpCreateDate = p.EmpCreateDate,
                EmpDelFlg = p.EmpDelFlg,
                EmpEDLevel = p.EmpEDLevel,
                EmpEmail = p.EmpEmail,
                EmpFL1 = p.EmpFL1,
                EmpFL2 = p.EmpFL2,
                EmpFL3 = p.EmpFL3,
                EmpFLLevel1 = p.EmpFLLevel1,
                EmpFLLevel2 = p.EmpFLLevel2,
                EmpFLLevel3 = p.EmpFLLevel3,
                EmpImageURL = p.EmpImageURL,
                EmpLastUpdateBy = p.EmpLastUpdateBy,
                EmpLastUpdateDate = p.EmpLastUpdateDate,
                EmpLeaveApplyRole1By = p.EmpLeaveApplyRole1By,
                EmpLeaveApplyRole2By = p.EmpLeaveApplyRole2By,
                EmpLeaveApplyRole3By = p.EmpLeaveApplyRole3By,
                EmpLeaveCurrentYear = p.EmpLeaveCurrentYear,
                EmpLeaveLastYear = p.EmpLeaveLastYear,
                EmpLeaveUsed = p.EmpLeaveUsed,
                EmpMaritalStatus = p.EmpMaritalStatus,
                EmpName = p.EmpName,
                EmpNickName = p.EmpNickName,
                EmpNumberChild = p.EmpNumberChild,
                EmpPhoneNo = p.EmpPhoneNo,
                EmpPL1 = p.EmpPL1,
                EmpPL1Exp = p.EmpPL1Exp,
                EmpPL1Level = p.EmpPL1Level,
                EmpPL2 = p.EmpPL2,
                EmpPL2Exp = p.EmpPL2Exp,
                EmpPL2Level = p.EmpPL2Level,
                EmpPL3 = p.EmpPL3,
                EmpPL3Exp = p.EmpPL3Exp,
                EmpPL3Level = p.EmpPL3Level,
                EmpPosWork = p.EmpPosWork,
                EmpRoleApp = p.EmpRoleApp,
                EmpSalary = p.EmpSalary,
                EmpSex = p.EmpSex,
                EmpSoftSkill = p.EmpSoftSkill,
                EmpStatus = p.EmpStatus,
                EmpTeam = p.EmpTeam,
                EmpTeamLead = p.EmpTeamLead,
                EmpWorkingDateFrom = p.EmpWorkingDateFrom,
                EmpWorkingDateTo = p.EmpWorkingDateTo
            });

            return employees;
        }
    }
}
