using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Extension.Data.Entities.Models
{
    public class TblEmployee : IEntity
    {
        [Key]
        [Required]
        [MaxLength(7)]
        public string EmpNo { get; set; }

        [Required]
        [MaxLength(255)]
        public string EmpName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$", ErrorMessage = "Invalid Password")]
        [MaxLength(128)]
        public string EmpPassword { get; set; }

        public DateTime? EmpBirthday { get; set; }
        public int? EmpSex { get; set; }

        [MaxLength(15)]
        public string EmpPhoneNo { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(255)]
        public string EmpEmail { get; set; }

        [MaxLength(255)]
        public string EmpAddress { get; set; }

        [Required]
        public int? EmpPosWork { get; set; }

        [Required]
        public byte EmpStatus { get; set; }

        [Required]
        public int? EmpContractType { get; set; }

        public DateTime? EmpWorkingDateFrom { get; set; }
        public DateTime? EmpWorkingDateTo { get; set; }
        public DateTime? EmpContractFrom { get; set; }
        public DateTime? EmpContractTo { get; set; }

        [MaxLength(255)]
        public string EmpEDLevel { get; set; }

        [MaxLength(10)]
        public string EmpFL1 { get; set; }

        [MaxLength(10)]
        public string EmpFLLevel1 { get; set; }

        [MaxLength(10)]
        public string EmpFL2 { get; set; }

        [MaxLength(10)]
        public string EmpFLLevel2 { get; set; }

        [MaxLength(10)]
        public string EmpFL3 { get; set; }

        [MaxLength(10)]
        public string EmpFLLevel3 { get; set; }

        [MaxLength(255)]
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

        [Required]
        public int? EmpRoleApp { get; set; }
        public bool EmpDelFlg { get; set; }

        public DateTime? EmpCreateDate { get; set; }
        [MaxLength(7)]
        public string EmpCreateBy { get; set; }
        public DateTime? EmpLastUpdateDate { get; set; }
        [MaxLength(7)]
        public string EmpLastUpdateBy { get; set; }
        [MaxLength(255)]
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

        [MaxLength(10)]
        public string EmpNickName { get; set; }

        [MaxLength(30)]
        public string EmpChatId { get; set; }

        [MaxLength(30)]
        public string EmpImageURL { get; set; }
    }
}
