#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <time.h>
#define ENTER  0x0D


struct funcionarios
{
    char codigofuncionario[10];
    char CEcodigonivel[10];
    char noab[30];
    char nome[30];
    char senha[30];
};

struct niveis
{
    char codigonivel[10];
    char descricao[30];
};

struct emprestimos
{
    char codigoemprestimo[10];
    char CEcodigoexemplar[10];
    char CEcodigofuncionario[10];
    char data[10];
    char dataprevisao[10];
    char dataefetiva[10];
};
struct exemplares
{
    char codigoexemplar[10];
    char nedicao[10];
    char disponivel[30];
    char descricao[30];
    char autor[30];
    char editora[50];
    char area[30];
};

int arqexiste (char* arquivo, char* modo);
int BuscaDados(FILE* Arq, char* linha);
void DesmontaUmaLinhaNiveis(char *buffer, struct niveis *nivel,int l);
void cadastroniveis (struct niveis *nivel);
void cadastrofuncionarios (struct funcionarios *funcionario,struct niveis *nivel);
void DesmontaUmaLinhaFuncionarios(char *buffer, struct funcionarios *funcionario,int l);
void GravaArquivoNivel (struct niveis *nivel, FILE *Arq, int l);
struct niveis *CarregarMemoriaNivel (struct niveis *nivel, FILE * Arq, int *l,int motivo);
struct funcionarios *CarregarMemoriaFuncionario (struct funcionarios *funcionario, FILE *Arq, int *l,int motivo);
void GravaArquivoFuncionario (struct funcionarios *funcionario,FILE *Arq,int l);
void login (struct funcionarios *funcionario, struct niveis *nivel, struct exemplares *exemplar, struct emprestimos *emprestimo);
void menu (struct funcionarios *funcionario, struct niveis *nivel, struct exemplares *exemplar, struct emprestimos *emprestimo);
struct exemplares *CarregarMemoriaExemplar (struct exemplares *exemplar, FILE *Arq, int *l,int motivo);
void GravaArquivoExemplar (struct exemplares *exemplar,FILE *Arq,int l);
void cadastroexemplares (struct exemplares *exemplar);
void DesmontaUmaLinhaExemplares(char *buffer, struct exemplares *exemplar,int l);
void cadastroemprestimo (struct emprestimos *emprestimo, struct funcionarios *funcionario, struct exemplares *exemplar);
struct emprestimos *CarregarMemoriaEmprestimo (struct emprestimos *emprestimo, FILE * Arq, int *l,int motivo);
void GravaArquivoEmprestimo (struct emprestimos *empretimo, FILE *Arq, int l);
void DesmontaUmaLinhaEmprestimo(char *buffer, struct emprestimos *emprestimo,int l);
int VerificarStructFuncionario (struct funcionarios *funcionario,char *busca,int F,char *CNivel,char *cookie,char senha[10]);
void LeituraFuncionario(struct funcionarios *funcionario,int l);
void ConverterData(int motivo, char *dataBR);
void devolucao (struct emprestimos *emprestimo, struct exemplares * exemplar);
void MenuConsulta (struct exemplares *exemplar, struct emprestimos *emprestimo, char *cookie);

/* FUNÇÃO PARA CARREGAR O ARQUIVO NIVEL NA MEMORIA*/
struct niveis *CarregarMemoriaNivel (struct niveis *nivel, FILE * Arq, int *l,int motivo)
{
    int i=0;
    int retorno=99;
    char buffer[1024];
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        i++;
    }
    fclose(Arq);
    Arq = fopen("niveis.txt","r");
    nivel = (struct niveis*) malloc (i*sizeof(struct niveis));
    retorno=99;
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        if (retorno != NULL)
        {
            DesmontaUmaLinhaNiveis(buffer,nivel,*l);
            (*l)++;
        }
    }
    if (motivo==0)
    {
        itoa(*l,nivel[*l].codigonivel,10);
    }
    fclose(Arq);
    return nivel;
}

/* FUNÇÃO PARA CARREGAR O ARQUIVO FUNCIONARIO NA MEMORIA*/
struct funcionarios *CarregarMemoriaFuncionario (struct funcionarios *funcionario, FILE *Arq, int *l,int motivo)
{
    int i=0;
    int retorno=99;
    char buffer[1024];
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        i++;
    }
    fclose(Arq);
    Arq = fopen("funcionarios.txt","r");
    funcionario = (struct funcionarios*) malloc (i*sizeof(struct funcionarios));
    retorno=99;
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        if (retorno != NULL)
        {
            DesmontaUmaLinhaFuncionarios(buffer,funcionario,*l);
            (*l)++;

        }
    }
    if (motivo==0)
    {
        itoa(*l,funcionario[*l].codigofuncionario,10);
    }
    fclose(Arq);
    return funcionario;
}

