CREATE TABLE Cidade (
    codcid INT PRIMARY KEY,
    nome VARCHAR(255),
    uf CHAR(2)
);

CREATE TABLE Filial (
    codfilial INT PRIMARY KEY,
    nome VARCHAR(255),
    endereco VARCHAR(255),
    codcid INT,
    FOREIGN KEY (codcid) REFERENCES Cidade(codcid)
);

CREATE TABLE Empregado (
    codemp INT PRIMARY KEY,
    nome VARCHAR(255),
    endereco VARCHAR(255),
    codcid INT,
    ct VARCHAR(255),
    rg VARCHAR(255),
    cpf VARCHAR(11),
    salario DECIMAL(10, 2),
    codfilial INT,
    FOREIGN KEY (codcid) REFERENCES Cidade(codcid),
    FOREIGN KEY (codfilial) REFERENCES Filial(codfilial)
);

CREATE TABLE Produto (
    codprod INT PRIMARY KEY,
    descricao VARCHAR(255),
    preco DECIMAL(10, 2),
    nomecategoria VARCHAR(255),
    descricaocategoria VARCHAR(255)
);

CREATE TABLE Vende (
    codprod INT,
    codfilial INT,
    PRIMARY KEY (codprod, codfilial),
    FOREIGN KEY (codprod) REFERENCES Produto(codprod),
    FOREIGN KEY (codfilial) REFERENCES Filial(codfilial)
);


SELECT MAX(preco) AS ValorProdutoMaisCaro
FROM Produto;


SELECT MIN(preco) AS ValorProdutoMaisBarato
FROM Produto;



SELECT AVG(preco) AS MediaPrecos
FROM Produto;


SELECT P.descricao AS NomeProduto
FROM Produto P
JOIN Vende V ON P.codprod = V.codprod
WHERE V.codfilial = 3;
SELECT E.nome AS NomeEmpregado, E.rg AS RgEmpregado
FROM Empregado E
JOIN Cidade C ON E.codcid = C.codcid
WHERE C.uf = 'RS' AND E.salario > 500;


SELECT P.descricao AS NomeProduto, P.preco AS PrecoProduto, F.nome AS NomeFilial
FROM Produto P
JOIN Vende V ON P.codprod = V.codprod
JOIN Filial F ON V.codfilial = F.codfilial;
