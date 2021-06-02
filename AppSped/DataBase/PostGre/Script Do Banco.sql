
CREATE DATABASE db_enricone
GO


CREATE TABLE public.usuarios  ( 
	codigo  	serial NOT NULL,
	razao   	varchar(40) NULL,
	cnpj_cpf	varchar(14) NULL,
	cadastr 	date NULL,
	endereco	varchar(40) NULL,
	bairro  	varchar(40) NULL,
	cidade  	varchar(40) NULL,
	uf      	varchar(2) NULL,
	cep     	varchar(8) NULL,
	tel1    	varchar(23) NULL,
	tel2    	varchar(23) NOT NULL,
	email   	varchar(100) NULL,
	senha   	varchar(10) NULL,
	PRIMARY KEY(codigo)
)
WITHOUT OIDS 
TABLESPACE pg_default