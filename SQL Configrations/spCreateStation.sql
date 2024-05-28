CREATE OR ALTER PROCEDURE [dbo].[spCreateTblStation]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table station
    @description NVARCHAR(50),
    @type NVARCHAR(50),
    @name NVARCHAR(50),
    @capacity NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblStation]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@description, '') IS NULL OR NULLIF(@type, '') IS NULL OR NULLIF(@name, '') IS NULL OR NULLIF(@capacity, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblStation]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblStation]
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
						['+@description+'] NVARCHAR(50) NULL, 
						['+@type+'] NVARCHAR(50) NULL, 
						['+@capacity+'] INT NULL
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblStation]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
