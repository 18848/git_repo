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

	for ( ; lst; lst=lst->next){
		printf(writeMethodHistograma, lst->dados.inferior, lst->dados.superior, lst->dados.frequency);
	}
}

ListHistograma *histograma(List *lst, int count){
	ListHistograma *histLst = newListHistograma();
	List *aux = lst;

	Histograma histograma;

	int k = 1+log(count)/log(2), i;
	
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

	for (i=k; i>0; i--){

		histograma.superior = maior;
		histograma.inferior = maior-h;
		histograma.frequency = 0;

		for(aux=lst ; aux; aux=aux->next){
			
			if(i==1){
				histograma.inferior = menor;

				if((histograma.inferior <= aux->dados.assurance) && (histograma.superior >= aux->dados.assurance)){
				(histograma.frequency)++;
				}
			}
			else if(i==k){
				if((histograma.inferior <= aux->dados.assurance) && (histograma.superior >= aux->dados.assurance)){
				(histograma.frequency)++;
				}
			}
			else{
				if((histograma.inferior <= aux->dados.assurance) && (histograma.superior > aux->dados.assurance)){
					(histograma.frequency)++;
				}
			}
		}
		histLst = insertListHistograma(histLst, histograma);
		maior=maior - h;
	}
	return histLst;
}
