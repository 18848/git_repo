#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\readFile.h"
#include "headers\TableThirdCol.h"

//Iniciar lista vazia
DataList *newList(){
    DataList *new = MALLOC(DataList);
    new->next = NULL;
    return new;
}

DataList *insert(DataList *lst, Data value){
    DataList *new = newList();

    new->var = value;
    new->next = lst;
    return new ;
}

DataList* readFile(int *count){
    DataList *new = newList();
    FILE* fp;
    Data data;

    fp = fopen(readPath, "r");

    while (fscanf (fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){
        if(data.morphology[0] != 'F'){
            (*count)++;
            new = insert(new, data);
        }
    }

    fclose(fp);

    return(new);
}

//Apresentacao da lista
void showList (DataList *lst){

    if (lst->next){
        showList(lst->next);
        printf(readMethod, lst->var.original, lst->var.root, lst->var.morphology, lst->var.assurance);
    }
}