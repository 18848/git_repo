#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\readFile.h"

//Iniciar lista vazia
ReadPath *newList(){
    ReadPath *new = (ReadPath*) malloc(sizeof(ReadPath));
    new->next = new->previous = new;
    return new;
}

//Insercao a cabeca
ReadPath *insert (ReadPath *lst, ReadPath *value){
    ReadPath *new = (ReadPath*) malloc(sizeof(ReadPath));

// Values
    new = value;
// Connections
    new->next = lst->next;
    new->previous = lst;
    
    new->next->previous = new;
    new->previous->next = new;
    
    return lst ;
}

//Leitura de linha do ficheiro
ReadPath *readLine(FILE* slate) {
    ReadPath* aux = newList();

    fscanf(slate, readMethod, aux->original,
                                aux->root,
                                aux->morphology,
                                &aux->assurance);

    return aux;
}

//Leitura do ficheiro
ReadPath *readFile() {
    ReadPath* aux = newList();
    FILE* slate = NULL;

    slate = fopen(readPath, "r");
    rewind(slate);
    while( 
    fscanf(slate, readMethod, aux->original,
                                aux->root,
                                aux->morphology,
                                &aux->assurance) ) {
        showList(aux);
    }
    printf("1");
    fclose(slate);
    return aux;
}


//Apresentacao da lista
void showList (ReadPath *lst){
    ReadPath *aux = lst;
    printf(readMethod, aux->original, aux->root, aux->morphology, aux->assurance);
}