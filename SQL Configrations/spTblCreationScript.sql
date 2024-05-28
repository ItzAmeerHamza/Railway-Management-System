CREATE OR ALTER PROCEDURE [dbo].[spCreateTblWorker]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table preson
    @firstName NVARCHAR(50), 
    @lastName NVARCHAR(50), 
    @contact NVARCHAR(50),
    @dateofbirth NVARCHAR(50),
    @age NVARCHAR(50),
    @gender NVARCHAR(50),
    @role NVARCHAR(50), -- attribute to distinguish between the employee and admin
    @dateofhiring NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblWorker]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@firstname, '') IS NULL OR NULLIF(@lastname, '') IS NULL OR NULLIF(@contact, '') IS NULL OR NULLIF(@dateofbirth, '') IS NULL OR NULLIF(@age, '') IS NULL OR NULLIF(@gender, '') IS NULL OR NULLIF(@dateofhiring, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblWorker]
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
					['+@age+'] AS ( DATEDIFF(HOUR,['+@dateofbirth+'],GETDATE())/8766 ), 
					['+@gender+'] NVARCHAR(50) NULL,
					['+@dateofhiring+'] DATETIME NOT NULL,
					['+'role'+'] NVARCHAR(20) NOT NULL
				)
			END
			'

			EXEC (@Query)
			COMMIT TRAN [spCreateTblWorker]
			print 'Transection commited, Successfully created table '+@tblname+'!'
		END
END
