use curso_sql;

select * from funcionarios;

select count(*) from funcionarios;
select count(*) from funcionarios where salario>2000;

select count(*) from funcionarios where salario>2000 and departamento = 'Jurídico';

select * from funcionarios where salario>1000 and departamento = 'Jurídico';


select sum(salario) from funcionarios;
select sum(salario) from funcionarios where departamento ='TI';

select avg(salario) from funcionarios;
select avg(salario) from funcionarios where departamento ='TI';


select MAX(salario) from funcionarios;
select MAX(salario) from funcionarios where departamento ='TI';


select Min(salario) from funcionarios;
select Min(salario) from funcionarios where departamento ='TI';

select departamento from funcionarios;
select distinct departamento from funcionarios;

select *from funcionarios;
select *from funcionarios order by nome;
select *from funcionarios order by nome desc;

select *from funcionarios order by salario;
select *from funcionarios order by departamento;
select *from funcionarios order by departamento desc,salario desc;

select *from funcionarios;
select *from funcionarios limit 2 offset 1;
select *from funcionarios limit 2,2;

select avg(salario) from funcionarios;
select avg(salario) from funcionarios where departamento = 'TI';

select departamento, avg(salario) from funcionarios group by departamento;
select departamento from funcionarios group by departamento having avg (salario)>2000;


select departamento, count(*) from funcionarios group by departamento;

select departamento, avg(salario) from funcionarios group by departamento;
select nome from funcionarios where departamento = 'TI';

select nome from funcionarios where departamento in(select departamento from funcionarios group by departamento having avg (salario)>2000);

