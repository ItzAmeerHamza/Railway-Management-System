CREATE OR ALTER PROCEDURE [dbo].[spCreateTblAddress] -- for multi valued value created seprate table
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table address
    @city NVARCHAR(50),
    @streat NVARCHAR(50),
    @state NVARCHAR(50) 

AS
BEGIN
	BEGIN TRAN [spCreateTblAddress]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@city, '') IS NULL OR NULLIF(@streat, '') IS NULL OR NULLIF(@state, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblAddress]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblAddress]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@city+'] NVARCHAR(50) NULL, 
						['+@streat+'] NVARCHAR(50) NULL, 
						['+@state+'] NVARCHAR(50) NULL
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblAddress]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
