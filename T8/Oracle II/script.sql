

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

select c.nome, m.tipo, count(m.id) as quantidade from matricula m join curso c on c.id=m.curso_id where m.tipo = 'PAGA_PF' or m.tipo='PAGA_PJ group by c.nome, m.tipo;

SQL> select c.nome, m.tipo, count(m.id) as quantiade from matricula m join curso c on c.id = m.curso_id where m.tipo in ('PAGA_PF', 'PAGA_PJ') group by c.nome,m.tipo;


SQL> select a.nome, c.nome from curso c join matricula m on m.curso_id = c.id join aluno a on a.id = m.aluno_id where a.id in (1,3,4) order by a.nome;


SQL> select a.nome, c.nome from curso c join matricula m on m.curso_id = c.id join aluno a on a.id = m.aluno_id where c.id in (1,9);

SQL> select a.nome, (select count(r.id) from resposta r where a.id=r.aluno_id) as respostas from aluno a;


SQL> select a.nome, (select count(m.id) from matricula m where m.aluno_id = a.id) as matriculas from aluno a;

SQL> select a.nome, count(r.id) as respostas from aluno a left join resposta r on r.aluno_id = a.id group by a.nome;

select a.nome, r.resposta_dada from aluno a right join resposta r on r.aluno_id = a.id;

select a.nome, r.resposta_dada from aluno a left join resposta r on a.id = r.aluno_id;


SQL> select * from (select rownum r, nome from (select a.nome from aluno a order by a.nome)) where r>5;


SQL> select * from (select rownum r, nome from (select a.nome from aluno a order by a.nome) where rownum<=10) where r>5


















