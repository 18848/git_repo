#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "headers/list.h"
#include "headers/readFile.h"
#include "headers/frTabGra.h"

/*Listas duplamente ligadas*/
/*new list*/
List *newList(){
    List *tmp = MALLOC(List);
    tmp = NULL;
    return tmp;
}

/*head insert*/
List *insert (List *lst, Data data){
    List *tmp = MALLOC(List);

    tmp->dados = data;
    tmp->next = lst;

    return tmp;
}