CREATE PROCEDURE [dbo].[ClientesInsertar]
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
	DECLARE @SucursalId varchar(450);
	DECLARE @CodigoSucursal varchar(5);
	DECLARE @CodigoCliente varchar(20);
	DECLARE @Secuencia numeric(10)

	SELECT @SucursalId = SucursalId
	FROM AspNetUsers 
	WHERE UserName = @Usuario

	SELECT @CodigoSucursal = Codigo
	FROM Sucursales
	WHERE Id = @SucursalId

	IF EXISTS(SELECT 1 FROM Clientes WHERE TipoDocumentoId = @TipoDocumentoId AND NroDocumento = @NroDocumento)
	BEGIN
		RAISERROR ('Tipo y Numero de Documento Duplicado', -- Message text.  
				11, -- Severity.  
				1 -- State.  
			); 
	END

	BEGIN TRAN
		EXEC @Secuencia = NextNumero 'Clientes',@SucursalId

		SET @CodigoCliente = IsNULL(@CodigoSucursal,'00') + RIGHT('0000000000' + RTRIM(LTRIM(CONVERT(VARCHAR(10),@Secuencia))) ,8)

		INSERT INTO Clientes(Id,Codigo,Apellido,Nombre,RazonSocial,
							TipoDocumentoId,NroDocumento,CuilCuit,
							FechaNacimiento,EstadoCivilId,NacionalidadId,
							ProvinciaId,Localidad,CodigoPostal,Calle,CalleNro,
							PisoDpto,OtrasReferencias,Telefono,Celular,Email,
							Estado,FechaAlta,UsuarioAlta)
			VALUES(@Id,UPPER(@CodigoCliente),UPPER(@Apellido),UPPER(@Nombre),UPPER(@Apellido) + ' ' + UPPER(@Nombre),
					@TipoDocumentoId,UPPER(@NroDocumento),UPPER(@CuilCuit),@FechaNacimiento,@EstadoCivilId,@NacionalidadId,
					@ProvinciaId,UPPER(@Localidad),UPPER(@CodigoPostal),UPPER(@Calle),UPPER(@CalleNro),
					UPPER(@PisoDpto),UPPER(@OtrasReferencias),UPPER(@Telefono),UPPER(@Celular),UPPER(@Email),@Estado,
					DATEADD(HH,4,GETDATE()),UPPER(@Usuario))
	COMMIT;	

END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0 
		ROLLBACK;

	DECLARE @ErrorMessage NVARCHAR(4000);  
	DECLARE @ErrorSeverity INT;  
	DECLARE @ErrorState INT;  
	
	SELECT @ErrorMessage = ERROR_MESSAGE(),@ErrorSeverity = ERROR_SEVERITY(),@ErrorState = ERROR_STATE();  

	INSERT INTO SisErroresLogs(Id,FechaHora,Modulo,ErrorMessage,ErrorSeverity,ErrorState)
	VALUES(NEWID(),GETDATE(),'ClientesInsertar',@ErrorMessage,@ErrorSeverity,@ErrorState)

	RAISERROR (@ErrorMessage, -- Message text.  
				@ErrorSeverity, -- Severity.  
				@ErrorState -- State.  
			);  
END CATCH