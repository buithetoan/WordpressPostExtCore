using ExtCore.Data.EntityFramework;
using Extension.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extension.Data.EntityFramework
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelBuilder)
        {
            // TblEmployee
            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("Tbl_Employee");

                entity.HasKey(e => new { e.EmpNo })
                    .HasName("PK_Tbl_Employee");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("Emp_No")
                    .HasColumnType("varchar")
                    .HasMaxLength(7)
                    .IsRequired();

                entity.Property(e => e.EmpName)
                   .HasColumnName("Emp_Name")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(255)
                   .IsRequired();

                entity.Property(e => e.EmpPassword)
                   .HasColumnName("Emp_Password")
                   .HasColumnType("varchar")
                   .HasMaxLength(128);

                entity.Property(e => e.EmpBirthday)
                   .HasColumnName("Emp_Birthday")
                   .HasColumnType("date");

                entity.Property(e => e.EmpSex)
                   .HasColumnName("Emp_Sex")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPhoneNo)
                   .HasColumnName("Emp_PhoneNo")
                   .HasColumnType("varchar")
                   .HasMaxLength(15);

                entity.Property(e => e.EmpEmail)
                   .HasColumnName("Emp_Email")
                   .HasColumnType("varchar")
                   .HasMaxLength(255);

                entity.Property(e => e.EmpAddress)
                   .HasColumnName("Emp_Address")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(255);

                entity.Property(e => e.EmpPosWork)
                   .HasColumnName("Emp_PosWork")
                   .HasColumnType("int");

                entity.Property(e => e.EmpStatus)
                   .HasColumnName("Emp_Status")
                   .HasColumnType("tinyint");

                entity.Property(e => e.EmpContractType)
                   .HasColumnName("Emp_ContractType")
                   .HasColumnType("int");

                entity.Property(e => e.EmpWorkingDateFrom)
                   .HasColumnName("Emp_WorkingDateFrom")
                   .HasColumnType("date");

                entity.Property(e => e.EmpWorkingDateTo)
                   .HasColumnName("Emp_WorkingDateTo")
                   .HasColumnType("date");

                entity.Property(e => e.EmpContractFrom)
                   .HasColumnName("Emp_ContractFrom")
                   .HasColumnType("date");

                entity.Property(e => e.EmpContractTo)
                   .HasColumnName("Emp_ContractTo")
                   .HasColumnType("date");

                entity.Property(e => e.EmpEDLevel)
                   .HasColumnName("Emp_EDLevel")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(255);

                entity.Property(e => e.EmpFL1)
                   .HasColumnName("Emp_FL1")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpFLLevel1)
                   .HasColumnName("Emp_FLLevel1")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpFL2)
                   .HasColumnName("Emp_FL2")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpFLLevel2)
                   .HasColumnName("Emp_FLLevel2")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpFL3)
                   .HasColumnName("Emp_FL3")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpFLLevel3)
                   .HasColumnName("Emp_FLLevel3")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(10);

                entity.Property(e => e.EmpSoftSkill)
                   .HasColumnName("Emp_SoftSkill")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(255);

                entity.Property(e => e.EmpPL1)
                   .HasColumnName("Emp_PL1")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL1Level)
                   .HasColumnName("Emp_PL1Level")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL1Exp)
                   .HasColumnName("Emp_PL1Exp")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL2)
                   .HasColumnName("Emp_PL2")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL2Level)
                   .HasColumnName("Emp_PL2Level")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL2Exp)
                   .HasColumnName("Emp_PL2Exp")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL3)
                   .HasColumnName("Emp_PL3")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL3Level)
                   .HasColumnName("Emp_PL3Level")
                   .HasColumnType("int");

                entity.Property(e => e.EmpPL3Exp)
                   .HasColumnName("Emp_PL3Exp")
                   .HasColumnType("int");

                entity.Property(e => e.EmpRoleApp)
                   .HasColumnName("Emp_RoleApp")
                   .HasColumnType("int");

                entity.Property(e => e.EmpDelFlg)
                  .HasColumnName("Emp_DelFlg")
                  .HasColumnType("bit");

                entity.Property(e => e.EmpCreateDate)
                    .HasColumnName("Emp_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpCreateBy)
                    .HasColumnName("Emp_CreateBy")
                    .HasColumnType("varchar")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpLastUpdateDate)
                    .HasColumnName("Emp_LastUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpLastUpdateBy)
                    .HasColumnName("Emp_LastUpdateBy")
                    .HasColumnType("varchar")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpBussinessExp)
                   .HasColumnName("Emp_BussinessExp")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(255);

                entity.Property(e => e.EmpSalary)
                   .HasColumnName("Emp_Salary")
                   .HasColumnType("int");

                entity.Property(e => e.EmpMaritalStatus)
                  .HasColumnName("Emp_MaritalStatus")
                  .HasColumnType("int");

                entity.Property(e => e.EmpNumberChild)
                  .HasColumnName("Emp_NumberChild")
                  .HasColumnType("int");

                entity.Property(e => e.EmpTeam)
                  .HasColumnName("Emp_Team")
                  .HasColumnType("int");

                entity.Property(e => e.EmpTeamLead)
                 .HasColumnName("Emp_TeamLead")
                 .HasColumnType("bit");

                entity.Property(e => e.EmpLeaveCurrentYear)
                  .HasColumnName("Emp_LeaveCurrentYear")
                  .HasColumnType("float");

                entity.Property(e => e.EmpLeaveUsed)
                  .HasColumnName("Emp_LeaveUsed")
                  .HasColumnType("float");

                entity.Property(e => e.EmpLeaveLastYear)
                  .HasColumnName("Emp_LeaveLastYear")
                  .HasColumnType("float");

                entity.Property(e => e.EmpLeaveApplyRole1By)
                    .HasColumnName("Emp_LeaveApplyRole1By")
                    .HasColumnType("varchar")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpLeaveApplyRole2By)
                    .HasColumnName("Emp_LeaveApplyRole2By")
                    .HasColumnType("varchar")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpLeaveApplyRole3By)
                    .HasColumnName("Emp_LeaveApplyRole3By")
                    .HasColumnType("varchar")
                    .HasMaxLength(7);


                entity.Property(e => e.EmpNickName)
                    .HasColumnName("Emp_NickName")
                    .HasColumnType("varchar")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpChatId)
                    .HasColumnName("Emp_ChatId")
                    .HasColumnType("varchar")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpImageURL)
                    .HasColumnName("Emp_ImageURL")
                    .HasColumnType("varchar")
                    .HasMaxLength(30);
            });
        }
    }
}
