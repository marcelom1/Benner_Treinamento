create index indice_por_lancamento on livros (data_de_lancamento);

desc livros;
(select count(l2.data_de_lancamento) from livros l2 where l2.data_de_lancamento = l.data_de_lancamento) as anteriores from livros l order by l.data_de_lancamento;


create table emails (
     id integer primary key auto_increment not null,
     usuario_id int not null,
     email varchar(100) not null,
     is_primario boolean,
     FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);

create table receitas (
     id integer primary key auto_increment not null,
     crm_medico varchar(50) not null,
     medico varchar(100) not null,
     nome_remedio varchar(100) not null,
     valor decimal(10,2) not null,
     quantidade int not null,
     valor_total decimal(10,2)
);
INSERT INTO receitas(crm_medico, medico, nome_remedio, valor, quantidade, valor_total) values ('889999-PR', 'Lucas da Silva', 'Pura t4', 30.50, 2, 61.0);
INSERT INTO receitas(crm_medico, medico, nome_remedio, valor, quantidade, valor_total) values ('987654-SP', 'Maria dos Santos', 'Gadernal', 6.30, 4, 25.20);
INSERT INTO receitas(crm_medico, medico, nome_remedio, valor, quantidade, valor_total) values ('997755-RJ', 'Ivá Souza', 'Sildenafila', 68.10, 10, 681.00);
INSERT INTO receitas(crm_medico, medico, nome_remedio, valor, quantidade, valor_total) values ('118745-DF', 'Paula Barbosa', 'Vasopril', 80.70, 5, 403.50);
INSERT INTO receitas(crm_medico, medico, nome_remedio, valor, quantidade, valor_total) values ('765930-CE', 'Celina Prates', 'Allegra', 46.70, 1, 46.70);

select * from receitas order by valor_total desc;

select nome_remedio, valor, quantidade, valor_total from receitas order by valor_total desc;
