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
    Data var;
    DataList* aux = newList();
    char word[100];
    char root[100];
    char morph[10];
    int c=0;
    FILE* slate = NULL;

    slate = fopen(readPath, "r");
    rewind(slate);

    while ( c = fscanf(slate, readMethod, word, root, morph, &var.assurance) != 0 && word !=  )
    {
        var.original = strdup(word);
        var.root = strdup(root);
        var.morphology = strdup(morph);
        ++c;
    }
    
    fclose(slate);
    return aux;
}


//Apresentacao da lista
void showList (DataList *lst){
    DataList *aux = lst;
    printf(readMethod, aux->var.original, aux->var.root, aux->var.morphology, aux->var.assurance );
} 