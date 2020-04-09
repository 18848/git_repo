#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "headers/list.h"
#include "headers/readFile.h"
#include "headers/frTabGra.h"
#include "headers/frTabPal.h"

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
    
    fp=fopen(filePath, "r");

    while(fscanf(fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){

        if(data.morphology[0] != 'F'){
        /*1*/
            lst = insert(lst, data);
            
        /*2*/
            strcpy(tabGra.morphology, data.morphology);
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
    
    return 0;
}

/*
To do:
- ordenar lista exercicio 2
*/