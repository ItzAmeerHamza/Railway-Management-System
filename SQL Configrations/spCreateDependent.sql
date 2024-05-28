CREATE OR ALTER PROCEDURE [dbo].[spCreateTblDependent]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table dependent
    @name NVARCHAR(50),
    @date_of_birth NVARCHAR(50),
    @age NVARCHAR(50) -- the calculated field

AS
BEGIN
	BEGIN TRAN [spCreateTblDependent]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@name, '') IS NULL OR NULLIF(@date_of_birth, '') IS NULL OR NULLIF(@age, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblDependent]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblDependent]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@name+'] NVARCHAR(50) NULL, 
						['+@date_of_birth+'] DATETIME NULL, 
						['+@age+'] AS ( DATEDIFF(HOUR,['+@date_of_birth+'],GETDATE())/8766 )
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblDependent]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
