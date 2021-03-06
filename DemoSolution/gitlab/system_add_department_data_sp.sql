USE [ZhiQuanMedicalCare]
GO
/****** Object:  StoredProcedure [dbo].[system_add_department_data_sp]    Script Date: 01/12/2018 16:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =====================Arctic_Wolf========================
-- 存储过程名称:system_add_department_data_sp
-- 功能描述: 新建部门
-- 创建人: Young
-- 创建时间: 2018/01/11
-- 摘要说明: 创建
-- =====================Arctic_Wolf========================
ALTER PROCEDURE [dbo].[system_add_department_data_sp]
    @loginUserId INT , --当前用户
	@departmentName NVARCHAR(100),
	@mechanismId INT,
	@departmentId INT,
    @note NVARCHAR(400)
AS
    BEGIN
         INSERT INTO [TBDepartment]
                            ([DepartmentName]
                            ,[MechanismId]
                            ,[DepartmentId]
                            ,[Note]
                            ,[IsDeleted]
                            ,[Creater]
                            ,[CreateTime]
                            ,[Modifier]
                            ,[ModifyTime])
        VALUES  ( @departmentName ,
				  @mechanismId, 
				  @departmentId,
                  @note , -- Note - nvarchar(400)
                  0 , -- IsDeleted - int
                  @loginUserId , -- Creater - int
                  GETDATE() , -- CreateTime - datetime
                  @loginUserId , -- Modifier - int
                  GETDATE()  -- ModifyTime - datetime
	            )
        SELECT  @@IDENTITY AS ID; 
    END

