#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/list.h"
#include "headers/readFile.h"
#include "headers/frTabPal.h"
#include "headers/frTabGra.h"
#include "headers/histograma.h"
#include "headers/countPal.h"

int main(){

/*Listas*/
    List *lst = newList();
    List *lstSort = NULL;
    ListTabGra *lstTabGra = newListTabGra();
    ListTabGra *lstTabGraSort = NULL;
    ListTabPal *lstTabPal = newListTabPal();
    ListTabPal *lstTabPalSort = NULL;
    ListCountPal *lstCountPal = newListCountPal();
    ListCountPal *lstCountPalSort = NULL;
    ListHistograma *lstHistograma = NULL;

/*Strucs*/
    Data data;
    TabGra tabGra;
    TabPal tabPal;
    CountPal countPal;

/*Vars*/
    FILE *fp;
    int countList=0;
    char word[100];

/*Program*/
    printf("\tTrabalho 1 AED II\n\t\tAndre Cardoso n18848\n\t\tJose Cosgrove n18826\n\n");

    fp=fopen(filePath, "r");

    while(fscanf(fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){

        if(data.morphology[0] != 'F'){
        /*1*/
            lst = insert(lst, data);
            
        /*2 e 4*/
            strcpy(tabGra.morphology, data.morphology);
            tabGra.assurance = data.assurance;
            tabGra.variance = pow(data.assurance, 2);
            lstTabGra = existsTabGra(lstTabGra, tabGra);

        /*3 e 5*/
            tabPal.size = countTabPal(data.original);
            lstTabPal = existsTabPal(lstTabPal, tabPal);

        /*6*/
            strcpy(countPal.original, data.original);
            lstCountPal = existsCountPal(lstCountPal, countPal);
            countList++;
        }
    }   
    fclose(fp);  

    /*ordenar tabelas*/
    for( ; lst; lst=lst->next){
        lstSort = orderLst(lstSort, lst->dados);
    }
    for( ; lstTabGra; lstTabGra=lstTabGra->next){
        lstTabGraSort = orderTabGra(lstTabGraSort, lstTabGra->dados);
    }
    for( ; lstTabPal; lstTabPal=lstTabPal->next){
        lstTabPalSort = orderTabPal(lstTabPalSort, lstTabPal->dados);
    }
    for( ; lstCountPal; lstCountPal=lstCountPal->next){
        lstCountPalSort = orderCountPal(lstCountPalSort, lstCountPal->dados);
    }

    /*7*/
	lstHistograma = histograma(lstSort, countList);

/*Ex2------------------------------------------------------------------------------------------*/
    
    printf("\n\nTabela de frequencia referente a categoria gramatical usada (ex2)\n\n");
    printf("Cat Gram\tFreq Abs\tFreq Rel\tFreq Abs Ac\tFreq Rel Ac\n");
	showListTabGra(lstTabGraSort, countList);
    printf("Total\t\t%d\t\t    1 \t\t    %d\t      1\n\n\n", countList, countList);
/*---------------------------------------------------------------------------------------------*/

/*Ex3------------------------------------------------------------------------------------------*/
    
    printf("\n\nTabela de frequencia referente ao tamanho das palavras existentes no texto (ex3)\n\n");
    printf("Num Cara\tFreq Abs\tFreq Rel\tFreq Abs Ac\tFreq Rel Ac\n");
	showListTabPal(lstTabPalSort, countList);
    printf("Total\t\t%d\t\t    1 \t\t    %d\t      1\n\n\n", countList, countList);
/*---------------------------------------------------------------------------------------------*/

/*Ex4------------------------------------------------------------------------------------------*/
    
    printf("\n\nMedia aritmetica e desvio padrao do tipo de analise morfologica (ex4)\n\n");
    printf("Cat Gram\tMedia\t\tDesvio Padrao\n");
	calculateMesuresTabGra(lstTabGraSort);
/*---------------------------------------------------------------------------------------------*/

/*Ex5------------------------------------------------------------------------------------------*/
    
    printf("\n\nMedidas de localizacao e dispersao quanto ao tamanho das palavras (ex5)\n\n");
	calculateMesuresTabPal(lstTabPalSort, countList);
/*---------------------------------------------------------------------------------------------*/

/*Ex6------------------------------------------------------------------------------------------*/
    
    printf("\n\nCalcular o quartil a que pertence uma palavra introduzida pelo user (ex6)\n\n");
    printf("\n\n\tEscreva uma palavra: ");
    scanf("%s", word);
    printf("\n\n");
	calculateQuartilCountPal(lstCountPalSort, countList, word);
/*---------------------------------------------------------------------------------------------*/

/*Ex7------------------------------------------------------------------------------------------*/
    
    printf("\n\nNumero de classes e frequencias para construcao de um histograma (ex7)\n\n");
    showListHistograma(lstHistograma);
    printf("Total\t\t%d", countList);
/*---------------------------------------------------------------------------------------------*/
    
    system("pause");
    return 0;
}