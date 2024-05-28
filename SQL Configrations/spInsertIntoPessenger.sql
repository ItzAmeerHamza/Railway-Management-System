CREATE OR ALTER PROCEDURE sp_insertIntoPassenger
       @Fname                      NVARCHAR(50)  = NULL   , 
       @Lname                      NVARCHAR(50)  = NULL   , 
       @Contact                    NVARCHAR(50)  = NULL   , 
       @DOB						   DATETIME      = NULL   , 
	   @Gender                     NVARCHAR(50)  = NULL   , 
       @Email                      NVARCHAR(50)  = NULL   ,
	   @pass					   NVARCHAR(50)  = NULL   
AS 
BEGIN 
     SET NOCOUNT ON 

	 BEGIN TRAN [insertIntoPassenger]
	 IF (NULLIF(@Fname, '') IS NULL OR NULLIF(@Lname, '') IS NULL OR NULLIF(@Contact, '') IS NULL OR NULLIF(@Email, '') IS NULL OR NULLIF(@pass, '') IS NULL)
	 BEGIN
		print 'ERROR: Can`t insert in the table due to missing data'
		ROLLBACK TRAN [spCreateTblAuthentication]
	 END
	 ELSE
	 BEGIN
		 INSERT INTO [RailwaysDB].[dbo].[PESSENGER]
			  (                    
				[First Name]                     ,
				[Last Name]                      ,
				[Contact]                        ,
				[Date_Of_Birth]					 ,
				[Gender]						 ,
				[Email]							
			  ) 
		 VALUES 
			  ( 
				@Fname,
				@Lname,
				@Contact,
				@DOB,
				@Gender,
				@Email
			  )
			  COMMIT TRAN [spCreateTblAuthentication]
			  print 'Successfully inserted data in the table'
	 END

END 

GO