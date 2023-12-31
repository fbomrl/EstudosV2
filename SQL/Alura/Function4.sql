DECLARE @LIMITE_MINIMO INT, @LIMITE_MAXIMO INT
DECLARE @TABELA_NUMEROS TABLE (CODIGO INT, [STATUS] VARCHAR (200))
DECLARE @CONTADOR_NOTAS INT

SET @LIMITE_MINIMO = 1
SET @LIMITE_MAXIMO = 1000000

SET NOCOUNT ON 
WHILE @LIMITE_MINIMO <= @LIMITE_MAXIMO
BEGIN
 SELECT @CONTADOR_NOTAS = COUNT(*) FROM [dbo].[PRODUTOS] WHERE CODIGO = @LIMITE_MINIMO
 IF @CONTADOR_NOTAS > 0
	BEGIN
		INSERT INTO @TABELA_NUMEROS (CODIGO, STATUS) VALUES (@LIMITE_MINIMO, '� UM PRODUTO')
	END
 ELSE
	BEGIN
		INSERT INTO @TABELA_NUMEROS (CODIGO, STATUS) VALUES (@LIMITE_MINIMO, 'N�O � UM PRODUTO')
	END
 SET @LIMITE_MINIMO = @LIMITE_MINIMO + 1

END
SELECT * FROM @TABELA_NUMEROS ORDER BY CODIGO

SELECT MIN(CODIGO), MAX(CODIGO) FROM [dbo].[PRODUTOS]