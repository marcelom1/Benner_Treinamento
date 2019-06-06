//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Diretivas do Pr�-Processador<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
#include <stdio.h>
#include <stdlib.h>
	//>>>>>>>>>>>Compila��o condicional<<<<<<<<<<<<<<<
#ifdef _WIN32 		      // SE O SISTEMA OPERACIONAL FOR WINDOWS
#include <conio.h> 		        // INCLUIR A BIBLOTECA CONIO.H
#include <windows.h>		    // INCLUIR A BIBLOTECA WINDOWS.H
#define getchar(x) getche(x)	// SUBSTITUIR GETCHAR POR GETCHE
#define morto 219		        // SUBSTITUIR MORTO PELO CODIGO DA TABELA ASCII 219
#define system(x) system("cls")	// SUBSTITUIR SYSTEM(X) POR SYSTEM("CLS")
#define viva '.'		        // SUBSTITUIR VIVA PELO PONTO
#else			          //SEN�O
#include <unistd.h>		         // INCLUIR A BIBLOTECA UNISTD.H
#define Sleep(x) usleep((x)*1000)// SUBSTITUIR SLEEP POR USLEEP E MULTIPLICA POR 1000 PQ � EM MIL�SIMOS DE SEGUNDO
#define system(x) system("clear")// SUBSTITUIR SYSTEM(X) POR SYSTEM("CLEAR")
#define morto '|'		         // SUBSTITUIR MORTO PELO CARACTER |
#define viva '#'		         // SUBSTITUIR VIVA PELO CARACTER #
#endif			          //FIMSE
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>TELA INICIAL<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void tela_inicial ()
{
    printf("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
    Sleep(100);
    printf("@@@                     ######    ######    ######    ######                      @@@\n");
    Sleep(100);
    printf("@@@                       ##      ##       ##         ##                          @@@\n");
    Sleep(100);
    printf("@@@                       ##      ######    ####      ##                          @@@\n");
    Sleep(100);
    printf("@@@                       ##      ##           ###    ##                          @@@\n");
    Sleep(100);
    printf("@@@                     ######    ##        ######    ######                      @@@\n");
    Sleep(100);
    printf("@@@                                 CAMPUS GASPAR                                 @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@                           BEM VINDO AO JOGO DA VIDA                           @@@\n");
    Sleep(100);
    printf("@@@  -REGRAS                                                                      @@@\n");
    Sleep(100);
    printf("@@@   SOBREVIVENCIA: Uma celula passa da geracao corrente para a geracao seguinte @@@\n");
    Sleep(100);
    printf("@@@   se ela tiver duas ou tres celulas vizinhas vivas na geracao corrente;       @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@   MORTE: uma celula viva morre ao fim da geracao corrente se ela tem menos de @@@\n");
    Sleep(100);
    printf("@@@   duas (solidao) ou mais de tres celulas vivas (inanicao) na sua vizinhanca;  @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@   NASCIMENTO: uma celula morta (re)nasce na geracao seguinte caso ela tiver   @@@\n");
    Sleep(100);
    printf("@@@   exatamente tres celulas vivas na sua vizinhanca na geracao anterior.        @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@                           DIGITE ENTER PARA CONTINUAR                         @@@\n");
    Sleep(100);
    printf("@@@                                                                               @@@\n");
    Sleep(100);
    printf("@@@ ALUNO: MARCELO MIGLIOLI                                                       @@@\n");
    Sleep(100);
    printf("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
    setbuf(stdin,NULL);
    getchar(); //COMANDO COM OBJETIVO DE PAUSAR A EXCECU��O AT� SER DIGITADO ALGO.
    system(x); //COMANDO COM OBJETIVO DE LIMPAR A TELA.
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FUN��O COM OBJETIVO DE ZERAR O MUNDO VIRTUAL<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void zeramundo (char universo1[50][50])
{
    int i,j;
    for(i=0; i<50; i++) 		// FOR PARA IR DE LINHA EM LINHA
    {
        for(j=0; j<50; j++) 		// FOR PARA IR DE COLULA A COLUNA
        {
            universo1[i][j]=morto; 	//EM CADA POSI��O DE I E DE J � SUBSTITUIDA PELO CODIGO DECIMAL 219 DA TABELA ASCII OU |
        }
    }
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FUN��O PARA A ESCOLHA PADR�O PARA GERA��O INICIAL<<<<<<<<<<<<<<<<<<<<<<<<<<<<
char geracao_padrao ()
{
    int opcao;
    do
    {
        printf("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
        printf("@@@                                                                                             @@@\n");
        printf("@@@ AQUI ESTAO ALGUNS PADROES INTERESSANTES PARA GERACAO INICIAL, COM QUAL VOCE DESEJA COMECAR? @@@\n");
        printf("@@@                                                                                             @@@\n");
        printf("@@@ 1 - PLANADOR                                                                                @@@\n");
        printf("@@@        .                                                                                    @@@\n");
        printf("@@@       .                                                                                     @@@\n");
        printf("@@@       ...                                                                                   @@@\n");
        printf("@@@                                                                                             @@@\n");
        printf("@@@ 2 - EXPLOSAO                                                                                @@@\n");
        printf("@@@      . . .                                                                                  @@@\n");
        printf("@@@      .   .                                                                                  @@@\n");
        printf("@@@      .   .                                                                                  @@@\n");
        printf("@@@      .   .                                                                                  @@@\n");
        printf("@@@      . . .                                                                                  @@@\n");
        printf("@@@                                                                                             @@@\n");
        printf("@@@ 3 - MATUSALEM                                                                               @@@\n");
        printf("@@@        .                                                                                    @@@\n");
        printf("@@@      ...                                                                                    @@@\n");
        printf("@@@       .                                                                                     @@@\n");
        printf("@@@                                                                                             @@@\n");
        printf("@@@ 4 - CRIE O SEU PROPRIO PADRAO                                                               @@@\n");
        printf("@@@ ");
        setbuf(stdin,NULL); // COMANDO PARA LIMPAR O BUFFER COLOCANDO O VALOR DE NULO
        scanf("%d",&opcao); //LER A OP��O DESEJADA
        system(x); //COMANDO COM OBJETIVO DE ZERAR A TELA
        if (opcao<1 || opcao>4) //IF COM A FUN��O DE VALIDAR A OP��O ESCOLHIDA DE 1 A 4
        {
            printf("OPCAO INVALIDA INFORMAR APENAS A NUMERACAO DE 1 A 4\n\n");
        }
    }
    while(opcao<1 || opcao>4); //LA�O DE REPETI��O PARA CASO A OP��O SER INVALIDA ELE VOLTA A SOLICITAR A GERA��O INICIAL
    return (opcao);
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FUN��O PARA VALIDAR SE A RESPOSTA � S OU N<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
char sim_ou_nao (char opcao)
{
    if (opcao!='s' && opcao!='S' && opcao!='n' && opcao!='N') //IF DE VERIFICA��O CASO O USUS�RIO DIGITE ALGO DIFERENTE DE S OU N E EMITE UM ALERTA
    {
        printf("\nATENCAO OPCAO INVALIDA UTILIZE APENAS S OU N\n");
    }
    return (opcao);
}

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>OP��O 4 PARA CRIA��O DO PADR�O INICIAL<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void criando_padrao (char universo1[50][50])
{
    int i,j,pi=0,pj=0; //AS VERIAVEIS PI E PJ S�O APENAS VARIAVEIS DE CONTROLE DA POSI��O
    char maisum;
    printf(" 12345\n"); //INDICATIVO DA COLUNA
    for (i=25; i<30; i++) //SEGUENCIA DE DOIS FOR PARA IMPRIMIR APENAS UMA PEQUENA PARTE DA MATRIZ
    {
        printf("%d",i-24); // -24 SERVE PARA QUE SEJA PRINTADO NA TELA A SEQUENCIA DE 1,2,3,4,5
        for(j=25; j<30; j++)
        {
            printf("%c",universo1[i][j]);
        }
        printf("\n"); //PRINTF PARA QUEBRA DE LINHA E IMPRESS�O CORRETA DA MATRIZ
    }
    printf("TODAS AS CELULAS ESTAO MORTAS ME INDIQUE QUAL COLUNA E LINHA PARA CELULA VIVA\n");
    do // DO ESPECIFICO PARA CASO O USUARIO QUEIRA ADICIONAR MAIS UMA CELULAR
    {
        do // LA�O ESPECIFICO PARA REPETIR QUANDO O USUS�RIO INDICA A COLUNA OU LINHA INVALIDA
        {
            printf("\nCOLUNA: ");
            scanf("%d",&pj); //LER A COLUNA DA MATRIZ
            printf("LINHA: ");
            scanf("%d",&pi); //LER A LINHA DA MATRIZ
            if (pj<1 || pj>5 || pi<1 || pi>5) //VALIDADOR CASO O USU�RIO DIGITE O CAMPO COLUNA OU LINHA ICORRETOS
            {
                printf("ATENCAO COLUNA OU LINHA INVALIDA, INFORMAR ENTRE 1 A 5");
            }
        }
        while (pj<1 || pj>5 || pi<1 || pi>5);
        for(i=pi+24; i<=pi+24; i++) //SEGUENCIA DE FOR ESPECIFICO PARA A GRAVA��O DA MATRIZ E COMO O USUARIO INDICOU 1,2,3,4 OU 5 A SOMA COM 24 � PARA A GRAVA��O NO LUGAR CORRETO DA MATRIZ
        {
            for(j=pj+24; j<=pj+24; j++)
            {
                if (universo1[pi+24][pj+24]!=viva)// IF COM OBJETIVO DE IDENTIFICAR SE NO LUGAR DA CELULAR SELECIONADA EST� VIVA OU MORTA,
                {
                    universo1[pi+24][pj+24]=viva; //CASO ESTEJA MORTA IR� SUBSTITUIR POR UMA VIVA,
                }
                else
                {
                    universo1[pi+24][pj+24]=morto; //SEN�O POR UMA MORTA
                }
            }
        }
        system(x); //COMANDO COM OBJETIVO DE ZERAR A TELA
        //NOVAMENTE IR� IMPRIMIR PARTE DA MATRIZ COM A CELULA INCLUIDA OU EXCLUIDA
        printf(" 12345\n");
        for (i=25; i<30; i++)
        {
            printf("%d",i-24);
            for(j=25; j<30; j++)
            {
                printf("%c",universo1[i][j]);
            }
            printf("\n");
        }
        do //DO ESPECIFICO PARA VERIFICA��O CASO O USU�RIO VENHA DIGITADO OUTRA O OP��O DIFERENTE DE S OU N
        {
            printf("DESEJA INFORMAR MAIS UM CELULA VIVA OU MATAR A CELULA? S / N\n");
            setbuf(stdin,NULL);
            maisum=getchar();
            printf("\n");
            maisum=sim_ou_nao(maisum); //CHAMAR A FUN��O VERIFICA��O CASO O USUS�RIO DIGITE ALGO DIFERENTE DE S OU N E EMITE UM ALERTA
        }
        while(maisum!='s' && maisum!='S' && maisum!='n' && maisum!='N');
    }
    while(maisum=='s' || maisum=='S');
    system(x); //COMANDO COM OBJETIVO DE ZERAR A TELA
}

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FUN��O PARA JOGAR A 1� GERA��O NA MATRIZ<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void mundo1 (char universo1[50][50], int opcao)
{
    switch (opcao)
    {
    case 1: //CASO A OP��O FOR 1 A FUN��O IR� JOGAR NA MATRIZ AS POISI��ES DO PLANADOR
        universo1[25][25]=viva;
        universo1[26][24]=viva;
        universo1[27][24]=viva;
        universo1[27][25]=viva;
        universo1[27][26]=viva;
        break;

    case 2: //CASO A OP��O FOR 2 A FUN��O IR� JOGAR NA MATRIZ AS POSI��ES DA EXPLOS�O
        universo1[23][23]=viva;
        universo1[24][23]=viva;
        universo1[25][23]=viva;
        universo1[26][23]=viva;
        universo1[27][23]=viva;
        universo1[23][25]=viva;
        universo1[27][25]=viva;
        universo1[23][27]=viva;
        universo1[24][27]=viva;
        universo1[25][27]=viva;
        universo1[26][27]=viva;
        universo1[27][27]=viva;
        break;

    case 3: //CASO A OP��O FOR 3 A FUN��O IR� JOGAR NA MATRIZ AS POSI��ES DO MATUSALEM
        universo1[25][25]=viva;
        universo1[26][23]=viva;
        universo1[26][24]=viva;
        universo1[26][25]=viva;
        universo1[27][24]=viva;
        break;

    case 4: //CASO A OP��O FOR 4 A FUN��O IR� CHAMAR OUTRA FUN��O PARA QUE O USU�RIO CRIE O SEU PROPRIO PADR�O
        criando_padrao(universo1);
    }
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FUN��O PARA IMPRIMIR A MATRIZ NA TELA<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
int imprimir_mundo (char mundo[50][50])
{
    int i,j,vivos=0;
    system(x); //COMANDO COM OBJETIVO DE LIMPAR A TELA
    for(i=0; i<50; i++) //SEGUENCIA DE FOR PARA IMPRIMIR A LINHA E A COLUNA DA MATRIZ
    {
        for(j=0; j<50; j++)
        {
            printf("%c",mundo[i][j]);
            if(mundo[i][j]==viva) // IF PARA CONTAR QUANTAS CELULAS EST�O VIVAS
            {
                vivos++;
            }
        }
        printf("\n");
    }
    printf("Celulas vivas: %d",vivos);// A CADA GERA��O IR� APRESENTAR NA TELA A QUANTIDADE DE CELULAS VIVAS
    return (vivos); // A FUN��O IR� RETORNAR PARA O INT MAIN A QUANTIDADE DE CELULAS VIVAS
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>VERRIFICA��O DA PROXIMA GERA��O<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void ciclo_da_vida(char universo1[50][50], char universo2[50][50])
{
    int i,j,pi0,pi49,pj0,pj49,vivos;
    // ESSA SEGUENCIA DE FOR IR� FAZER UMA PARTE MUITO IMPORTANTE PARA A VERIFICA��O DA PROXIMA GERA��ES NO LIMITES DA MATRIZ
    for(i=0; i<50; i++)
    {
        for(j=0; j<50; j++)
        {
            vivos=0;
            pi0=0;
            pj0=0;
            pi49=0;
            pj49=0;
            if (i==0)//CASO A LINHA SEJA IGUAL A ZERO, PI0 RECEBE 50
            {
                pi0=50;
            }
            else
            {
                if(i==49) //CASO A LINHA SEJA 49 PI49 RECEBE -50
                {
                    pi49=-50;
                }
            }
            if(j==0) //CASO A COLUNA SEJA 0, PJ0 RECEBE 50
            {
                pj0=50;
            }
            else
            {
                if(j==49) //CASO A COLUNA SEJA 49, PJ49 RECEBE -50
                {
                    pj49=-50;
                }
            }
            // NESSA SEGUENCIA DE 8 IF, SER� VERIFICADO CADA VIZINHO DA CELULA SE EST� VIVO OU N�O
            // USEI AS VARIAVEIS PI0,PI49,PJ0,PJ49, QUANDO A CELULA A SER VERIFICAR SE ENCONTRE NOS CANTOS
            // ELE EFETUA A SOMA DE 50 OU -5O PARA VERIFICAR O CANTO OPOSTO
            if(universo1[i+1+pi49][j]==viva)
            {
                vivos++;
            }
            if(universo1[i+1+pi49][j+1+pj49]==viva)
            {
                vivos++;
            }
            if(universo1[i+1+pi49][j-1+pj0]==viva)
            {
                vivos++;
            }
            if(universo1[i][j+1+pj49]==viva)
            {
                vivos++;
            }
            if(universo1[i][j-1+pj0]==viva)
            {
                vivos++;
            }
            if(universo1[i-1+pi0][j]==viva)
            {
                vivos++;
            }
            if(universo1[i-1+pi0][j+1+pj49]==viva)
            {
                vivos++;
            }
            if(universo1[i-1+pi0][j-1+pj0]==viva)
            {
                vivos++;
            }
            // NOS PROXIMOS IF SER� APLICADO AS REGRAS DO JOGO DE SOBREVIVENCIA, MORTE, (RE)NASCIMENTO
            if(universo1[i][j]==viva) //SE A CELULA ESTIVER VIVA
            {
                if (vivos>3 || vivos<2) //SE A VARIAVEL VIVOS FOR MAIOR QUE 3 OU MENOS QUE 2
                {
                    universo2[i][j]=morto; //A CELULA MORRE
                }
                else
                {
                    universo2[i][j]=viva; // SENAO A CELULA CONTINUA VIVA NA PROXIMA GERA��O
                }
            }
            else //SENAO ESTIVER VIVA
            {
                if (vivos==3) //SE A CELULA POSSUIR EXATAMENTE 3 VIZINHOS
                {
                    universo2[i][j]=viva; //ELA IR� RENASCER
                }
            }
        }
    }
}
//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>UNIVERSO 1 RECEBE O UNIVERSO 2<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
void universo1_recebe_universo2 (char universo1[50][50], char universo2[50][50])
{
    int i,j;
    // FUN��O SIMPLES ONDE O SEU UNICO OBJETIVO � CLONAR O UNIVERSO 2 PARA O UNIVERSO 1
    for(i=0; i<50; i++)
    {
        for(j=0; j<50; j++)
        {
            universo1[i][j]=universo2[i][j];
        }
    }
}

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

int main()
{
    char universo1[50][50], universo2[50][50],denovo;
    int opcao,i,geracoes,vivos;
    tela_inicial(); //CHAMAR A FUN��O DA TELA INICIAL
    do//DO COM OBJETIVO DE EXECUTAR A SIMULA��O NOVAMENTE
    {
        vivos=0;
        zeramundo(universo1); //CHAMAR A FUN��O DE ZERA O MUNDO PARA ZERAR O UNIVERSO1
        zeramundo(universo2); //CHAMAR A FUN��O DE ZERA O MUNDO PARA ZERAR O UNIVERSO2
        opcao=geracao_padrao(); //CHAMAR A FUN��O DA GERA��O PADR�O E RECEBER DA FUN��O O CONTEUDO DA V�RIAVEL OP��O
        mundo1(universo1,opcao); //CHAMAR A FUN��O MUNDO1 QUE IR� JOGAR A PRIMEIRA GERA��O ESCOLHIDA PELA USUARIO NA MATRIZ
        do//DO DE VALIDA��O CASO O USUARIO INFORME UMA GERA��O NEGATIVA
        {
            printf("QUANTAS GERACOES GOSTARIA SIMULAR?\n");
            scanf("%d",&geracoes);
            if(geracoes<0) //SE FOR NEGATIVA A GERA��O IR� APRESENTAR NA TELA UM ALERTA
            {
                printf("ATENCAO A QUANTIDADE DE GERACOES NAO PODE SER NEGATIVA\n");
            }
        }
        while(geracoes<0);
        for (i=0; i<geracoes; i++) //FOR PARA FAZER QUANTAS GERA��ES O USU�RIO QUISER OU PARA QUANDO N�O TIVER NENHUMA CELULA VIVA
        {
            vivos=imprimir_mundo(universo1); //CHAMAR A FUN��O IMPRIMIR O MUNDO E IR� RECEBER A QUANTIDADE DE VIVOS NESSA GERA��O
            if(vivos>0)// SE A QUANTIDADE DE VIVOS FOR MAIOR QUE ZERO O CICLO DA VIDA CONTINUA
            {
                ciclo_da_vida(universo1,universo2); // CHAMA A FUN��O CICLO DA VIDA, QUE IR� EXCUTAR TODAS AS REGRAS DO JOGO
                universo1_recebe_universo2(universo1,universo2); // CHAMA A FUN��O UNIVERSO1 RECEBE UNIVERSO 2 PARA FAZER UMA C�PIA IDENTICA
                Sleep(1000);// COMANDO PARA FAZER UM DELAY PROPOSITAL DE 1 SEGUNDO
            }
            else //SE VIVOS N�O FOR MAIOR QUE ZERO
            {
                geracoes=0; //ENT�O GERA��ES RECEBE ZERO PARANDO A EXECU��O DA PROXIMA GERA��O
            }

        }
        do //LA�O DE REPETI��O CASO DENOVO FOR DIFERENTE DE S OU N
        {
            printf("\nGOSTARIA DE EFETUAR UMA NOVA SIMULACAO? S OU N\n");
            setbuf(stdin,NULL);
            denovo=getchar();
            denovo=sim_ou_nao(denovo);//CHAMAR FUN��O DE VERIFICA��O CASO O USUS�RIO DIGITE ALGO DIFERENTE DE S OU N E EMITE UM ALERTA
        }
        while(denovo!='s' && denovo!='S' && denovo!='n' && denovo!='N');
        system(x); //COMANDO COM OBJETIVO DE LIMPAR A TELA
    }
    while(denovo=='s' || denovo=='S'); //CASO DENOVO FOR IGUAL A S O PROGRAMA IR� EXECUTAR NOVAMENTE.
    return 0;
}
