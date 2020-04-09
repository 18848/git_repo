#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
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

void showListTabPal (ListTabPal *lst, int total){
	int countAbs=0;
	double countRel=0;

	for ( ; lst; lst=lst->next){
		countAbs = countAbs + lst->dados.frequency;
		countRel = countRel + (float)(lst->dados.frequency)/total;
		printf(writeMethodTabPal, lst->dados.size, lst->dados.frequency, 
		(float)(lst->dados.frequency)/total, countAbs, (float)countRel);
	}
}

void calculateMesuresTabPal(ListTabPal *lst, int total){

	for ( ; lst; lst=lst->next){
		//printf(writeMethodTabPalCalc, /*media, mediana, moda, desvio*/
			/*lst->dados.morphology,
			lst->dados.assurance/lst->dados.frequency,
			sqrt(lst->dados.variance/lst->dados.frequency-pow(lst->dados.assurance/lst->dados.frequency, 2))*/
		//);
	}
}
