use AppRoupa;

-- 1
create table  users (
		id INTEGER PRIMARY KEY IDENTITY,
        name VARCHAR(100),
        username VARCHAR(100) UNIQUE,
        password VARCHAR(50),
        cpf VARCHAR(11),
		date_birthday DATE,
		creditCard VARCHAR(30),
		typeUser VARCHAR(3) DEFAULT 'CLI' -- ADM(Administrator) and CLI(client)
);

create table cloth(
	id INTEGER PRIMARY KEY IDENTITY,
	description_product TEXT,
	price NUMERIC(5, 2),
	brand VARCHAR(50),
	photo VARCHAR(300),
	provider VARCHAR(110),
	datePost DATE,
	qtdInventory INTEGER
);

create table venda(
		id INTEGER PRIMARY KEY IDENTITY,
		foreign_id_users INTEGER,
		foreign_id_cloth INTEGER,
		date_created DATE,
		qtd INTEGER,
		foreign key (foreign_id_users) references users(id),
		foreign key (foreign_id_cloth) references cloth(id)
);