/* FUNÇÃO PARA CARREGAR O ARQUIVO EXEMPLARES NA MEMORIA*/
struct exemplares *CarregarMemoriaExemplar (struct exemplares *exemplar, FILE *Arq, int *l,int motivo)
{
    int i=0;
    int retorno=99;
    char buffer[1024];
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        i++;
    }
    fclose(Arq);
    Arq = fopen("exemplares.txt","r");
    exemplar = (struct exemplares*) malloc (i*sizeof(struct exemplares));
    retorno=99;
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        if (retorno != NULL)
        {
            DesmontaUmaLinhaExemplares(buffer,exemplar,*l);
            (*l)++;

        }
    }
    if (motivo==0)
    {
        itoa(*l,exemplar[*l].codigoexemplar,10);
    }
    fclose(Arq);
    return exemplar;
}

/* FUNÇÃO PARA CARREGAR O ARQUIVO EMPRESTIMO NA MEMORIA*/
struct emprestimos *CarregarMemoriaEmprestimo (struct emprestimos *emprestimo, FILE * Arq, int *l,int motivo)
{
    int i=0;
    int retorno=99;
    char buffer[1024];
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        i++;
    }
    fclose(Arq);
    Arq = fopen("emprestimo.txt","r");
    emprestimo = (struct emprestimos*) malloc (i*sizeof(struct emprestimos));
    retorno=99;
    while (retorno  != 0)
    {
        retorno = BuscaDados(Arq, buffer);
        if (retorno != NULL)
        {
            DesmontaUmaLinhaEmprestimo(buffer,emprestimo,*l);
            (*l)++;
        }
    }
    if (motivo==0)
    {
        itoa(*l,emprestimo[*l].codigoemprestimo,10);
    }
    fclose(Arq);
    return emprestimo;
}

/*FUNÇÃO PARA GRAVAR O QUE CONSTA NA MEMORIA NO ARQUIVO NIVEL*/
void GravaArquivoNivel (struct niveis *nivel, FILE *Arq, int l)
{
    int c;
    char buffer[1024];
    buffer[0]='\0';
    remove("niveis.txt");
    for (c=0; c<=l; c++)
    {
        Arq = fopen("niveis.txt","a+");
        strcpy(buffer,nivel[c].codigonivel);
        strcat(buffer,"|");
        strcat(buffer,nivel[c].descricao);
        strcat(buffer,"|");
        strcat(buffer,"\n");
        fprintf(Arq,"%s", buffer);
        fclose(Arq);

    }
}

/*FUNÇÃO PARA GRAVAR O QUE CONSTA NA MEMORIA NO ARQUIVO FUNCIONARIO*/
void GravaArquivoFuncionario (struct funcionarios *funcionario,FILE *Arq,int l)
{
    int c;
    char buffer[1024];
    buffer[0]='\0';
    remove("funcionarios.txt");
    for (c=0; c<=l; c++)
    {
        Arq = fopen("funcionarios.txt","a+");
        strcpy(buffer,funcionario[c].codigofuncionario);
        strcat(buffer,"|");
        strcat(buffer,funcionario[c].nome);
        strcat(buffer,"|");
        strcat(buffer,funcionario[c].noab);
        strcat(buffer,"|");
        strcat(buffer,funcionario[c].CEcodigonivel);
        strcat(buffer,"|");
        strcat(buffer,funcionario[c].senha);
        strcat(buffer,"|");
        strcat(buffer,"\n");
        fprintf(Arq,"%s", buffer);
        fclose(Arq);

    }
}

/*FUNÇÃO PARA GRAVAR O QUE CONSTA NA MEMORIA NO ARQUIVO EXEMPLARES*/
void GravaArquivoExemplar (struct exemplares *exemplar,FILE *Arq,int l)
{
    int c;
    char buffer[1024];
    buffer[0]='\0';
    remove("exemplares.txt");
    for (c=0; c<=l; c++)
    {
        Arq = fopen("exemplares.txt","a+");
        strcpy(buffer,exemplar[c].codigoexemplar);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].descricao);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].nedicao);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].autor);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].editora);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].area);
        strcat(buffer,"|");
        strcat(buffer,exemplar[c].disponivel);
        strcat(buffer,"|");
        strcat(buffer,"\n");
        fprintf(Arq,"%s", buffer);
        fclose(Arq);
    }
}

/*FUNÇÃO PARA GRAVAR O QUE CONSTA NA MEMORIA NO ARQUIVO EMPRESTIMO*/
void GravaArquivoEmprestimo (struct emprestimos *empretimo, FILE *Arq, int l)
{
    int c;
    char buffer[1024];
    buffer[0]='\0';
    remove("emprestimo.txt");
    for (c=0; c<=l; c++)
    {
        Arq = fopen("emprestimo.txt","a+");
        strcpy(buffer,empretimo[c].codigoemprestimo);
        strcat(buffer,"|");
        strcat(buffer,empretimo[c].data);
        strcat(buffer,"|");
        strcat(buffer,empretimo[c].CEcodigoexemplar);
        strcat(buffer,"|");
        strcat(buffer,empretimo[c].CEcodigofuncionario);
        strcat(buffer,"|");
        strcat(buffer,empretimo[c].dataprevisao);
        strcat(buffer,"|");
        strcat(buffer,empretimo[c].dataefetiva);
        strcat(buffer,"|");
        strcat(buffer,"\n");
        fprintf(Arq,"%s", buffer);
        fclose(Arq);

    }
}
/*FUNÇÃO PARA EFETUAR A VERIFICAÇÃO SE A SENHA E USUARIO ESTÃO CADASTRADO E COMPARAR COM OS DADOS DE LOGIN*/
int VerificarStructFuncionario (struct funcionarios *funcionario,char *busca,int F,char *CNivel,char *cookie,char senha[10])
{
    int i;
    for (i=0; i<F; i++)
    {
        if(strcmp(funcionario[i].codigofuncionario,busca)==0)
        {

            if (strcmp(funcionario[i].senha,senha)==0)
            {
                strcpy(cookie,funcionario[i].codigofuncionario);
                strcpy(CNivel,funcionario[i].CEcodigonivel);
                return 1;
            }
        }

    }
    return 0;
}

