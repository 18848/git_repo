#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\ex1.h"
#include "headers\ex2.h"

//Iniciar lista vazia
DataListEx1 *newList1(){
    DataListEx1 *new = MALLOC(DataListEx1);
    new->next = NULL;
    return new;
}

DataListEx1 *insert1(DataListEx1 *lst, Ex1 value){
    DataListEx1 *new = newList1();

    new->var = value;
    new->next = lst;
    return new ;
}

DataListEx1* readFile1(int *count){
    DataListEx1 *new = newList1();
    FILE* fp;
    Ex1 data;

    fp = fopen(readPath, "r");

    while (fscanf (fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){
        if(data.morphology[0] != 'F'){
            (*count)++;
            new = insert1(new, data);
        }
    }

    fclose(fp);

    return(new);
}

//Apresentacao da lista
void showList1 (DataListEx1 *lst){

    if (lst->next){
        showList1(lst->next);
        printf(readMethod, lst->var.original, lst->var.root, lst->var.morphology, lst->var.assurance);
    }
}