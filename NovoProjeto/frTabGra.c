#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "list.h"
#include "frTabGra.h"

/*new list*/
ListTabGra *newListTabGra(){
    ListTabGra *tmp = MALLOC(ListTabGra);
    tmp->next = tmp->previous = NULL;
    return tmp;
}

ListTabGra *search(ListTabGra* lst, TabGra data, int *flag){

	printf("\n\ta");	
	if (!lst || !strcmp(lst->dados.morphology, data.morphology)){
		(*flag)=1;						/* existe */
		(lst->dados.frequency)++;	/* aumenta a freq. absoluta */
		return lst;
	}
	printf("\n\ta");
	return search(lst->next, data, flag);
}

/* see if it exists */
/* if not, adds new */
ListTabGra *existsTabGra (ListTabGra *lst, TabGra data){
	int flag=0;
		
	#pragma region "ze isto é o search mas em iterativo o search nao funciona"
	/* 	ListTabGra *aux;
	 navegar lista  
	for(aux = lst ; aux; aux = aux->next)
	{
		#pragma region "se igual"
		if (!strcmp(aux->dados.morphology, data.morphology)){
			printf("\n\ta");
			flag=1;					 existe 
			aux->dados.frequency++;	 aumenta a freq. absoluta 
			break;					 encerra ciclo 
		}
		#pragma endregion
	}
 	*/
 	#pragma endregion
	
	/* ze isto é o search mas em iterativo o search nao funciona 
	experimentei pq o frequency nao incrementava por algum motivo  */
	printf("\n\ta");
	lst = search(lst, data, &flag);
	printf("\n\ta");

	#pragma region "se não existe igual"
	if(flag == 0){
		printf("\n\tb");
		/* e' novo */
		data.frequency = 1; 				/* ocorreu pela primeira vez */
		lst = insertListTabGra(lst, data);	/* insere novo elemento para o novo tipo */
	}
	#pragma endregion

	show(lst);
	return lst;
}

void show(ListTabGra *lst)
{
	printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);
}

/* ordered insertion */
ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data){
    ListTabGra *tmp = newListTabGra();

    tmp->dados = data;

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
	if ( !lst || lst->dados.frequency >= data.frequency )
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
    if (lst->next){
        showListTabGra(lst->next);
        printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);
    } 
}
