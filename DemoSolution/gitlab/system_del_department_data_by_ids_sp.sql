USE [ZhiQuanMedicalCare]
GO
/****** Object:  StoredProcedure [dbo].[system_del_department_data_by_ids_sp]    Script Date: 01/12/2018 16:41:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =====================Arctic_Wolf========================
-- 存储过程名称:exec system_del_department_data_by_ids_sp
-- 功能描述: 删除部门数据
-- 创建人: Young
-- 创建时间: 2018/01/12
-- 摘要说明: 创建
-- =====================Arctic_Wolf========================
ALTER PROCEDURE [dbo].[system_del_department_data_by_ids_sp]
	@ids VARCHAR(500)  --ID集合
AS
BEGIN
	BEGIN TRY
            BEGIN TRANSACTION MyTrans--开始事务
            
            DECLARE @sql NVARCHAR(MAX);
            SET @sql = '';
            SET @sql = @sql + 'UPDATE TBDepartment SET IsDeleted=1
				WHERE ID in (' + @ids + ') ';
				
            EXEC(@sql);
			
            COMMIT TRANSACTION MyTrans--事务提交语句
            RETURN 1;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION MyTrans
			--抛出异常
            DECLARE @ErrorMessage NVARCHAR(4000);
            DECLARE @ErrorSeverity INT;
            DECLARE @ErrorState INT;
		
            SELECT  @ErrorMessage = ERROR_MESSAGE() ,
                    @ErrorSeverity = ERROR_SEVERITY() ,
                    @ErrorState = ERROR_STATE();
            RAISERROR (@ErrorMessage,  -- Message text.
				   @ErrorSeverity, -- Severity.
				   @ErrorState     -- State.
				   );
            RETURN -1;		   
        END CATCH
END

