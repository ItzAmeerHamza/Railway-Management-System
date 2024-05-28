CREATE OR ALTER PROCEDURE [dbo].[spCreateTblReservation]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table reservation
    @pessenger_id NVARCHAR(50),
    @train_id NVARCHAR(50),
    @trainInfo_id NVARCHAR(50),
    @ticket_id NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [spCreateTblReservation]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@pessenger_id, '') IS NULL OR NULLIF(@train_id, '') IS NULL OR NULLIF(@trainInfo_id, '') IS NULL OR NULLIF(@ticket_id, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [spCreateTblReservation]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN -- check for either the table exist and rollback
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [spCreateTblReservation]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@pessenger_id+'] NVARCHAR(50) NOT NULL, 
						['+@train_id+'] NVARCHAR(100) NOT NULL, 
						['+@trainInfo_id+'] NVARCHAR(100) NOT NULL, 
						['+@ticket_id+'] INT NOT NULL
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [spCreateTblReservation]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
