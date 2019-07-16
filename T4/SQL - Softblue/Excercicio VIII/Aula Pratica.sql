use curso_sql;

show engines;

create table contas_bancarias
(
	id int unsigned not null auto_increment,
    titular varchar(45) not null,
    saldo double not null,
    primary key (id)
)engine =InnoDB;

insert into contas_bancarias(titular, saldo) values ('marcelo',1000);
insert into contas_bancarias(titular, saldo) values ('pedro',2000);

select * from contas_bancarias;

start transaction;
update contas_bancarias set saldo = saldo - 100 where id = 1;
update contas_bancarias set saldo = saldo + 100 where id = 2;
rollback;

start transaction;
update contas_bancarias set saldo = saldo - 100 where id = 1;
update contas_bancarias set saldo = saldo + 100 where id = 2;
commit;