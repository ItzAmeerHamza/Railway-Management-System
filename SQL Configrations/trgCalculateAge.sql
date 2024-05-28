CREATE OR ALTER TRIGGER trig_calculateAgeForPessenger
ON [RailwaysDB].[dbo].[PESSENGER]
AFTER INSERT, UPDATE
AS
BEGIN
	UPDATE [RailwaysDB].[dbo].[PESSENGER]
	SET [RailwaysDB].[dbo].[PESSENGER].[Age] = DATEDIFF(YY,I.Date_Of_Birth,GETDATE())
	FROM INSERTED AS I
	WHERE [RailwaysDB].[dbo].[PESSENGER].[Id] = I.Id
END;
