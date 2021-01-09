USE QL_CuaHangTapHoa
GO

-- Create a new stored procedure called 'usp_DonViTinh_GetAll' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_DonViTinh_GetAll'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_DonViTinh_GetAll
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.usp_DonViTinh_GetAll    
AS
    SELECT *
    FROM DonViTinh
GO