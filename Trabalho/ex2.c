#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\ex1.h"
#include "headers\ex2.h"

//Iniciar lista vazia
DataListEx2 *newList2(){
    DataListEx2 *new = MALLOC(DataListEx2);
    new->var.absolut=0;
    new->next = NULL;
    return new;
}

DataListEx2 *insert2(DataListEx2 *lst, char value[]){
    DataListEx2 *new = newList2();

    strcpy(new->var.morphology, value);
    new->var.absolut = 1;
    new->next = lst;
    return new ;
}

DataListEx2* search2 (DataListEx2 *lst, char value[]) {
    int flag=0;
    
    if (!lst || !strcmp(lst->var.morphology, value)){
        lst = insert2(lst, value);
        return lst;
    }

    return search2 (lst->next, value);
}


//Apresentacao da lista
void showList2 (DataListEx2 *lst){

    if (lst->next){
        showList2(lst->next);
        printf("%s %d", lst->var.morphology, lst->var.absolut);
    }
}