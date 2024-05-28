CREATE OR ALTER PROCEDURE [dbo].[spCreateTblCoach]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table coach
    @capacity NVARCHAR(50), 
    @class NVARCHAR(50), 
    @category NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblCoach]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@capacity, '') IS NULL OR NULLIF(@class, '') IS NULL OR NULLIF(@category, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblCoach]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblCoach]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@capacity+'] INT NOT NULL, 
						['+@class+'] NVARCHAR(50) NULL, 
						['+@category+'] NVARCHAR(50) NULL, 
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblCoach]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
