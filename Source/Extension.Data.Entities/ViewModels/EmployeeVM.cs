using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Data.Entities.ViewModels
{
    public class EmployeeVM
    {
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public DateTime? EmpBirthday { get; set; }
        public int? EmpSex { get; set; }
        public string EmpPhoneNo { get; set; }
        public string EmpEmail { get; set; }
        public string EmpAddress { get; set; }
        public int? EmpPosWork { get; set; }
        public byte EmpStatus { get; set; }
        public int? EmpContractType { get; set; }
        public DateTime? EmpWorkingDateFrom { get; set; }
        public DateTime? EmpWorkingDateTo { get; set; }
        public DateTime? EmpContractFrom { get; set; }
        public DateTime? EmpContractTo { get; set; }
        public string EmpEDLevel { get; set; }
        public string EmpFL1 { get; set; }
        public string EmpFLLevel1 { get; set; }
        public string EmpFL2 { get; set; }
        public string EmpFLLevel2 { get; set; }
        public string EmpFL3 { get; set; }
        public string EmpFLLevel3 { get; set; }
        public string EmpSoftSkill { get; set; }
        public int? EmpPL1 { get; set; }
        public int? EmpPL1Level { get; set; }
        public int? EmpPL1Exp { get; set; }
        public int? EmpPL2 { get; set; }
        public int? EmpPL2Level { get; set; }
        public int? EmpPL2Exp { get; set; }
        public int? EmpPL3 { get; set; }
        public int? EmpPL3Level { get; set; }
        public int? EmpPL3Exp { get; set; }
        public int? EmpRoleApp { get; set; }
        public bool EmpDelFlg { get; set; }
        public DateTime? EmpCreateDate { get; set; }
        public string EmpCreateBy { get; set; }
        public DateTime? EmpLastUpdateDate { get; set; }
        public string EmpLastUpdateBy { get; set; }
        public string EmpBussinessExp { get; set; }
        public int? EmpSalary { get; set; }
        public int? EmpMaritalStatus { get; set; }
        public int? EmpNumberChild { get; set; }
        public int? EmpTeam { get; set; }
        public bool EmpTeamLead { get; set; }
        public float? EmpLeaveCurrentYear { get; set; }
        public float? EmpLeaveUsed { get; set; }
        public float? EmpLeaveLastYear { get; set; }
        public string EmpLeaveApplyRole1By { get; set; }
        public string EmpLeaveApplyRole2By { get; set; }
        public string EmpLeaveApplyRole3By { get; set; }
        public string EmpNickName { get; set; }
        public string EmpChatId { get; set; }
        public string EmpImageURL { get; set; }
    }
}
