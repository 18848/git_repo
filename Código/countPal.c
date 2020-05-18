#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/list.h"
#include "headers/countPal.h"

/*new list*/
ListCountPal *newListCountPal(){
    ListCountPal *tmp = MALLOC(ListCountPal);
    tmp = NULL;
    return tmp;
}

/*order insert*/
ListCountPal * insertListCountPal (ListCountPal *lst, CountPal data){
    ListCountPal *tmp = MALLOC(ListCountPal);

    tmp->dados = data;
    tmp->next = lst;

    return tmp;
}

/*see if it exists*/
ListCountPal *existsCountPal (ListCountPal *lst, CountPal data){
	ListCountPal *tmp = lst;
	int flag=0;

	for ( ; tmp; tmp=tmp->next)
	{
		if (strcmp(tmp->dados.original, data.original) == 0){
			(tmp->dados.frequency)++;
			flag=1;
			break;
		}
	}

	if(flag == 0){
		data.frequency = 1;
		lst = insertListCountPal(lst, data);
	}

	return lst;
}

ListCountPal *orderCountPal (ListCountPal *lst, CountPal data){

	if(!lst || lst->dados.frequency < data.frequency){
		ListCountPal *tmp = MALLOC(ListCountPal);
		tmp->dados=data;
		tmp->next = lst;
		lst = tmp;
	}
	else{
		lst->next = orderCountPal(lst->next, data);
	}

	return lst;
}

void calculateQuartilCountPal (ListCountPal *lst, int total, char word[]){
	int sum=0, flag=0;

	for ( ; lst; lst=lst->next){

		sum = sum + lst->dados.frequency;

		if (strcmp(lst->dados.original, word) == 0){
			flag=1;
			break;
		}
	}

	if(flag==0){
		printf(errorMessage, word);
	}
	else if((float)sum/total <= 0.25){
		printf(writeMethodCountPalCalc, 1);
	}
	else if((float)sum/total <= 0.50){
		printf(writeMethodCountPalCalc, 2);
	}
	else if((float)sum/total <= 0.75){
		printf(writeMethodCountPalCalc, 3);
	}
	else{
		printf(writeMethodCountPalCalc, 4);
	}
}