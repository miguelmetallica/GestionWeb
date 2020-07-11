CREATE PROCEDURE ClientesObtener
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,
		Codigo,
		Apellido,
		Nombre,
		RazonSocial,
		TipoDocumentoId,
		NroDocumento,
		Foto,
		FechaNacimiento,
		EstadoCivilId,
		NacionalidadId,
		esPersonaJuridica,
		ProvinciaId,
		Localidad,
		CodigoPostal,
		Calle,
		NroCalle,
		OtrasReferencias,
		Telefono,
		Celular,
		Email,
		Estado,
		FechaAlta,
		UsuarioAlta Usuario
	FROM Clientes
END