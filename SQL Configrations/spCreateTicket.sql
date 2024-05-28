CREATE OR ALTER PROCEDURE [dbo].[spCreateTblTicket]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table ticket
    @price NVARCHAR(50), 
    @final_price NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblTicket]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@price, '') IS NULL OR NULLIF(@final_price, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblTicket]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblTicket]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@price+'] INT NOT NULL, 
						['+@final_price+'] INT NULL, 
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblTicket]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
