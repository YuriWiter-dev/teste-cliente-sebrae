create database dbCliente;

use dbCliente; 

CREATE TABLE Cliente(
Id INT IDENTITY(1,1),
Nome varchar(255) not null,
Telefone varchar(11) not null,
CPF varchar(11) not null,
PlacaCarro varchar(7) not null,
PRIMARY KEY (Id)
);