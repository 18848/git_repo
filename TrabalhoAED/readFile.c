#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\readFile.h"

//Iniciar lista vazia
DataList *newList(){
    DataList *new = MALLOC(DataList);
    new->next = NULL;
    return new;
}

/*
//Insercao a cabeca
DataList *insert (DataList *lst){
    DataList *new = MALLOC(DataList);

    // Values
    //new->var = readFile();
    
    printf("\t%s\n", new->var.original);

    // Connections
    new->next = lst;
    
    return new;
}

DataList* readFile(){
    
    FILE* fp;
    Data data;
    DataList* lista = newList();

    fp = fopen(readPath, "r");

    while (fscanf (fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){
        lista->var = data;
        lista = insert(lista);
    }

    fclose(fp);

    return(lista);
}

*/

DataList *insert(DataList *lst, Data value){
    DataList *new = MALLOC(DataList);
    //Data value;

    new->var = value;
    new->next = lst;
    return new ;
}

DataList* readFile(){
    DataList *new = MALLOC(DataList);
    FILE* fp;
    Data data;

    fp = fopen(readPath, "r");

    while (fscanf (fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){
        if(data.morphology[0] != 'F'){
            new = insert(new, data);
        }
        // printf(readMethod, data.original, data.root, data.morphology, data.assurance);
    }
    printf("done");

    fclose(fp);

    return(new);
}



//Apresentacao da lista
void showList (DataList *lst){
    printf(readMethod, lst->var.original, lst->var.root, lst->var.morphology, lst->var.assurance);

    if (lst->next != NULL){
        showList(lst->next);
    }
}