
CREATE TABLE Empre_Depart (
    Num_Emp INT PRIMARY KEY,
    Nome_Emp VARCHAR(100),
    Salario DECIMAL(10, 2),
    Num_Depto INT UNIQUE,
    Nome_Depto VARCHAR(100)
);


CREATE TABLE Projeto (
    Id_Projeto INT PRIMARY KEY,
    Nome_Projeto VARCHAR(100)
);


CREATE TABLE Participa_de (
    Num_Emp INT,
    Id_Projeto INT,
    Hs_Trab INT,
    PRIMARY KEY (Num_Emp, Id_Projeto),
    FOREIGN KEY (Num_Emp) REFERENCES Empre_Depart(Num_Emp),
    FOREIGN KEY (Id_Projeto) REFERENCES Projeto(Id_Projeto)
);


CREATE TABLE Dependente (
    Id_Dep INT PRIMARY KEY,
    Nome_Dep VARCHAR(100),
    Data_Nasc DATE,
    Num_Emp INT,
    FOREIGN KEY (Num_Emp) REFERENCES Empre_Depart(Num_Emp)
);





INSERT INTO Empre_Depart (Num_Emp, Nome_Emp, Salario, Num_Depto, Nome_Depto) VALUES
(1, 'João', 3000.00, 1, 'RH'),
(2, 'Pedro', 3500.00, 2, 'TI'),
(3, 'Anderson', 3200.00, 3, 'Marketing');


INSERT INTO Projeto (Id_Projeto, Nome_Projeto) VALUES
(1, 'Projeto A'),
(2, 'Projeto B'),
(3, 'Projeto C');


INSERT INTO Participa_de (Num_Emp, Id_Projeto, Hs_Trab) VALUES
(1, 1, 10),
(2, 2, 20),
(3, 3, 15);


INSERT INTO Dependente (Id_Dep, Nome_Dep, Data_Nasc, Num_Emp) VALUES
(1, 'Renata', '2010-05-15', 1),
(2, 'Eduardo', '2012-08-22', 2),
(3, 'Alceu', '2014-12-30', 3);
