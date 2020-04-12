#ifndef HISTOGRAMA_H_
#define HISTOGRAMA_H_

	#include "list.h"

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodHistograma "[%lf; %lf[ -> %d\n"

    /*structs*/
    typedef struct _histograma
    {
		double inferior;
		double superior;
		int frequency;
    }Histograma;

    typedef struct _listHistograma
   	{
		Histograma dados;
		struct _listHistograma *next;
    }ListHistograma;

    /*Funcoes*/
	ListHistograma *newListHistograma();
	ListHistograma * insertListHistograma (ListHistograma *lst, Histograma data);
	void showListHistograma (ListHistograma *lst);
	ListHistograma *histograma(List *lst, int count);

#endif