/*FUNÇÃO PARA OCULAR NA HORA DA DIGITAÇÃO O CONTEUDO DA SENHA POR ASTERISTICOS*/
void senhaoculta (char *senha)
{
    int ch;
    int i = 0;
    do
    {
        ch = getch();
        if (ch == ENTER)
        {
            senha[i]='\0';
            break ;
        }
        if (ch == 8)
        {
            if(i == 0)
                continue;
            --i;
            system("CLS");
            printf("** Senha: ");
            int a;
            for(a = 0; a < i; a++)
                printf("*");
            continue;
        }
        printf("*");
        senha[i] = ch;
        i++;
    }
    while(ch!=ENTER);

}

/*FUNÇÃO PARA CADASTRO DE NIVEIS GERENCIAIS O NIVEL ZERO SEMPRE SERÁ USUARIO MASTER*/
void cadastroniveis (struct niveis *nivel)
{
    system("cls");
    FILE *Arq;
    int l=0,opcao=0;

    Arq = fopen("niveis.txt","r");
    if (Arq == NULL)
    {
        printf("\n AVISO - ARQUIVO NAO EXISTENTE - CRIANDO NOVA BASE DE DADOS\n");
        nivel = (struct niveis*) malloc (1*sizeof(struct niveis));
        strcpy(nivel[0].codigonivel,"0");

    }
    else
    {
        nivel=CarregarMemoriaNivel(nivel, Arq, &l,0);

    }
    do
    {
        printf("\n*******CADASTRO DE NIVEIS GERENCIAIS*******");
        printf("\nCodigo: %s",nivel[l].codigonivel);
        printf("\nDescricao: ");
        setbuf(stdin,NULL);
        scanf("%[^\n]s",nivel[l].descricao);
        do
        {
            printf("\n\n 1 - SALVAR? \n 2 - NAO\n");
            setbuf(stdin,NULL);
            scanf("%d",&opcao);
            setbuf(stdin,NULL);
            if (opcao==1)
            {
                GravaArquivoNivel(nivel,Arq,l);
                printf("\n SALVO COM SUCESSO\n");
            }
            else
            {
                if (opcao!=2)
                {
                    printf("\n\nERRO OPCAO INVALIDA");
                }
            }
        }
        while (opcao<1 || opcao>2);
    }
    while (opcao==2);
    free(nivel);
    if (l!=0)
    {
        VoltarMenu(nivel);
    }
}

/*FUNÇÃO PARA CADASTRO DE FUNCIONARIOS*/
void cadastrofuncionarios (struct funcionarios *funcionario,struct niveis *nivel)
{
    system("cls");
    FILE *Arq;
    FILE *ArqNivel;
    int l=0,n=0,i=0;
    int opcao=1;
    char senha[10];
    Arq = fopen("funcionarios.txt","r");
    ArqNivel = fopen("niveis.txt","r");
    if (Arq == NULL)
    {
        printf("\n AVISO - ARQUIVO NAO EXISTENTE - CRIANDO NOVA BASE DE DADOS\n");
        funcionario = (struct funcionarios*) malloc (1*sizeof(struct funcionarios));
        strcpy(funcionario[0].codigofuncionario,"0");

    }
    else
    {

        funcionario=CarregarMemoriaFuncionario(funcionario,Arq,&l,0);

    }
    nivel=CarregarMemoriaNivel(nivel,ArqNivel,&n,0);
    do
    {
        printf("\n*******CADASTRO DE FUNCIONARIOS*******");
        printf("\nCodigo: %s",funcionario[l].codigofuncionario);
        printf("\nNome Completo: ");
        setbuf(stdin,NULL);
        scanf("%[^\n]s",funcionario[l].nome);
        printf("\nNumero da OAB: ");
        setbuf(stdin,NULL);
        scanf("%[^\n]s",funcionario[l].noab);
        do
        {
            printf("\nCodigo de Nivel de acesso: ");
            scanf("%s",funcionario[l].CEcodigonivel);
            for (i=0; i<n; i++)
            {
                if (strcmp(funcionario[l].CEcodigonivel,nivel[i].codigonivel)==0)
                {
                    printf("%s\n",nivel[i].descricao);
                    opcao=0;
                }

            }
            if (opcao==1)
            {
                printf("\n\n ERRO - NIVEL NAO CADASTRADO ");
                printf("\n\n NIVEIS CADASTRADOS DISPONIVEIS\n");
                LeituraNivel(nivel,n);
                printf("\n");
            }
        }
        while(opcao==1);

        printf("\nSenha: ");
        senhaoculta(senha);
        strcpy(funcionario[l].senha,senha);
        do
        {
            printf("\n\n 1 - SALVAR? \n 2 - NAO\n");
            setbuf(stdin,NULL);
            scanf("%d",&opcao);
            setbuf(stdin,NULL);
            if (opcao==1)
            {
                GravaArquivoFuncionario(funcionario,Arq,l);
                printf("\n SALVO COM SUCESSO\n");
            }
            else
            {
                if (opcao!=2)
                {
                    printf("\n\nERRO OPCAO INVALIDA");
                }
            }
        }
        while (opcao<1 || opcao>2);
    }
    while (opcao==2);

    free(funcionario);
    if (l!=0)
    {
        VoltarMenu(funcionario);
    }

}
/*FUNÇÃO PARA CONVERTER A DATA PADRÃO DOS EUA, PARA O PADRÃO BR*/
void ConverterData(int motivo, char *dataBR)
{
    char dataEUA[10];
    char *aux;
    char *pedaco;
    dataBR[0]='\0';


    if (motivo==0)
    {
        _strdate(dataEUA);
        aux = strtok(dataEUA, "/");
        pedaco = strtok(NULL, "/");
        strcat(dataBR,pedaco);
        strcat(dataBR,"/");
        strcat(dataBR,aux);
        strcat(dataBR,"/");
        pedaco = strtok(NULL, "/");
        strcat(dataBR,pedaco);

    }
}

