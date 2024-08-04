Categoria(cat_cod int Not Null PK, nome varchar(30) Not Null);
Produtos(prod_cod int Not Null PK, descricao varchar(50) data_dia date, forn_cod references Fornecedor(for))
Pede(quantidade int Not Null PK, valor_unitario float Not Null, data_dia date, forn_cod references)



CREATE TABLE categoria(
  		codigo INT PRIMARY KEY,
  		nome varchar(100)
  );


CREATE TABLE pede (
  	produto_codigo INT,
  	quantidade INT,
  	valor_unitario DECIMAL(10,2),
  	DATA DATE,
  	PRIMARY KEY (produto_codigo, DATA),
  	FOREIGN KEY (produto_codigo) REFERENCES produtos (codigo)
  );

CREATE TABLE Matricula (
    Cod_Mat INT NOT NULL PRIMARY KEY,
    id_aluno INT NOT NULL,
    data_matr DATE,
    id_disciplina INT,
    FOREIGN KEY (id_aluno) REFERENCES Aluno(id),
    FOREIGN KEY (id_disciplina) REFERENCES Disciplina(id)
);