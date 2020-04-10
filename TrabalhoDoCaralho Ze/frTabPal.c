#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/list.h"
#include "headers/frTabPal.h"

/*new list*/
ListTabPal *newListTabPal(){
    ListTabPal *tmp = MALLOC(ListTabPal);
    tmp = NULL;
    return tmp;
}

/*order insert*/
ListTabPal * insertListTabPal (ListTabPal *lst, TabPal data){
    ListTabPal *tmp = MALLOC(ListTabPal);

    tmp->dados = data;
    tmp->next = lst;

    return tmp;
}

/*see if it exists*/
ListTabPal *existsTabPal (ListTabPal *lst, TabPal data){
	ListTabPal *tmp = lst;
	int flag=0;

	for ( ; tmp; tmp=tmp->next)
	{
		if (tmp->dados.size == data.size){
			(tmp->dados.frequency)++;
			flag=1;
			break;
		}
	}

	if(flag == 0){
		data.frequency = 1;
		lst = insertListTabPal(lst, data);
	}

	return lst;
}

int countTabPal (char word[]){
	int i;

    for (i=0; word[i] != '\0'; i++){}

	return i;
}

ListTabPal *orderTabPal (ListTabPal *lst, TabPal data){

	if(!lst || lst->dados.size < data.size){
		ListTabPal *tmp = MALLOC(ListTabPal);
		tmp->dados=data;
		tmp->next = lst;
		lst = tmp;
	}
	else{
		lst->next = orderTabPal(lst->next, data);
	}

	return lst;
}

void showListTabPal (ListTabPal *lst, int total){
	int countAbs=0;
	double countRel=0;

	for ( ; lst; lst=lst->next){
		countAbs = countAbs + lst->dados.frequency;
		countRel = countRel + (float)(lst->dados.frequency)/total;
		printf(writeMethodTabPal, lst->dados.size, lst->dados.frequency, (float)(lst->dados.frequency)/total, countAbs, (float)countRel);
	}
}

void calculateMesuresTabPal(ListTabPal *lst, int total){
	float media=0.0, variance=0.0;
	int moda=0, frModa=0, count=0, mediana;

	count = total/2;

	printf("\n\n\t%d\n\n", count);

	for ( ; lst; lst=lst->next){
		media = media + (float)(lst->dados.frequency*lst->dados.size);
		variance = variance + pow(lst->dados.size, 2) * lst->dados.frequency;

		if(lst->dados.frequency > frModa){
			moda=lst->dados.size;
			frModa=lst->dados.frequency;
		}
		if(count == total/2){
			mediana=lst->dados.size;
			printf("\n\n\t%d\n\n", count);
		}

		count++;
	}

	printf(writeMethodTabPalCalc, /*media, mediana, moda, desvio*/
		media/(float)total,
		mediana,
		moda,
		sqrt(variance/total-pow(media/total, 2))
	);
}
