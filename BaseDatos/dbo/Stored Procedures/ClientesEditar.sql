CREATE PROCEDURE DBO.ClientesEditar
	@Id varchar(450),
	@Apellido nvarchar(150),
	@Nombre nvarchar(150),
	@TipoDocumentoId nvarchar(450),
	@NroDocumento nvarchar(11),
	@CuilCuit nvarchar(11),
	@FechaNacimiento datetime,
	@EstadoCivilId nvarchar(450),
	@NacionalidadId nvarchar(450),
	@ProvinciaId nvarchar(450),
	@Localidad nvarchar(250),
	@CodigoPostal nvarchar(10),
	@Calle nvarchar(500),
	@CalleNro nvarchar(10),
	@PisoDpto nvarchar(100),
	@OtrasReferencias nvarchar(500),
	@Telefono nvarchar(15),
	@Celular nvarchar(15),
	@Email nvarchar(150),
	@Estado bit,
	@Usuario nvarchar(450)
AS
BEGIN TRY
	SET NOCOUNT ON;
	
	BEGIN TRAN
		UPDATE Clientes
		SET Apellido = UPPER(@Apellido),
			Nombre = UPPER(@Nombre),
			RazonSocial = UPPER(@Apellido) + ' ' + UPPER(@Nombre),
			TipoDocumentoId = @TipoDocumentoId,
			NroDocumento = UPPER(@NroDocumento),
			CuilCuit = UPPER(@CuilCuit),
			FechaNacimiento = @FechaNacimiento,
			EstadoCivilId = @EstadoCivilId,
			NacionalidadId = @NacionalidadId,
			ProvinciaId = @ProvinciaId,
			Localidad = UPPER(@Localidad),
			CodigoPostal = UPPER(@CodigoPostal),
			Calle = UPPER(@Calle),
			CalleNro = UPPER(@CalleNro),
			PisoDpto = UPPER(@PisoDpto),
			OtrasReferencias = UPPER(@OtrasReferencias),
			Telefono = UPPER(@Telefono),
			Celular = UPPER(@Celular),
			Email = UPPER(@Email),
			Estado = @Estado			
		WHERE Id = @Id;
	COMMIT;

	SELECT 1 Id

END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0 
		ROLLBACK;

	DECLARE @ErrorMessage NVARCHAR(4000);  
	DECLARE @ErrorSeverity INT;  
	DECLARE @ErrorState INT;  
	
	SELECT @ErrorMessage = ERROR_MESSAGE(),@ErrorSeverity = ERROR_SEVERITY(),@ErrorState = ERROR_STATE();  

	INSERT INTO SisErroresLogs(Id,FechaHora,Modulo,ErrorMessage,ErrorSeverity,ErrorState)
	VALUES(NEWID(),GETDATE(),'ClientesEditar',@ErrorMessage,@ErrorSeverity,@ErrorState)

	RAISERROR (@ErrorMessage, -- Message text.  
				@ErrorSeverity, -- Severity.  
				@ErrorState -- State.  
			);  
END CATCH