/*FUNÇÃO PARA CADASTRO DE NOVOS EMPRESTIMOS*/
void cadastroemprestimo (struct emprestimos *emprestimo, struct funcionarios *funcionario, struct exemplares *exemplar)
{
    system("cls");
    FILE *Arq;
    FILE *ArqFun;
    FILE *ArqExe;
    int l=0,i=0,f=0,e=0;
    int opcao=1;
    char data[10];
    Arq = fopen("emprestimo.txt","r");
    if (Arq == NULL)
    {
        printf("\n AVISO - ARQUIVO NAO EXISTENTE - CRIANDO NOVA BASE DE DADOS\n");
        emprestimo = (struct emprestimos*) malloc (1*sizeof(struct emprestimos));
        strcpy(emprestimo[0].codigoemprestimo,"0");
    }
    else
    {
        emprestimo=CarregarMemoriaEmprestimo(emprestimo,Arq,&l,0);

    }
    ArqFun = fopen("funcionarios.txt","r");
    if (ArqFun==NULL)
    {
        printf("\n\nERRO ARQUIVO FUNCIONARIO NAO EXISTE");
    }
    else
    {
        ArqExe = fopen("exemplares.txt","r");
        if (ArqExe == NULL)
        {
            printf("\n\n ERRO ARQUIVO EXEMPLARES NAO EXISTE");
        }
        else
        {
            funcionario=CarregarMemoriaFuncionario(funcionario,ArqFun,&f,0);
            exemplar=CarregarMemoriaExemplar(exemplar,ArqExe,&e,0);
            printf("\n*******CADASTRO DE EMPRESTIMO*******");
            printf("\nCodigo: %s",emprestimo[l].codigoemprestimo);
            printf("\nData: ");
            ConverterData(0,data);
            strcpy(emprestimo[l].data,data);
            printf("%s",emprestimo[l].data);
            do
            {
                printf("\nCodigo Exemplar: ");
                scanf("%s",emprestimo[l].CEcodigoexemplar);
                for (i=0; i<e; i++)
                {
                    if (strcmp(emprestimo[l].CEcodigoexemplar,exemplar[i].codigoexemplar)==0)
                    {
                        if (strcmp(exemplar[i].disponivel,"sim")==0)
                        {
                            printf(" - %s",exemplar[i].descricao);
                            opcao=0;
                        }
                        else
                        {
                            printf("\n\n ERRO LIVRO NAO DISPONIVEL PARA EMPRESTIMO");

                        }
                    }

                }
                if (opcao==1)
                {
                    printf("\n\n ERRO - EXEMPLAR NAO CADASTRADO ");
                }
            }
            while(opcao==1);
            opcao=1;
            do
            {
                printf("\nCodigo Matricula Funcionario: ");
                scanf("%s",emprestimo[l].CEcodigofuncionario);
                for (i=0; i<f; i++)
                {
                    if (strcmp(emprestimo[l].CEcodigofuncionario,funcionario[i].codigofuncionario)==0)
                    {
                        printf(" - %s",funcionario[i].nome);
                        opcao=0;
                    }

                }
                if (opcao==1)
                {
                    printf("\n\n ERRO - FUNCIONARIO NAO CADASTRADO ");
                }
            }
            while(opcao==1);
            printf("\nData Previsao de Devolucao (DD/MM/AA): ");
            scanf("%s",emprestimo[l].dataprevisao);

            strcpy(emprestimo[l].dataefetiva,"*");

            do
            {
                printf("\n\n 1 - SALVAR? \n 2 - NAO\n");
                setbuf(stdin,NULL);
                scanf("%d",&opcao);
                setbuf(stdin,NULL);
                if (opcao==1)
                {
                    GravaArquivoEmprestimo(emprestimo,Arq,l);
                    for (i=0; i<e; i++)
                    {
                        if (strcmp(emprestimo[l].CEcodigoexemplar,exemplar[i].codigoexemplar)==0)
                        {

                            strcpy(exemplar[i].disponivel,"nao");
                        }
                    }
                    GravaArquivoExemplar(exemplar,ArqExe,e-1);
                    printf("\n SALVO COM SUCESSO\n");
                }
                else
                {
                    printf("\n\nERRO OPCAO INVALIDA");
                }
            }
            while (opcao<1 || opcao>2);
        }
    }
    free(emprestimo);
    VoltarMenu(emprestimo);
}

