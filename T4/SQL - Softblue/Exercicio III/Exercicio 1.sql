create table tipo (
	Id integer unsigned not null auto_increment,
	tipo varchar(45) not null,	
	primary key(Id)	
);
create table instrutor (
	Id integer unsigned not null auto_increment,	
	instrutor varchar(45) not null,	
	telefone varchar(45) null,	
	primary key(Id)			
);

create table curso (
	Id integer unsigned not null auto_increment,	
	curso varchar(45) not null,			
	tipo integer unsigned not null,			
	instrutor integer unsigned not null,		
	valor double not null,					
	primary key(Id),					
	index fk_tipo(tipo),					
	index fk_instrutor(instrutor),				
	foreign key(tipo) references tipo(Id),		
	foreign key(instrutor) references instrutor(Id)	
);

create table aluno (
	Id integer unsigned not null auto_increment,	
	aluno varchar(45) not null,			
	endereco varchar(45) not null,		
	email varchar(45) not null,			
	primary key(Id)					
);

create table pedido (
	Id integer unsigned not null auto_increment,	
	aluno integer unsigned not null,			
	datahora datetime not null,				
	primary key(Id),				
	index fk_aluno(aluno),					
	foreign key(aluno) references aluno(Id)		
);

create table PEDIDO_has_CURSO (
	pedido integer unsigned not null,
	curso integer unsigned not null,
	valor double not null,		
	index fk_pedido(pedido),		
	index fk_curso(curso),		
	primary key(pedido, curso),		
	foreign key(pedido) references pedido(Id),
	foreign key(curso) references curso(Id)
);


alter table aluno add data_nascimento varchar(10);
alter table aluno change data_nascimento nascimento date null;
alter table aluno add index index_aluno(aluno);
alter table instrutor add email varchar(100);
alter table curso add index index_instrutor(instrutor);
alter table instrutor drop email;

