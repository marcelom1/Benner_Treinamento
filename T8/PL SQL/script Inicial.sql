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


DECLARE
    v_id number(5) := 1;
    v_descricao varchar2(100) := 'varejo';
BEGIN
    INSERT INTO segmercado VALUES (v_id, v_descricao);
    commit;

END;

select * from segmercado;




DECLARE
    v_id segmercado.id%type := 2;
    v_descricao segmercado.descricao%type := 'atacado';
BEGIN
    INSERT INTO segmercado VALUES (v_id, upper(v_descricao));
    COMMIT;
END;


select * from segmercado;




DECLARE
    v_id segmercado.id%type := 1;
    v_descricao segmercado.descricao%type := 'varejista';
BEGIN
    UPDATE segmercado
        SET descricao = UPPER(v_descricao)
        WHERE id = v_id;

    v_id := 2;
    v_descricao := 'atacadista';

    UPDATE segmercado
        SET descricao = UPPER(v_descricao)
        WHERE id = v_id;
    COMMIT;
END;

select * from SEGMERCADO;



DECLARE
    v_id segmercado.id%type := 3;
    v_descricao segmercado.descricao%type := 'esportivo';
BEGIN
    INSERT INTO segmercado VALUES (v_id, upper(v_descricao));
    COMMIT;
END;

select * from SEGMERCADO


DECLARE
    v_id segmercado.id%type := 3;
BEGIN
    DELETE FROM segmercado
        WHERE id = v_id;
    COMMIT;
END;

select * from SEGMERCADO



CREATE PROCEDURE incluir_segmercado
    (p_id IN NUMBER ,
    p_descricao IN VARCHAR2)
IS
BEGIN
    INSERT into segmercado
            values(p_id, UPPER(p_descricao));
    COMMIT;
END;


EXECUTE incluir_segmercado(3, 'Farmaceutico');

BEGIN
    incluir_segmercado(4, 'Industrial');
END;

select * from segmercado;




CREATE OR REPLACE PROCEDURE incluir_segmercado
    (p_id IN segmercado.id%type ,
    p_descricao IN segmercado.descricao%type)
IS
BEGIN
    INSERT into segmercado
        values(p_id, UPPER(p_descricao));
    COMMIT;
END;

select * from segmercado




CREATE OR REPLACE FUNCTION obter_descricao_segmercado
    (p_id IN segmercado.id%type)
    RETURN segmercado.descricao%type
IS
    v_descricao segmercado.descricao%type;
BEGIN
    SELECT descricao INTO v_descricao
        FROM segmercado
        WHERE id = p_id;
    RETURN v_descricao;
END;

VARIABLE g_descricao varchar2(100)
EXECUTE :g_descricao := obter_descricao_segmercado (1)
PRINT g_descricao


SET SERVEROUTPUT ON
DECLARE
    v_descricao segmercado.descricao%type;
BEGIN
    v_descricao := obter_descricao_segmercado(2);
    dbms_output.put_line('Descricao: '||v_descricao);
END;





CREATE OR REPLACE PROCEDURE INCLUIR_CLIENTE
    (p_id in cliente.id%type,
    p_razao_social IN cliente.razao_social%type,
    p_CNPJ cliente.CNPJ%type ,
    p_segmercado_id IN cliente.segmercado_id%type,
    p_faturamento_previsto IN cliente.faturamento_previsto%type)

IS
    v_categoria cliente.categoria%type;

BEGIN
    IF p_faturamento_previsto < 10000 THEN
        v_categoria := 'PEQUENO';
    ELSIF p_faturamento_previsto < 50000 THEN
        v_categoria := 'MEDIO';
    ELSIF p_faturamento_previsto < 100000 THEN
        v_categoria := 'MEDIO GRANDE';
    ELSE
        v_categoria := 'GRANDE';
    END IF;

    INSERT INTO cliente
        VALUES (p_id, UPPER(p_razao_social),p_CNPJ,p_segmercado_id, SYSDATE, p_faturamento_previsto, v_categoria);
    COMMIT;
END;




EXECUTE INCLUIR_CLIENTE(1, 'SUPERMERCADO XYZ', '12345', NULL, 150000);

SELECT * FROM CLIENTE





CREATE OR REPLACE FUNCTION categoria_cliente
    (p_faturamento_previsto IN cliente.faturamento_previsto%type)
    RETURN cliente.categoria%type
IS
BEGIN
    IF p_faturamento_previsto < 10000 THEN
        RETURN 'PEQUENO';
    ELSIF p_faturamento_previsto < 50000 THEN
        RETURN 'MEDIO';
    ELSIF p_faturamento_previsto < 100000 THEN
        RETURN 'MEDIO GRANDE';
    ELSE
        RETURN 'GRANDE';
    END IF;
END;


EXECUTE INCLUIR_CLIENTE(2, 'SUPERMERCADO IJK', '67890', NULL, 90000);

select * from cliente



CREATE OR REPLACE PROCEDURE FORMAT_CNPJ
    (p_cnpj IN out cliente.CNPJ%type)
IS
BEGIN
    p_cnpj := substr(p_cnpj,1,2) ||'/'|| substr(p_cnpj,3);
END;

VARIABLE g_cnpj varchar2(10)
EXECUTE :g_cnpj := '12345'
PRINT g_cnpj

EXECUTE FORMAT_CNPJ(:g_cnpj)






CREATE OR REPLACE PROCEDURE ATUALIZAR_CLI_SEG_MERCADO
    (p_id cliente.id%type,
    p_segmercado_id IN cliente.segmercado_id%type)
IS
BEGIN
    UPDATE cliente
        SET segmercado_id = p_segmercado_id
        WHERE id = p_id;
    COMMIT;
END;


DECLARE
    v_segmercado_id cliente.segmercado_id%type;
    v_i number(3);
BEGIN
        v_i := 1;
LOOP
        ATUALIZAR_CLI_SEG_MERCADO(v_i, v_segmercado_id);
        v_i := v_i + 1;
        EXIT WHEN v_i > 3;
END LOOP;
END;




DECLARE
    v_segmercado_id cliente.segmercado_id%type := 2;
BEGIN
 FOR i in 1..3 LOOP
     ATUALIZAR_CLI_SEG_MERCADO(i, v_segmercado_id);
    END LOOP;
    COMMIT;
END;




DECLARE
    v_id                                NUMBER;
    v_segmercado_id            NUMBER;
BEGIN
    v_id := 1;
    v_segmercado_id := 2;
    atualizar_cli_seg_mercado(p_id => v_id,p_segmercado_id => v_segmercado_id);
--rollback;
END;



DECLARE
    v_id cliente.id%type;
    v_segmercado_id cliente.segmercado_id%type := 1;
    CURSOR cur_cliente is
        SELECT id
        FROM cliente;
BEGIN
        OPEN cur_cliente;
        LOOP
            FETCH cur_cliente into v_id;
            EXIT WHEN cur_cliente%NOTFOUND;
            ATUALIZAR_CLI_SEG_MERCADO(v_id, v_segmercado_id);
        END LOOP;
        
        CLOSE cur_cliente;
        
        COMMIT;

END;


DECLARE
    v_segmercado_id cliente.segmercado_id%type := 2;
    CURSOR cur_cliente is
        SELECT id
        FROM cliente;
BEGIN
    FOR cli_rec IN cur_cliente LOOP
        ATUALIZAR_CLI_SEG_MERCADO(cli_rec.id, v_segmercado_id);
    END LOOP;

    COMMIT;

END;