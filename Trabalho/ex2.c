#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\ex1.h"
#include "headers\ex2.h"

//Iniciar lista vazia
DataListEx2 *newList2(){
    DataListEx2 *new = MALLOC(DataListEx2);
    new->next = NULL;
    return new;
}

DataListEx2 *insert2(DataListEx2 *lst, Ex2 value){
    DataListEx2 *new = newList2();

    new->var = value;
    new->next = lst;
    return new ;
}

DataListEx2* readFile2(int *count){
    DataListEx2 *new = newList2();
    Ex2 data;

    if(data.morphology[0] != 'F'){
        (*count)++;
        new = insert2(new, data);
    }

    return(new);
}

//Apresentacao da lista
void showList2 (DataListEx2 *lst){

    /*if (lst->next){
        showList(lst->next);
        printf(readMethod, lst->var.original, lst->var.root, lst->var.morphology, lst->var.assurance);
    }*/
}