#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"
#include "headers\ex1.h"
#include "headers\ex2.h"

/* Iniciar lista vazia */
DataListEx2 *newList2(){
    DataListEx2 *new = MALLOC(DataListEx2);
    new->var.absolut=0;
    new->next = NULL;
    return new;
}

/* Insert new list element */
DataListEx2 *insert2(DataListEx1 *lst, DataListEx2 *old){
    DataListEx2 *new = newList2();

    strcpy(new->var.morphology, lst->var.morphology);
    new->var.absolut = 1;
    new->next = old;
    return new ;
}

/* Search for same morphology
DataListEx2* search2 (DataListEx1 *lst, char value[]) {
    DataListEx2 *new = newList2();
    int flag=0;
    
    if(!strcmp(lst->var.morphology, value))
    {
        puts("strcmp");
        system("pause");
        if(new == NULL){
            puts("if null");
            system("pause");
            new = insert2(lst, new);
            return new;
        }
        else{
            puts("else");
            system("pause");
            new->var.absolut++; 
            return new;
        }
    }
    puts("out if");
    system("pause");

    return search2 (lst->next, value);
}
 */


/* Table for morphology and its quantity*/
DataListEx2* table2 (DataListEx1 *lst, DataListEx2 *lst2) {
    DataListEx1 *aux1;
    DataListEx2 *aux2;
    DataListEx2 *new = newList2();
    /* int flag=0; */
    
    for(aux1 = lst ; aux1 ; aux1 = aux1->next)
    {
        for(aux2 = lst2 ; aux2 ; aux2 = aux2->next)
        {
            /* se iguais */
            if(!strcmp(aux1->var.morphology, aux2->var.morphology))
            {
                aux2->var.absolut++;
                continue;
            }
            else
                continue;
            /* se nulo */
            if(!aux2)
            {
                new = insert2(aux1, aux2);
            }
            
        /* se nulo
            if(!new){
                new = insert2(lst, new);
                return new;
            }
            else{
                new->var.absolut++; 
                return new;
            } */
        }
    }

    return lst2;
}


/* Apresentacao da lista */
void showList2 (DataListEx2 *lst){
    if (lst->next){
        showList2(lst->next);
        printf("%s %d", lst->var.morphology, lst->var.absolut);
    }
}