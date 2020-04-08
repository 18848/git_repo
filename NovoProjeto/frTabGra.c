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


ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data){
    ListTabGra *tmp = MALLOC(ListTabGra);

    tmp->dados = data;
    tmp->next = lst;
	
    if(tmp->next)
    {
        tmp->next->previous = tmp;
        tmp->previous = NULL;
    }

	if ( !lst || lst->dados.frequency > data.frequency )
	{
		tmp->next = lst ;
		lst = tmp;
		if (lst->next ) lst->next->previous = lst ;
	}
	else 
	{
		ListTabGra * aux = lst;
		for ( ; aux->next && aux->next->dados.frequency < data.frequency ; aux = aux->next )
		{
			tmp->next = aux->next;
			tmp->previous = aux;
			aux->next = tmp;
		}
		if (tmp->next) tmp->next->previous = tmp;
	}

        printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);

	return lst;
}

/*see if it exists*/
ListTabGra *existsTabGra (ListTabGra *lst, TabGra data){
	int flag=0;

	for ( ; lst; lst = lst->next)
	{
		if (strcmp(lst->dados.morphology, data.morphology) == 0){ 
			flag=1;
			lst->dados.frequency++;
			break;
		}
	}

	if(flag == 0){
		data.frequency = 1;
		lst = insertListTabGra(lst, data);
	}

	return lst;
}

/*Apresentacao da lista*/
void showListTabGra (ListTabGra *lst){

    if (lst->next){
        showListTabGra(lst->next);
        printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency);
    }
}
