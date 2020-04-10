#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "math.h"
#include "headers/histograma.h"
#include "headers/list.h"

/*new list*/
ListHistograma *newListHistograma(){
    ListHistograma *tmp = MALLOC(ListHistograma);
    tmp = NULL;
    return tmp;
}

/*order insert*/
ListHistograma * insertListHistograma (ListHistograma *lst, Histograma data){
    ListHistograma *tmp = MALLOC(ListHistograma);

    tmp->dados = data;
    tmp->next = lst;

    return tmp;
}

void showListHistograma (ListHistograma *lst){
	int countAbs=0;
	double countRel=0;

	for ( ; lst; lst=lst->next){
		/*countAbs = countAbs + lst->dados.frequency;
		countRel = countRel + (float)(lst->dados.frequency)/total;
		printf(writeMethodTabGra, lst->dados.morphology, lst->dados.frequency, (float)(lst->dados.frequency)/total, countAbs, (float)countRel);*/
	}
}

void histograma(List *lst, int count){
	ListHistograma *histLst = newListHistograma();
	List *aux = lst;

	Histograma histograma;

	int k = 1+log(count)/log(2), i, j;
	double h;
	double maior = lst->dados.assurance, menor = lst->dados.assurance;

	for ( ; aux; aux=aux->next){
		if (aux->dados.assurance < menor){
			menor = aux->dados.assurance;
		}
		if (aux->dados.assurance > maior){
			maior = aux->dados.assurance;
		}
	}

	h = (maior-menor)/k;
	aux = lst;

	for (i=0; i<k; i++){

		histograma.inferior = maior;
		histograma.superior = maior-h;
		histograma.frequency = 0;

		for( ; aux; aux=aux->next){
			if((histLst->dados.inferior < aux->dados.assurance) && (histLst->dados.superior > aux->dados.assurance)){
				(histograma.frequency)++;
			}
		}
		
		histLst = insertListHistograma(histLst, histograma);
		maior=maior - h;
	}
}
