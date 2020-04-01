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
    char word[100];
    char root[100];
    char morph[10];
    int c;
    FILE* slate = NULL;

    slate = fopen(readPath, "r");
    rewind(slate);

    printf("1");
    while ( fscanf(slate, readMethod, word, root, morph, &aux->assurance) )
    {
        aux->original = strdup(word);
        aux->root = strdup(root);
        aux->morphology = strdup(morph);
        ++c;
    }
    
    printf("%d", c);
        
    printf("1");
    fclose(slate);
    return aux;
}


//Apresentacao da lista
void showList (DataList *lst){
    DataList *aux = lst;
    printf(readMethod, aux->original, aux->root, aux->morphology, aux->assurance );
} 