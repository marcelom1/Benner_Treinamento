select aluno.nome, curso.nome from aluno join matricula on matricula.aluno_id = aluno.id join curso on curso.id=matricula.curso_id;

SQL> select a.nome, c.nome from aluno a join matricula m on m.aluno_id = a.id join curso c on m.curso_id=c.id;

SQL> select a.nome from aluno a where exists ( select m.id from matricula m where m.aluno_id = a.id);

SQL> select * from exercicio e where not exists(select r.id from resposta r where r.exercicio_id = e.id);

select c.nome from curso c where not exists (select m.id from matricula m where m.curso_id = c.id
);

select c.nome, avg(n.nota) from nota n join resposta r on r.id=n.resposta_id join exercicio e on e.id=r.exercicio_id join secao s on s.id=e.seca_id join curso c on c.id = s.curso_id gruoup by c.nome;


SQL> select count(e.id) from exercicio e join secao s on s.id = e.secao_id join curso c on c.id=s.curso_id group by c.nome;

SQL> select count(e.id) from exercicio e join secao s on s.id = e.secao_id join curso c on c.id=s.curso_id group by c.nome;


SQL> select c.nome, count(a.id) from curso c join matricula m on m.curso_id=c.id join aluno a on a.id = m.aluno_id group by c.nome;

select c.nome, avg(n.nota) as media from nota n join resposta r on r.id = n.resposta_id join exercicio e on e.id = r.exercicio_id join secao s on s.id = e.secao_id join curso c on c.id = s.curso_id group by c.nome;

select c.nome, avg(n.nota) as media from nota n join resposta r on r.id = n.resposta_id join exercicio e on e.id = r.exercicio_id join secao s on s.id = e.secao_id join curso c on c.id = s.curso_id join aluno a on a.id = r.aluno_id where a.nome like '%Santos%' or a.nome like '%Silva%' group by c.nome;

select e.pergunta, count(r.id) as quantidade from exercicio e join resposta r on r.exercicio_id = e.id group by e.pergunta;

select e.pergunta, count(r.id) as quantidade from exercicio e 
 join resposta r on r.exercicio_id = e.id group by e.pergunta order by count(r.id) desc;

select a.nome, c.nome, avg(n.nota) as media from nota n join resposta r on r.id = n.resposta_id join exercicio e on e.id = r.exercicio_id join secao s on s.id = e.secao_id join curso c on c.id = s.curso_id join aluno a on a.id = r.aluno_id group by a.nome, c.nome;


SQL> select a.nome, c.nome, avg(n.nota) from aluno a join resposta r on r.id =n.resposta_id join exercicio e on e.id=r.exercicio_id join secao s on s.id = e.secao_id join curso c on c.id=s.curso_id join aluno a on a.id = c.aluno_id gruoup by a.nome, c.nome having avg(n.nota)<5;


SQL> select count(a.id), c.nome from curso c join matricula m on m.curso_id = c.id join aluno a on a.id = m.aluno_id group by c.nome having count (a.id)<3;






















