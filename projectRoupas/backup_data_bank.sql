-- create database AppRoupa
-- crie um usuario na mão preferencialmente um ADM

use AppRoupa;

GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [name]          VARCHAR (100) NULL,
    [username]      VARCHAR (100) NULL,
    [password]      VARCHAR (50)  NULL,
    [cpf]           VARCHAR (11)  NULL,
    [date_birthday] DATE          NULL,
    [creditCard]    VARCHAR (30)  NULL,
    [typeUser]      VARCHAR (3)   NULL DEFAULT 'CLI' -- pode ser 'CLI' ou 'ADM'
);

CREATE TABLE [dbo].[cloth] (
    [id]                  INT            IDENTITY (1, 1) NOT NULL,
    [description_product] TEXT           NULL,
    [price]               NUMERIC (5, 2) NULL,
    [brand]               VARCHAR (50)   NULL,
    [photo]               VARCHAR (300)  NULL,
    [provider]            VARCHAR (110)  NULL,
    [datePost]            DATE           NULL,
    [qtdInventory]        INT            NULL
);

CREATE TABLE [dbo].[business] (
    [id]               INT  IDENTITY (1, 1) NOT NULL,
    [foreign_id_users] INT  NULL,
    [foreign_id_cloth] INT  NULL,
    [date_created]     DATE NULL,
    [qtd]              INT  NULL,
    [businessStatus]   INT  NULL,
	foreign key (foreign_id_users) references users(id),
	foreign key (foreign_id_cloth) references cloth(id)
);