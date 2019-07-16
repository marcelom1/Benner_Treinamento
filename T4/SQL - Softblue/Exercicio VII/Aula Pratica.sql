/*create user 'marcelo'@'200.200.190' identified by '123456';*/

/*create user 'marcelo'@'%' identified by '123456';*/

create user 'marcelo'@'localhost' identified by '123456';
grant all on curso_sql.* to 'marcelo'@'localhost';

create user 'marcelo'@'%' identified by '123456';
grant select on curso_sql.* to 'marcelo'@'%';
grant insert on curso_sql.* to 'marcelo'@'%';

grant select on curso_sql.funcionarios to 'marcelo'@'%';

revoke insert on curso_sql.funcionarios from 'marcelo'@'%';
revoke select on curso_sql.* from 'marcelo'@'%';

grant select on curso_sql.funcionarios to 'marcelo'@'%';
grant select on curso_sql.veiculos to 'marcelo'@'%';


revoke insert on curso_sql.funcionarios from 'marcelo'@'%';
revoke insert on curso_sql.veiculos from 'marcelo'@'%';

revoke all on curso_sql.* from 'marcelo'@'localhost';

drop user 'marcelo'@'localhost';

select user from mysql.user;

show grants for 'marcelo'@'%';

