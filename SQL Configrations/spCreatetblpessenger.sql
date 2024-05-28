CREATE OR ALTER PROCEDURE [dbo].[spCreateTblPessenger]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table pessenger
    @firstName NVARCHAR(50), 
    @lastName NVARCHAR(50), 
    @contact NVARCHAR(50),
    @dateofbirth NVARCHAR(50),
    @age NVARCHAR(50),
    @gender NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblPessenger]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@firstname, '') IS NULL OR NULLIF(@lastname, '') IS NULL OR NULLIF(@contact, '') IS NULL OR NULLIF(@dateofbirth, '') IS NULL OR NULLIF(@age, '') IS NULL OR NULLIF(@gender, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblPessenger]
		END
		ELSE -- if all the attributes are present then perform the tasks
		BEGIN

			DECLARE @Query VARCHAR(MAX) = '
			IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
			BEGIN
				CREATE TABLE [dbo].['+@tblname+']
				(
					[Id] INT IDENTITY(1,1) PRIMARY KEY, 
					['+@firstname+'] NVARCHAR(50) NOT NULL, 
					['+@lastname+'] NVARCHAR(50) NOT NULL, 
					['+@contact+'] NVARCHAR(50) NOT NULL, 
					['+@dateofbirth+'] DATETIME NULL, 
					['+@age+'] INT, 
					['+@gender+'] NVARCHAR(50) NULL,
				)
			END
			'

			EXEC (@Query)
			COMMIT TRAN [spCreateTblPessenger]
			print 'Transection commited, Successfully created table '+@tblname+'!'
		END
END
