CREATE TABLE TB_PADRAO
( ID INT IDENTITY(1,1) NOT NULL,
DESCRITOR VARCHAR(20) NULL, 
ENDERECO VARCHAR(20) NULL,
CIDADE VARCHAR(20) DEFAULT 'Rio de Janeiro',
DATA_CRIACAO DATE DEFAULT GETDATE());

INSERT INTO TB_PADRAO
(DESCRITOR)
VALUES
('Cliente Y');

SELECT * FROM TB_PADRAO