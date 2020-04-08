#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "list.h"
#include "frTabGra.h"

/*new list*/
ListTabGra *newListTabGra(){
    ListTabGra *tmp = MALLOC(ListTabGra);
    tmp = NULL;
    return tmp;
}

/* see if it exists */
/* if not, adds new */
ListTabGra *existsTabGra (ListTabGra *lst, TabGra data){
	ListTabGra *aux;
	int flag=0;

	/* navegar lista */
	for (aux = lst ; aux; aux = aux->next)
	{
		#pragma region "se igual"
		if (!strcmp(aux->dados.morphology, data.morphology)){
			flag=1;					/* existe */
			aux->dados.frequency++;	/* aumenta a freq. absoluta */
			break;					/* encerra ciclo */
		}
		#pragma endregion
	}

	#pragma region "se não existe igual"
	if(flag == 0){
		/* e' novo */
		data.frequency = 1; 				/* ocorreu pela primeira vez */
		lst = insertListTabGra(lst, data);	/* insere novo elemento para o novo tipo */
	}
	#pragma endregion

	return lst;
}

/* ordered insertion */
ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data){
    ListTabGra *tmp = MALLOC(ListTabGra);

    tmp->dados = data;
    tmp->next = tmp->previous = NULL;

	puts("\toi");

	#pragma region "escreveste mas nao estava no PP"
	/*  	
    if(tmp->next)
    {
        tmp->next->previous = tmp;
        tmp->previous = NULL;
    }
 	*/
 	#pragma endregion

	#pragma region "lst nula ou frequencia maior"
	if ( !lst || lst->dados.frequency > data.frequency )
	{
		tmp->next = lst ;
		lst = tmp;
		if (lst->next ) lst->next->previous = lst ;
	}
	else 
	{
		ListTabGra * aux = lst;
		for ( ; aux->next && aux->next->dados.frequency < data.frequency ; aux = aux->next ) {}
		
		tmp->next = aux->next;
		tmp->previous = aux;
		aux->next = tmp;
		
		if (tmp->next) tmp->next->previous = tmp;
	}

        printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);

	return lst;
}


/*Apresentacao da lista*/
void showListTabGra (ListTabGra *lst){
    /* if (lst->next){
        showListTabGra(lst->next);
    } */
	ListTabGra *aux;
	for(aux = lst ; aux ; aux = aux->next)
	{
        printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);
	}
}
