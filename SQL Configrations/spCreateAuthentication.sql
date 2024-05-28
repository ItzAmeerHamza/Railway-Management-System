CREATE OR ALTER PROCEDURE [dbo].[spCreateTblAuthentication]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table authentication
    @user_name NVARCHAR(50),
    @email NVARCHAR(50),
    @password NVARCHAR(50),
    @worker_id NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblAuthentication]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@user_name, '') IS NULL OR NULLIF(@email, '') IS NULL OR NULLIF(@password, '') IS NULL OR NULLIF(@worker_id, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblAuthentication]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblAuthentication]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@user_name+'] NVARCHAR(50) NOT NULL, 
						['+@email+'] NVARCHAR(100) NOT NULL, 
						['+@password+'] NVARCHAR(100) NOT NULL, 
						['+@worker_id+'] INT NOT NULL
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblAuthentication]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END



