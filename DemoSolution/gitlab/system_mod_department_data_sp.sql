USE [ZhiQuanMedicalCare]
GO
/****** Object:  StoredProcedure [dbo].[system_mod_department_data_sp]    Script Date: 01/12/2018 16:41:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =====================Arctic_Wolf========================
-- 存储过程名称:exec system_mod_department_data_sp
-- 功能描述: 编辑部门
-- 创建人: Young
-- 创建时间: 2018/01/10
-- 摘要说明: 创建
-- =====================Arctic_Wolf========================
ALTER PROCEDURE [dbo].[system_mod_department_data_sp]
    @loginUserId INT , --当前用户
    @id INT ,
    @departmentName NVARCHAR(100),
	@mechanismId INT,
	@departmentId INT,
    @note NVARCHAR(400)
AS
    BEGIN
        UPDATE  [TBDepartment]
        SET     DepartmentName = @departmentName ,
				MechanismId =@mechanismId ,
				DepartmentId = @departmentId ,
                Note = @note ,
                Modifier = @loginUserId ,
                ModifyTime = GETDATE()
        WHERE   ID = @id
    END

