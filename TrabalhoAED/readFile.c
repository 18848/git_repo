#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\readFile.h"

//Iniciar lista vazia
DataList *newList(){
    DataList *new = (DataList*) malloc(sizeof(DataList));
    new->next = new->previous = new;
    return new;
}

//Insercao a cabeca
DataList *insert (DataList *lst, DataList *value){
    DataList *new = (DataList*) malloc(sizeof(DataList));

// Values
    new = value;
// Connections
    new->next = lst->next;
    new->previous = lst;
    
    new->next->previous = new;
    new->previous->next = new;
    
    return lst ;
}

//Leitura do ficheiro
DataList *readFile() {
    DataList* aux = newList();
    FILE* slate = NULL;

    slate = fopen(readPath, "r");
    rewind(slate);
    fscanf(slate, readMethod, aux->original,
                                aux->root,
                                aux->morphology,
                                &aux->assurance);
    /* while( 
                                 ) {
        showList(aux);
    } */
    printf("1");
    fclose(slate);
    return aux;
}


//Apresentacao da lista
void showList (DataList *lst){
    DataList *aux = lst;
    printf(readMethod, aux->original, aux->root, aux->morphology, aux->assurance );
} 