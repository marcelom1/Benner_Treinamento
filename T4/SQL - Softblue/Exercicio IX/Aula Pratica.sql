use curso_sql;
create table pedidos(
	id int unsigned not null auto_increment,
    descricao varchar(100) not null ,
    valor double not null default '0',
    pago varchar (3) not null default 'Não',
    primary key(id)
);

insert into pedidos (descricao, valor) values ('TV',3000);
insert into pedidos (descricao, valor) values ('Geladeira',1400);
insert into pedidos (descricao, valor) values ('DVD',300);

select *from pedidos;
call limpa_pedidos();


create table estoque (
	id int unsigned not null auto_increment,
    descricao varchar(50) not null,
    quantidade int not null,
    primary key (id)
);

create trigger gatilho_limpa_pedidos
before insert 
on estoque
for each row
call limpa_pedidos();

select * from pedidos;
update pedidos set pago = 'Sim' where id=8;


insert into estoque (descricao ,quantidade) values ('Fogao',5);
select * from estoque;

insert into estoque (descricao ,quantidade) values ('Forno',3);
select * from estoque;
select * from pedidos;


