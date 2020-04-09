#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/list.h"
#include "headers/frTabGra.h"

/*new list*/
ListTabGra *newListTabGra(){
    ListTabGra *tmp = MALLOC(ListTabGra);
    tmp = NULL;
    return tmp;
}

/*order insert*/
ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data){
    ListTabGra *tmp = MALLOC(ListTabGra);

    tmp->dados = data;
    tmp->next = lst;

    return tmp;
}

/*see if it exists*/
ListTabGra *existsTabGra (ListTabGra *lst, TabGra data){
	ListTabGra *tmp = lst;
	int flag=0;

	for ( ; tmp; tmp=tmp->next)
	{
		if (strcmp(tmp->dados.morphology, data.morphology) == 0){
			(tmp->dados.frequency)++;
			(tmp->dados.assurance) = (tmp->dados.assurance) + (data.assurance);
			(tmp->dados.variance) = (tmp->dados.variance) + (data.variance);
			flag=1;
			break;
		}
	}

	if(flag == 0){
		data.frequency = 1;
		lst = insertListTabGra(lst, data);
	}

	//lst = orderTabGra(lst, data);

	return lst;
}

ListTabGra *orderTabGra (ListTabGra *lst, TabGra data){

	if(!lst || lst->dados.frequency){
		ListTabGra *tmp = MALLOC(ListTabGra);
		tmp->dados=data;
		tmp->next = lst;
		lst = tmp;
	}
	else{
		lst->next = orderTabGra(lst->next, data);
	}

	return lst;
}

void showListTabGra (ListTabGra *lst, int total){
	int countAbs=0;
	double countRel=0;

	for ( ; lst; lst=lst->next){
		countAbs = countAbs + lst->dados.frequency;
		countRel = countRel + (float)(lst->dados.frequency)/total;
		printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency, (float)(lst->dados.frequency)/total, countAbs, (float)countRel);
	}
}

void calculateMesuresTabGra(ListTabGra *lst, int total){
	for ( ; lst; lst=lst->next){
		double dp = (lst->dados.variance/ (double)total) - pow((lst->dados.assurance)/total, 2);
		printf(writeMethodTabGraCalc, lst->dados.morphology, 
		(lst->dados.assurance)/lst->dados.frequency, sqrt(dp));
	}
}
