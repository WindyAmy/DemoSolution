USE [ZhiQuanMedicalCare]
GO
/****** Object:  StoredProcedure [dbo].[system_qry_department_list_by_condition_sp]    Script Date: 01/12/2018 16:41:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =====================Arctic_Wolf========================
-- 存储过程名称:exec system_qry_department_list_by_condition_sp '','','','','',-1
-- 功能描述: 查询部门数据
-- 创建人: Young
-- 创建时间: 2018/01/12
-- 摘要说明: 创建
-- =====================Arctic_Wolf========================
ALTER PROCEDURE [dbo].[system_qry_department_list_by_condition_sp]
    @departmentName VARCHAR(200) , --部门名称   
    @pdepartmentId int , --上级部门ID  
    @mechanismId int  -- 
  
AS
    BEGIN
        SET NOCOUNT ON;  
		         
        DECLARE @sqlMain NVARCHAR(MAX)                
        SET @sqlMain = ''                
        SET @sqlMain = @sqlMain
            + 'SELECT DepartmentData.* FROM (/****** Script for SelectTopNRows command from SSMS  ******/
							SELECT
								a.[ID],
								a.[DepartmentName],
								a.[MechanismId],
								a.[DepartmentId],
								a.[Note],
								a.[IsDeleted],
								a.[Creater],
								a.[CreateTime],
								a.[Modifier],
								a.[ModifyTime],
								b.DepartmentName,
								c.Name
							FROM [TBDepartment] AS a
							LEFT JOIN [TBDepartment] AS b
								ON a.DepartmentId = b.ID
								AND a.IsDeleted = 0
								AND b.IsDeleted = 0
							LEFT JOIN [TBSupplier] AS c
								ON a.MechanismId = c.ID
								AND a.IsDeleted = 0
								AND c.IsDeleted = 0)DepartmentData
				WHERE DepartmentData.IsDeleted=0 '        
        
        IF ISNULL(@departmentName, '') <> ''
            BEGIN
                SET @sqlMain = @sqlMain + ' AND DepartmentData.DepartmentName LIKE ''%'
                    + CONVERT(NVARCHAR(200), @departmentName) + '%'''
            END        
        IF ISNULL(@pdepartmentId, -1) <> -1
            BEGIN
                SET @sqlMain = @sqlMain + ' AND DepartmentData.@departmentId = '
                    + CONVERT(INT, @pdepartmentId)
            END 
              IF ISNULL(@mechanismId, -1) <> -1
            BEGIN
                SET @sqlMain = @sqlMain + ' AND DepartmentData.@mechanismId = '
                    + CONVERT(int, @mechanismId)
            END 
			
        SET @sqlMain = @sqlMain + ' ORDER BY DepartmentData.CreateTime DESC'         
        EXEC (@sqlMain)
    END

