CREATE OR ALTER PROCEDURE [dbo].[spCreateTblRoute]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table route
    @name NVARCHAR(50),
    @description NVARCHAR(50),
    @point NVARCHAR(50),
    @pick_up_point NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblRoute]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@name, '') IS NULL OR NULLIF(@description, '') IS NULL OR NULLIF(@point, '') IS NULL OR NULLIF(@pick_up_point, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblRoute]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblRoute]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@name+'] NVARCHAR(50) NOT NULL, 
						['+@description+'] NVARCHAR(100) NULL, 
						['+@point+'] NVARCHAR(100) NULL, 
						['+@pick_up_point+'] NVARCHAR(100) NULL
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblRoute]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
