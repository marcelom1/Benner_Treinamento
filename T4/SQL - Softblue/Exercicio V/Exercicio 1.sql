select curso.curso, tipo.tipo from curso inner join tipo on curso.tipo = tipo.Id;
select curso.curso, tipo.tipo, instrutor.instrutor, instrutor.telefone from curso inner join tipo on curso.tipo = tipo.Id inner join instrutor on curso.instrutor = instrutor.Id;
select Id, datahora, curso from pedido inner join PEDIDO_has_CURSO on pedido.Id = PEDIDO_has_CURSO.pedido;
select pedido.Id, datahora, curso.curso from pedido inner join PEDIDO_has_CURSO on pedido.Id = PEDIDO_has_CURSO.pedido inner join curso on PEDIDO_has_CURSO.curso = curso.Id;
select pedido.Id, datahora, aluno.aluno, curso.curso from pedido inner join PEDIDO_has_CURSO on pedido.Id = PEDIDO_has_CURSO.pedido inner join curso on PEDIDO_has_CURSO.curso = curso.Id inner join aluno on pedido.aluno = aluno.Id;


create view cursos_programacao as select curso, valor from curso inner join tipo on curso.tipo = tipo.Id where tipo.tipo = 'programação';
create view cursos_programacao_completo as select curso, tipo.tipo, instrutor.instrutor from curso inner join tipo on curso.tipo = tipo.Id inner join instrutor on curso.instrutor = instrutor.Id;
create view pedidos_realizados as select pedido.Id, pedido.datahora, aluno.aluno from pedido inner join aluno on pedido.aluno = aluno.Id;

