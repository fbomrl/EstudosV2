


CREATE FUNCTION FaturamentoNOta (@NUMERO AS VARCHAR)
RETURNS FLOAT
AS
BEGIN
	DECLARE @FATURAMENTO FLOAT
SELECT @FATURAMENTO = SUM(QUANTIDADE * [PRECO])
FROM [dbo].[TABELA_DE_ITENS_VENDIDOS]
WHERE NUMERO = 100
RETURN @FATURAMENTO

END;

	SELECT NUMERO, DBO.FaturamentoNota(NUMERO) AS FATURAMENTO FROM [dbo].[TABELA_DE_ITENS_VENDIDOS];