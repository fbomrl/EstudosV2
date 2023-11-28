
CREATE PROCEDURE BuscaNotasCliente
@CPF AS VARCHAR(12) = '19290992743', 
@DATA_INICIAL AS DATETIME = '20160101',
@DATA_FINAL AS DATETIME = '20161231'
AS
BEGIN
	SELECT * FROM [NOTAS_FISCAIS] WHERE CPF = @CPF
	AND DATA_VENDA >= @DATA_INICIAL AND DATA_VENDA <= @DATA_FINAL;
END;

EXEC BuscaNotasCliente
EXEC BuscaNotasCliente '19290992743', '20160501'
-- Quando declaramos a variável, podemos coloca-las em ordens alternadas.
EXEC BuscaNotasCliente @DATA_FINAL='20160615' , @CPF='19290992743', @DATA_INICIAL='20160501'
-- Quando utiliza-se o Default, virá com o valor padrão da variável.
EXEC BuscaNotasCliente '19290992743', DEFAULT, '20160615'
