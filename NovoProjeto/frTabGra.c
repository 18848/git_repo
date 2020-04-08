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

/* checks existance */ 
/* ? 1 : 0 */
int existsTabGra (ListTabGra *lst, TabGra data){
	int flag=0;
	ListTabGra *aux;
	
	/* navegar lista */
	for(aux = lst ; aux; aux = aux->next)
	{
		#pragma region "se igual"
		if (!strcmp(aux->dados.morphology, data.morphology)){
			flag=1;					 /* existe */ 
			aux->dados.frequency++;	 /* aumenta a freq. absoluta */ 
			break;					 /* encerra ciclo  */
		}
		#pragma endregion
	}
	
	return flag;
}

void show(ListTabGra *lst)
{
	printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);
}

/* ordered insertion */
ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data){
    ListTabGra *tmp = newListTabGra();

	data.frequency = 1;
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
