#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/list.h"
#include "headers/readFile.h"
#include "headers/frTabPal.h"
#include "headers/frTabGra.h"

int main(){

/*Listas*/
    List *lst = newList();
    ListTabGra *lstTabGra = newListTabGra();
    ListTabPal *lstTabPal = newListTabPal();

/*Strucs*/
    Data data;
    TabGra tabGra;
    TabPal tabPal;

/*Vars*/
    FILE *fp;
    int countList=0;
    int flag = 0;

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
        /*3*/
            tabPal.size = countTabPal(data.original);
            lstTabPal = existsTabPal(lstTabPal, tabPal);

            countList++;
        }
    }   
    fclose(fp);

/*Ex2------------------------------------------------------------------------------------------*/
    
    printf("\n\nTabela de frequencia referente a categoria gramatical usada (ex2)\n\n");
    printf("Cat Gram\tFreq Abs\tFreq Rel\tFreq Abs Ac\tFreq Rel Ac\n");
    do
    {
        lstTabGra = orderTabGra(lstTabGra, lstTabGra->next->dados, &flag);
        printf("%d", flag);
    }while (flag == 0);
    showListTabGra(lstTabGra, countList);
    printf("Total\t\t%d\t\t    1 \t\t    %d\t      1\n\n\n", countList, countList);
    system("pause");

/*---------------------------------------------------------------------------------------------*/

/*Ex3------------------------------------------------------------------------------------------*/
    
    printf("\n\nTabela de frequencia referente ao tamanho das palavras existentes no texto (ex3)\n\n");
    printf("Num Cara\tFreq Abs\tFreq Rel\tFreq Abs Ac\tFreq Rel Ac\n");
	showListTabPal(lstTabPal, countList);
    printf("Total\t\t%d\t\t    1 \t\t    %d\t      1\n\n\n", countList, countList);
    system("pause");
/*---------------------------------------------------------------------------------------------*/

/*Ex4------------------------------------------------------------------------------------------*/
    
    printf("\n\n (ex4)\n\n");
    printf("Cat Gram\tMedia\t\tDesvio Padrao\n");
	calculateMesuresTabGra(lstTabGra, countList);
    system("pause");
/*---------------------------------------------------------------------------------------------*/

/*Ex5------------------------------------------------------------------------------------------*/
    
    printf("\n\n (ex5)\n\n");
	calculateMesuresTabPal(lstTabPal, countList);
    system("pause");
/*---------------------------------------------------------------------------------------------*/
    
    return 0;
}

/*
To do:
- ordenar lista exercicio 2
---------------------------------
- calcular desvio padrao ex 4   -> penso estar resolvido verifica
---------------------------------
*/