/*FUNÇÃO PARA CADASTRO DE NOVOS EXEMPLARES*/
void cadastroexemplares (struct exemplares *exemplar)
{
    system("cls");
    FILE *Arq;
    int l=0;
    int opcao=0;
    Arq = fopen("exemplares.txt","r");
    if (Arq == NULL)
    {
        printf("\n AVISO - ARQUIVO NAO EXISTENTE - CRIANDO NOVA BASE DE DADOS\n");
        exemplar = (struct exemplares*) malloc (1*sizeof(struct exemplares));
        strcpy(exemplar[0].codigoexemplar,"0");

    }
    else
    {
        exemplar=CarregarMemoriaExemplar(exemplar,Arq,&l,0);

    }
    printf("\n*******CADASTRO DE EXEMPLARES*******");
    printf("\nCodigo: %s",exemplar[l].codigoexemplar);
    printf("\nDescricao: ");
    setbuf(stdin,NULL);
    scanf("%[^\n]s",exemplar[l].descricao);
    printf("\nNumero de Edicao: ");
    scanf("%s",exemplar[l].nedicao);
    printf("\nNome do Autor: ");
    setbuf(stdin,NULL);
    scanf("%[^\n]s",exemplar[l].autor);
    printf("\nNome da Editora: ");
    setbuf(stdin,NULL);
    scanf("%[^\n]s",exemplar[l].editora);
    printf("\nArea: ");
    setbuf(stdin,NULL);
    scanf("%[^\n]s",exemplar[l].area);
    strcpy(exemplar[l].disponivel,"sim");
    do
    {
        printf("\n\n 1 - SALVAR? \n 2 - NAO\n");
        setbuf(stdin,NULL);
        scanf("%d",&opcao);
        setbuf(stdin,NULL);
        if (opcao==1)
        {
            GravaArquivoExemplar(exemplar,Arq,l);
            printf("\n SALVO COM SUCESSO\n");
        }
        else
        {
            printf("\n\nERRO OPCAO INVALIDA");
        }
    }
    while (opcao<1 || opcao>2);
    free(exemplar);
    VoltarMenu(exemplar);
}

int BuscaDados(FILE* Arq, char* linha)
{
    char buffer[1024];
    linha[0] = '\0';
    int resultado = 0;

    resultado = fgets(linha, sizeof(buffer), Arq);
    return resultado;

}

