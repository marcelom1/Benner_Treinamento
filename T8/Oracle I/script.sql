alter table compras add (forma_pagt varchar2(10) check (forma_pagt in ('boleto','dinheiro','cartao')));
update compras set forma_pagt = 'dinheiro' where forma_pagt is null;
alter table compras rename column forma_pagt to forma_pagto;
select sum(valor) from compras;
select sum(valor) from compras where data >'01-JAN-2010';
select avg(valor) from compras;
select count(id) from compras where data between '01-JAN-2010' and '31-DEZ-2010';
select sum(valor) as soma, avg (valor) as media from compras;
select sum (valor) from compras where recebido = '1';
select sum (valor) from compras where recebido = '0';
select recebido, sum(valor) from compras group by recebido;
select extract(year from data), sum(valor) from compras group by extract(year from data);
select extract(year from data) as ano , sum(valor) as soma from compras group by extract(year from data) order by ano;
SELECT AVG(VALOR) AS MEDIA FROM COMPRAS WHERE DATA < '12-MAR-2009';
SELECT FORMA_PAGTO, SUM(VALOR) AS SOMA FROM COMPRAS WHERE DATA < '10-NOV-2010' GROUP BY FORMA_PAGTO;
SELECT COUNT(1) AS QUANTIDADE FROM COMPRAS WHERE DATA < '12-MAR-2009' AND RECEBIDO = '1';
SELECT RECEBIDO, FORMA_PAGTO, SUM(VALOR) AS SOMA FROM COMPRAS GROUP BY FORMA_PAGTO, RECEBIDO;
create table compradores (
id number primary key,
nome varchar2(30) not null,
endereco varchar2(30) not null,
telefone varchar2(20) not null);
create sequence id_compradores_seq;
insert into compradores (id, nome, endereco, telefone) values(id_compradores_seq.nextval, 'Flavio', 'Rua do ouvidor, 123','(21)1111-1111');
insert into compradores (id, nome, endereco, telefone) values(id_compradores_seq.nextval, 'Nico', 'Av. Presidente Vargas, 123','(21) 2222-2222');
alter table compras add (comprador_id number);
set linesize 150;
update compras set comprador_id = 2 where id>20;
select observacoes, valor, nome from compras join compradores on compras.comprador_id=compradores.id;
alter table compras add foreign key (comprador_id) references compradores(id);
SELECT NOME, VALOR FROM COMPRAS JOIN COMPRADORES ON COMPRAS.COMPRADOR_ID = COMPRADORES.ID WHERE DATA < '09-JUL-2010';
SELECT * FROM COMPRAS WHERE COMPRADOR_ID =1;
SELECT COMPRAS.* FROM COMPRAS JOIN COMPRADORES ON COMPRAS.COMPRADOR_ID = COMPRADORES.ID WHERE NOME LIKE 'FLAVIO%';
SELECT NOME, SUM(VALOR) AS SOMA FROM COMPRAS JOIN COMPRADORES ON COMPRAS.COMPRADOR_ID = COMPRADORES.ID GROUP BY NOME;