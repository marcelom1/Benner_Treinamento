CREATE TABLE segmercado (id NUMBER(5),
    descricao VARCHAR2(100));
    
ALTER TABLE Segmercado
    ADD CONSTRAINT segmercado_id_pk PRIMARY KEY(ID);
    
CREATE TABLE cliente
    ( ID NUMBER(5),
        razao_social VARCHAR2(100),
        CNPJ VARCHAR2(20),
        segmercado_id NUMBER(5),
        data_inclusao DATE,
        faturamento_previsto NUMBER(10,2),
        categoria VARCHAR2(20));
        
ALTER TABLE cliente
    ADD CONSTRAINT cliente_id_pk PRIMARY KEY(ID);
    
ALTER TABLE cliente
    ADD CONSTRAINT cliente_segmercado_fk
    FOREIGN KEY(segmercado_id)
    REFERENCES segmercado(id) ;


set SERVEROUT on    
declare
    v_id number(5) :=1;

begin
    v_id :=2;
    dbms_output.put_line(v_id);
    
end;


declare

begin

end;