/*FUNÇÃO PARA DESMONTAR A LINHA DE UM ARQUIVO PARA A ESTRUTURA NIVEIS*/
void DesmontaUmaLinhaNiveis(char *buffer, struct niveis *nivel,int l)
{
    char *pedaco;
    pedaco = strtok(buffer, "|");
    strcpy(nivel[l].codigonivel, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(nivel[l].descricao, pedaco);
}

/*FUNÇÃO PARA DESMONTAR A LINHA DE UM ARQUIVO PARA A ESTRUTURA FUNCIONARIOS*/
void DesmontaUmaLinhaFuncionarios(char *buffer, struct funcionarios *funcionario,int l)
{
    char *pedaco;
    pedaco = strtok(buffer, "|");
    strcpy(funcionario[l].codigofuncionario, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(funcionario[l].nome, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(funcionario[l].noab, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(funcionario[l].CEcodigonivel, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(funcionario[l].senha, pedaco);
}

/*FUNÇÃO PARA DESMONTAR A LINHA DE UM ARQUIVO PARA A ESTRUTURA EXEMPLARES*/
void DesmontaUmaLinhaExemplares(char *buffer, struct exemplares *exemplar,int l)
{
    char *pedaco;
    pedaco = strtok(buffer, "|");
    strcpy(exemplar[l].codigoexemplar, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].descricao, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].nedicao, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].autor, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].editora, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].area, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(exemplar[l].disponivel, pedaco);
}

/*FUNÇÃO PARA DESMONTAR A LINHA DE UM ARQUIVO PARA A ESTRUTURA EMPRESTIMOS*/
void DesmontaUmaLinhaEmprestimo(char *buffer, struct emprestimos *emprestimo,int l)
{
    char *pedaco;
    pedaco = strtok(buffer, "|");
    strcpy(emprestimo[l].codigoemprestimo, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(emprestimo[l].data, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(emprestimo[l].CEcodigoexemplar, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(emprestimo[l].CEcodigofuncionario, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(emprestimo[l].dataprevisao, pedaco);
    pedaco = strtok(NULL, "|");
    strcpy(emprestimo[l].dataefetiva, pedaco);
}

/*FUNÇÃO PARA IMPRESSÃO DO RELATÓRIO DE FUNCIONARIOS CADASTRADOS*/
void LeituraFuncionario(struct funcionarios *funcionario,int l)
{
    int i;
    for (i=0; i<l; i++)
    {
        printf("\nCod: %s\n",funcionario[i].codigofuncionario);
        printf("Nome: %s\n",funcionario[i].nome);
        printf("Numedo da OAB: %s\n",funcionario[i].noab);
        printf("Nivel de Acesso: %s\n",funcionario[i].CEcodigonivel);
        printf("Senha: %s\n\n",funcionario[i].senha);
        printf("===============================================================\n\n");
    }
}

/*FUNÇÃO PARA IMPRESSÃO DO RELATÓRIO DE NIVEIS CADASTRADOS*/
void LeituraNivel(struct niveis *nivel,int l)
{
    int i;
    for (i=0; i<l; i++)
    {
        printf("\nCod: %s",nivel[i].codigonivel);
        printf("  //  Descricao: %s",nivel[i].descricao);
    }
}

/*FUNÇÃO PARA IMPRESSÃO DO RELATÓRIO DE EXEMPLARES CADASTRADOS*/
void LeituraExemplar(struct exemplares *exemplar,int l)
{
    int i;
    for (i=0; i<l; i++)
    {
        printf("\nCod: %s\n",exemplar[i].codigoexemplar);
        printf("Nome: %s\n",exemplar[i].descricao);
        printf("Edicao: %s\n",exemplar[i].nedicao);
        printf("Autor: %s\n",exemplar[i].autor);
        printf("Editora: %s\n",exemplar[i].editora);
        printf("Area: %s\n",exemplar[i].area);
        printf("Disponivel: %s\n\n",exemplar[i].disponivel);
        printf("===============================================================\n\n");
    }
}

/*FUNÇÃO PARA IMPRESSÃO DO RELATÓRIO DE EMPRESTIMOS CADASTRADOS*/
void LeituraEmprestimo(struct emprestimos *emprestimo,int l)
{
    int i;
    for (i=0; i<l; i++)
    {
        printf("\nCod: %s",emprestimo[i].codigoemprestimo);
        printf("  //  data do emprestimo: %s",emprestimo[i].data);
        printf("  //  previsao de entrega: %s",emprestimo[i].dataprevisao);
        /*printf("  //  data da entrega: %s",emprestimo[i].dataefetiva);*/
    }
}

/*FUNÇÃO PARA DEVOLUÇÃO DE LIVROS EMPRESTADOS*/
void devolucao (struct emprestimos *emprestimo, struct exemplares * exemplar)
{
    int l=0,e=0,i=0,j=0, opcao=0;
    char codigo[10],data[10];
    FILE *ArqEmp;
    FILE *ArqExe;
    ArqExe=fopen("exemplares.txt","r");
    if (ArqExe==NULL)
    {
        printf("\n\n ERRO - NENHUM EXEMPLAR CADASTRADO");
    }
    else
    {
        ArqEmp=fopen("emprestimo.txt","r");
        if (ArqEmp==NULL)
        {
            printf("\n\n ERRO - NENHUM EMPRESTIMO CADASTRADO");
        }
        else
        {
            emprestimo=CarregarMemoriaEmprestimo(emprestimo,ArqEmp,&l,0);
            exemplar=CarregarMemoriaExemplar(exemplar,ArqExe,&e,0);
            printf("\n ******* DEVOLUCAO DE EMPRESTIMO *******");
            do
            {
                printf("\nCodigo do emprestimo: ");
                scanf("%s",codigo);
                for (i=0; i<l; i++)
                {
                    if (strcmp(codigo,emprestimo[i].codigoemprestimo)==0)
                    {
                        for (j=0; j<e; j++)
                        {
                            if (strcmp(emprestimo[i].CEcodigoexemplar,exemplar[j].codigoexemplar)==0)
                            {
                                printf("%s",exemplar[j].descricao);
                            }
                        }
                        opcao=1;
                    }
                }
                if (opcao==0)
                {
                    printf("\nERRO - CODIGO DE EMPRESTIMO NAO EXISTE");
                }

            }
            while(opcao==0);
            opcao=0;
            printf("\nData de Devolucao: ");
            ConverterData(0,data);
            printf("%s",data);
            do
            {
                printf("\n 1 - Salvar");
                printf("\n 2 - Cancelar\n");
                scanf("%d",&opcao);
                if (opcao<1 || opcao>2)
                {
                    printf("\n\nERRO - OPCAO INVALIDA");
                }
            }
            while (opcao<1 || opcao>2 );
            if (opcao==1)
            {
                for (i=0; i<l; i++)
                {
                    if (strcmp(codigo,emprestimo[i].codigoemprestimo)==0)
                    {
                        for (j=0; j<e; j++)
                        {
                            if (strcmp(emprestimo[i].CEcodigoexemplar,exemplar[j].codigoexemplar)==0)
                            {
                                strcpy(exemplar[j].disponivel,"sim");
                                GravaArquivoExemplar(exemplar,ArqExe,e-1);
                                strcpy(emprestimo[i].dataefetiva,data);
                                GravaArquivoEmprestimo(emprestimo,ArqEmp,l-1);
                            }
                        }
                    }
                }
            }
        }
    }
    free(emprestimo);
    free(exemplar);
}

/*FUNÇÃO PARA RETORNAR AO MENU INICIAL*/
void VoltarMenu(struct funcionarios *funcionario, struct niveis *nivel, struct exemplares *exemplar, struct emprestimos *emprestimo)
{
    int op;
    printf("\n\nVOLTAR AO MANU PRINCIPAL???\n");
    printf("1 SIM\n");
    printf("2 SAIR\n");
    scanf("%d",&op);
    switch(op)
    {
    case 1:
        menu(funcionario,nivel,exemplar,emprestimo);

        break;
    case 2:
        break;
    }
}

/*FUNÇÃO PARA VERIFICAÇÃO SE O ARQUIVO JÁ EXISTE*/
int arqexiste (char* arquivo, char* modo)
{
    FILE* Arq;
    Arq = fopen(arquivo, modo);
    if (Arq == NULL)
    {
        return 1;
        fclose(Arq);
    }
    fclose(Arq);
    return 0;
}

/*FUNÇÃO PARA TELA DE LOGIN*/
void login (struct funcionarios *funcionario, struct niveis *nivel, struct exemplares *exemplar, struct emprestimos *emprestimo)
{
    char matricula[10];
    char senha[10];
    char Cnivel[10];
    char CMatricula[10];
    int ok=0;
    FILE *ArqFun;
    FILE *ArqNiv;
    int F=0,N=0;

    ArqFun = fopen("funcionarios.txt","r");
    ArqNiv = fopen("niveis.txt","r");
    funcionario=CarregarMemoriaFuncionario(funcionario,ArqFun,&F,1);
    nivel=CarregarMemoriaNivel(nivel,ArqNiv,&N,1);
    do
    {
        senha[0]='\0';
        printf("\n************LOGIN***********");
        printf("\n** Matricula: ");
        scanf("%s", matricula);
        printf("** Senha: ");
        senhaoculta(senha);
        ok=VerificarStructFuncionario(funcionario,matricula,F,Cnivel,CMatricula,senha);
        if (ok==0)
        {
            system("cls");
            printf("\n\n*************************************");
            printf("\n** ERRO - LOGIN OU SENHA INCORRETO **");
            printf("\n*************************************\n\n");
        }
        else
        {
            if (strcmp(Cnivel,"0")==0)
            {
                menu(funcionario,nivel,exemplar,emprestimo);
            }
            else
            {

                MenuConsulta(exemplar,emprestimo,CMatricula);
            }
        }
    }
    while(ok==0);
    free(funcionario);
    free(nivel);
}
/*FUNÇÃO PARA O MENU DE CONSULTAS DE USUARIOS NAO MASTER*/
void MenuConsulta ( struct exemplares *exemplar, struct emprestimos *emprestimo, char *cookie)
{
    int op,l=0,i=0,j=0,e=0;
    FILE *Arq;
    Arq = fopen("exemplares.txt","r");
    if (Arq != NULL)
    {
        exemplar=CarregarMemoriaExemplar(exemplar,Arq,&l,1);
        fclose(Arq);
    }

    Arq = fopen("emprestimo.txt","r");
    if (Arq!=NULL)
    {
        emprestimo=CarregarMemoriaEmprestimo(emprestimo,Arq,&e,1);
        fclose(Arq);
    }

    system("cls");
    printf("\n\nSEJA BEM VINDO!!!\n\n");
    do
    {
        do
        {

            printf("\n\nQUAL RELATORIO VOCE DESEJA IMPRIMIR?\n\n");
            printf("1 EXEMPLARES DISPONIVEIS NA BIBLIOTECA\n");
            printf("2 EMPRESTIMOS EM ABERTO\n");
            printf("3 SAIR\n");
            scanf("%d", &op);
            switch(op)
            {
            case 1:
                system("cls");
                printf("*****EXEMPLARES DISPONIVEIS NA BIBLIOTECA*****\n\n");
                for (i=0; i<l; i++)
                {
                    if (strcmp(exemplar[i].disponivel,"sim")==0)
                    {

                        printf("\nCod: %s\n",exemplar[i].codigoexemplar);
                        printf("Nome: %s\n",exemplar[i].descricao);
                        printf("Numedo da Edicao: %s\n",exemplar[i].nedicao);
                        printf("Autor: %s\n",exemplar[i].autor);
                        printf("Editora: %s\n",exemplar[i].editora);
                        printf("Area: %s\n",exemplar[i].area);
                        printf("Disponivel: %s\n\n",exemplar[i].disponivel);
                        printf("===================================================\n\n");
                    }
                }
                break;

            case 2:
                system("cls");
                printf("*****EMPRESTIMOS EM ABERTO*****\n\n");
                for (i=0; i<e; i++)
                {


                    if (strcmp(emprestimo[i].CEcodigofuncionario,cookie)==0)
                    {

                        if (strcmp(emprestimo[i].dataefetiva,"*")==0)
                        {

                            printf("\n\nCod: %s\n",emprestimo[i].codigoemprestimo);
                            for (j=0; j<l; j++)
                            {
                                if (strcmp(emprestimo[i].CEcodigoexemplar,exemplar[j].codigoexemplar)==0)
                                {

                                    printf("Nome Do Livro: %s\n",exemplar[i].descricao);
                                }
                            }
                            printf("Data do Emprestimo: %s\n",emprestimo[i].data);
                            printf("Previsao de Entrega: %s\n\n",emprestimo[i].dataprevisao);
                            printf("===================================================\n\n");
                        }
                    }
                }
                break;
            case 3:

                break;
            default :
                printf("\nERRO - OPCAO INVALIDA");
            }
        }
        while(op<1 || op>3);
    }
    while (op!=3);
    if( l!=0)
    {
        free(exemplar);
    }
    if (e!=0)
    {
        free(emprestimo);
    }

}



/*FUNÇÃO PARA O MENU DE CONSULTAS PARA USUARIOS MASTER*/
void menu (struct funcionarios *funcionario, struct niveis *nivel, struct exemplares *exemplar, struct emprestimos *emprestimo)
{
    int op,l=0;
    FILE *Arq;
    system("cls");
    do
    {
        printf("\n\nSEJA BEM VINDO!!!\n\n");
        printf("1 Cadastrar novo Usuario\n");
        printf("2 Cadastrar um novo Exemplar\n");
        printf("3 Cadastrar novo Nivel\n");
        printf("4 Emprestimo\n");
        printf("5 Relatorios\n");
        printf("6 Devolucao\n");
        printf("7 Sair\n");
        scanf("%d", &op);
        switch(op)
        {
        case 1:
            cadastrofuncionarios(funcionario,nivel);

            break;
        case 2:
            cadastroexemplares(exemplar);
            break;
        case 3:
            cadastroniveis(nivel);
            break;
        case 4:
            cadastroemprestimo(emprestimo,funcionario,exemplar);
            break;
        case 5:
            system("cls");
            printf("\n\nQUAL RELATORIO VOCE DESEJA IMPRIMIR?\n\n");
            printf("1 FUNCIONARIOS CADASTRADOS\n");
            printf("2 NIVEIS\n");
            printf("3 EXEMPLARES DA BIBLIOTECA\n");
            printf("4 EMPRESTIMOS\n");
            scanf("%d", &op);
            switch(op)
            {
            case 1:
                Arq = fopen("funcionarios.txt","r");
                funcionario=CarregarMemoriaFuncionario(funcionario,Arq,&l,1);
                fclose(Arq);
                LeituraFuncionario(funcionario,l);
                free(funcionario);
                VoltarMenu(funcionario,nivel,exemplar,emprestimo);
                break;
            case 2:
                Arq = fopen("niveis.txt","r");
                nivel=CarregarMemoriaNivel(nivel,Arq,&l,1);
                fclose(Arq);
                LeituraNivel(nivel,l);
                free(nivel);
                VoltarMenu(funcionario,nivel,exemplar,emprestimo);
                break;
            case 3:
                Arq = fopen("exemplares.txt","r");
                exemplar=CarregarMemoriaExemplar(exemplar,Arq,&l,1);
                fclose(Arq);
                LeituraExemplar(exemplar,l);
                free(exemplar);
                VoltarMenu(funcionario,nivel,exemplar,emprestimo);
                break;
            case 4:
                Arq = fopen("emprestimo.txt","r");
                emprestimo=CarregarMemoriaEmprestimo(emprestimo,Arq,&l,1);
                fclose(Arq);
                LeituraEmprestimo(emprestimo,l);
                free(emprestimo);
                VoltarMenu(funcionario,nivel,exemplar,emprestimo);
                break;
            }
            break;
        case 6:
            devolucao(emprestimo,exemplar);
            VoltarMenu(funcionario,nivel,exemplar,emprestimo);
            break;
        case 7:

            break;
        default:
            printf("\nERRO - OPCAO INVALIDA\n");
        }
    }
    while (op<1 || op>7);
}

int main()
{
    struct niveis *nivel;
    struct funcionarios *funcionario;
    struct emprestimos *emprestimo;
    struct exemplares *exemplar;
    if (arqexiste("funcionarios.txt","r")==1)
    {
        if (arqexiste("niveis.txt","r")==1)
        {
            cadastroniveis(nivel);
            system("cls");

        }
        cadastrofuncionarios(funcionario,nivel);
        system("cls");

    }
    login(funcionario,nivel,exemplar,emprestimo);
    return 0;
}
