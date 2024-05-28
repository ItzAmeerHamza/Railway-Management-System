CREATE PROCEDURE [dbo].[spCreateTblTrainInfo]
    @tblname NVARCHAR(50), -- the table name
	-- specified attributes in table traininfo
    @seats NVARCHAR(50), 
    @arrival_location NVARCHAR(50), 
    @arrival_time NVARCHAR(50),
    @departure_time NVARCHAR(50),
    @departure_location NVARCHAR(50),
    @available_seats NVARCHAR(50)

AS
BEGIN
	BEGIN TRAN [CreateTblTrainInfo]

		-- creating the table using dynamic SQL
		IF (NULLIF(@tblname, '') IS NULL OR NULLIF(@seats, '') IS NULL OR NULLIF(@arrival_location, '') IS NULL OR NULLIF(@arrival_time, '') IS NULL OR NULLIF(@departure_time, '') IS NULL OR NULLIF(@departure_location, '') IS NULL OR NULLIF(@available_seats, '') IS NULL)
		BEGIN
			print 'ERROR: Cannot create Table '+@tblname+', passed values are invalid'
			ROLLBACK TRAN [CreateTblTrainInfo]
		END
		ELSE -- if all the attributes are present then create the table
		BEGIN
			IF OBJECT_ID(@tblname) IS NOT NULL
			BEGIN
				print 'ERROR: '+@tblname+' Already Exists in the Data Base!'
				ROLLBACK TRAN [CreateTblTrainInfo]
			END
			ELSE
			BEGIN
				DECLARE @Query VARCHAR(MAX) = '
				IF OBJECT_ID(''[dbo].['+@tblname+']'') IS NULL 
				BEGIN
					CREATE TABLE [dbo].['+@tblname+']
					(
						[Id] INT IDENTITY(1,1) PRIMARY KEY, 
						['+@seats+'] INT NOT NULL, 
						['+@arrival_location+'] NVARCHAR(100) NULL, 
						['+@arrival_time+'] DATETIME NULL, 
						['+@departure_time+'] DATETIME NULL, 
						['+@departure_location+'] NVARCHAR(100) NULL, 
						['+@available_seats+'] INT NULL, 
					)
				END
				'

				EXEC (@Query)
				COMMIT TRAN [CreateTblTrainInfo]
				print 'Transection commited, Successfully created table '+@tblname+'!'
			END
		END
END
