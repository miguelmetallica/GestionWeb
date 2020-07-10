CREATE PROCEDURE [dbo].[ObtenerClientePaginacion]
	@Nombre nvarchar(500),
	@Ordenamiento nvarchar(500),
	@NumeroPagina int,
	@CantidadElementos int,
	@TotalRecords int output,
	@TotalPaginas int output
AS
BEGIN
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	DECLARE @INICIO INT
	DECLARE @FIN INT
	IF @NumeroPagina = 1
	BEGIN
		SET @INICIO = (@NumeroPagina - @CantidadElementos) - @CantidadElementos
		SET @FIN = @NumeroPagina * @CantidadElementos
	END
	ELSE
	BEGIN
		SET @INICIO = ((@NumeroPagina * @CantidadElementos) - @CantidadElementos) + 1
		SET @FIN = @NumeroPagina * @CantidadElementos
	END

	CREATE TABLE #TMP(
		ROWNUMER INT IDENTITY(1,1),
		CLIENTE_ID INT
	)

	DECLARE @SQL NVARCHAR(MAX)
	SET @SQL = 'SELECT ID FROM CLIENTES '

	IF @Nombre IS NOT NULL
	BEGIN
		SET @SQL = @SQL + 'WHERE NOMBRE LIKE ''%' + @Nombre + '%'' OR APELLIDO LIKE ''%' + @Nombre + '% '''  
	END

	IF @Ordenamiento IS NOT NULL
	BEGIN
		SET @SQL = @SQL + 'ORDER BY ' + @Ordenamiento 
	END
	INSERT INTO #TMP
	EXEC SP_EXECUTESQL @SQL
	--SELECT Id,
	--	Codigo,
	--	Apellido,
	--	Nombre,
	--	RazonSocial,
	--	TipoDocumentoId,
	--	NroDocumento,
	--	CuilCuit,
	--	Foto,
	--	FechaNacimiento,
	--	EstadoCivilId,
	--	NacionalidadId,
	--	esPersonaJuridica,
	--	ProvinciaId,
	--	Localidad,
	--	CodigoPostal,
	--	Calle,
	--	CalleNro,
	--	PisoDpto,
	--	OtrasReferencias,
	--	Telefono,
	--	Celular,
	--	Email,
	--	Estado,
	--	FechaAlta,
	--	UsuarioAlta Usuario
	--FROM Clientes
	
	SELECT @TotalRecords = COUNT(*) FROM #TMP
	IF @TotalRecords > @CantidadElementos
	BEGIN
		SET @TotalPaginas = @TotalRecords / @CantidadElementos
		IF (@TotalRecords % @CantidadElementos) > 0
		BEGIN
			SET @TotalPaginas = @TotalPaginas + 1
		END		
	END
	ELSE
	BEGIN
		SET @TotalPaginas = 1
	END
	
	SELECT Id,
		Codigo,
		Apellido,
		Nombre,
		RazonSocial,
		TipoDocumentoId,
		NroDocumento,
		CuilCuit,
		Foto,
		FechaNacimiento,
		EstadoCivilId,
		NacionalidadId,
		esPersonaJuridica,
		ProvinciaId,
		Localidad,
		CodigoPostal,
		Calle,
		CalleNro,
		PisoDpto,
		OtrasReferencias,
		Telefono,
		Celular,
		Email,
		Estado,
		FechaAlta,
		UsuarioAlta Usuario
	FROM #TMP P
	INNER JOIN Clientes C ON C.Id = P.CLIENTE_ID
	WHERE P.ROWNUMER >= @INICIO
	AND P.ROWNUMER <= @FIN

END