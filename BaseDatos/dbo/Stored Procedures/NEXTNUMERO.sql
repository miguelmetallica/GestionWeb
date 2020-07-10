CREATE PROCEDURE DBO.[NEXTNUMERO]
	@Parametro [NVARCHAR](150),
	@SucursalId [NVARCHAR](450)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;        
	DECLARE @Numero NUMERIC(10)

	SELECT @Numero = Numero FROM SisNumeraciones WHERE Parametro = @Parametro AND SucursalId = @SucursalId
	
	IF @Numero IS NULL    
		INSERT INTO SisNumeraciones (Id,Parametro,SucursalId,NUMERO)VALUES(NEWID(),@Parametro,@SucursalId,0)     
	
	BEGIN TRAN     
		SELECT @Numero = Numero FROM SisNumeraciones WITH (UPDLOCK,HOLDLOCK) WHERE Parametro = @Parametro   
		UPDATE SisNumeraciones SET Numero = Numero + 1 WHERE Parametro = @Parametro		
		SET @Numero = @Numero + 1    
	COMMIT     	

	RETURN @Numero

END