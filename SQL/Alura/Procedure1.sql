SELECT CPF, NOME, [DATA DE NASCIMENTO], IDADE FROM TABELA_DE_CLIENTES

SELECT DATEDIFF(YEAR, '2000-01-01', GETDATE())


SELECT CPF, NOME, [DATA_DE_NASCIMENTO], IDADE, DATEDIFF(YEAR, [DATA_DE_NASCIMENTO], GETDATE())
 FROM TABELA_DE_CLIENTES



 CREATE PROCEDURE CalculaIdade
 AS
 BEGIN
	UPDATE TABELA_DE_CLIENTES SET IDADE = DATEDIFF(YEAR, DATA_DE_NASCIMENTO, GETDATE())
 END;

 INSERT INTO TABELA_DE_CLIENTES
 (CPF, NOME, ENDERECO_1, BAIRRO, CIDADE, ESTADO, CEP, DATA_DE_NASCIMENTO, IDADE, SEXO, LIMITE_DE_CREDITO, VOLUME_DE_COMPRA, PRIMEIRA_COMPRA)
 VALUES
 ('123456789', 'Jo�o Machado', 'Rua Projetada A', 'Madurera', 'Rio de Janeiro', 'RJ', '20000', '2000-01-01' , 10, 'M', 12000, 12000, 1); 


 SELECT * FROM TABELA_DE_CLIENTES WHERE CPF = '123456789';
 EXEC [dbo].[CalculaIdade]