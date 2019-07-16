use curso_sql;

insert into tipo values (1, 'banco de dados');
insert into tipo values (2, 'programação');
insert into tipo values (3, 'modelagem de dados');

insert into instrutor values (1, 'andré milani', '1111-1111');
insert into instrutor values (2, 'carlos tosin', '1212-1212');

insert into curso values (1, 'java fundamentos', 2, 2, 270);
insert into curso values (2, 'java avançado', 2, 2, 330);
insert into curso values (3, 'sql completo', 1, 1, 170);
insert into curso values (4, 'php básico', 2, 1, 270);

insert into aluno (Id, aluno, endereco, email) values (1, 'josé', 'rua xv de novembro 72', 'jose@softblue.com.br');
insert into aluno (Id, aluno, endereco, email) values (2, 'wagner', 'av. paulista', 'wagner@softblue.com.br');
insert into aluno (Id, aluno, endereco, email) values (3, 'emílio', 'rua lajes 103, ap: 701', 'emilio@softblue.com.br');
insert into aluno (Id, aluno, endereco, email) values (4, 'cris', 'rua tauney 22', 'cris@softblue.com.br');
insert into aluno (Id, aluno, endereco, email) values (5, 'regina', 'rua salles 305', 'regina@softblue.com.br');
insert into aluno (Id, aluno, endereco, email) values (6, 'fernando', 'av. central 30', 'fernando@softblue.com.br');


insert into pedido values (1, 2, '2010-04-15 11:23:32');
insert into pedido values (2, 2, '2010-04-15 14:36:21');
insert into pedido values (3, 3, '2010-04-16 11:17:45');
insert into pedido values (4, 4, '2010-04-17 14:27:22');
insert into pedido values (5, 5, '2010-04-18 11:18:19');
insert into pedido values (6, 6, '2010-04-19 13:47:35');
insert into pedido values (7, 6, '2010-04-20 18:13:44');

insert into PEDIDO_has_CURSO values (1, 1, 270);
insert into PEDIDO_has_CURSO values (1, 2, 330);
insert into PEDIDO_has_CURSO values (2, 1, 270);
insert into PEDIDO_has_CURSO values (2, 2, 330);
insert into PEDIDO_has_CURSO values (2, 3, 170);
insert into PEDIDO_has_CURSO values (3, 4, 270);
insert into PEDIDO_has_CURSO values (4, 2, 330);
insert into PEDIDO_has_CURSO values (4, 4, 270);
insert into PEDIDO_has_CURSO values (5, 3, 170);
insert into PEDIDO_has_CURSO values (6, 3, 170);
insert into PEDIDO_has_CURSO values (7, 4, 270);


select * from aluno;
select curso from curso;
select curso, valor from curso where valor > 200;
select curso, valor from curso where valor > 200 and valor < 300;
select curso, valor from curso where valor between 200 and 300;
select * from pedido where datahora > '2010-04-15' and datahora < '2010-04-19';
select * from pedido where datahora between '2010-04-15' and '2010-04-19';
select * from pedido where date(datahora) = '2010-04-15';


update aluno set endereco = 'av. brasil 778' where codigo = 1;
update aluno set email = 'cristiano@softblue.com.br' where codigo = 4;
update curso set valor = valor * 1.1 where valor < 300;
update curso set curso = 'php fundamentos' where curso = 'php básico';

