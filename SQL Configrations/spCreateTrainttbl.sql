CREATE PROCEDURE [dbo].[spCreateTblTrain]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table preson
    @trainName NVARCHAR(50), 
    @traindesc NVARCHAR(50), 
    @type NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN create_tbl_train

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@trainName, '') IS NULL OR NULLIF(@traindesc, '') IS NULL OR NULLIF(@type, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN create_tbl_train
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN

			DECLARE @Query VARCHAR(MAX) = '
			IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
			BEGIN
				CREATE TABLE [dbo].['+@tblname+']
				(
					[Id] INT IDENTITY(1,1) PRIMARY KEY, 
					['+@trainName+'] NVARCHAR(50) NOT NULL, 
					['+@traindesc+'] NVARCHAR(50) NULL, 
					['+@type+'] NVARCHAR(50) NOT NULL, 
				)
			END
			'

			EXEC (@Query)
			COMMIT TRAN create_tbl_train
			print 'Transection commited, Successfully created table '+@tblname+'!'
		END
END
