#ifndef FRTABGRA_H_
#define FRTABGRA_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodTabGra " %s\t\t%-8d\t%-8lf\t%-8d\t%lf\n"
	#define writeMethodTabGraCalc " %s\t       %lf\t\t  %lf\n"

    /*structs*/
    typedef struct _tabGra
    {
      	char morphology[5];
      	int frequency;
		double assurance;
		double variance;
		//assurance/frequency
    }TabGra;

    typedef struct _listTabGra
   	{
		TabGra dados;
		struct _listTabGra *next;
    }ListTabGra;

    /*Funcoes*/
	ListTabGra *newListTabGra();
	ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data);
	ListTabGra *existsTabGra (ListTabGra *lstTG, TabGra data);
	ListTabGra *orderTabGra (ListTabGra *lst, TabGra data, int *flag);
	void showListTabGra (ListTabGra *lst, int total);
	void calculateMesuresTabGra(ListTabGra *lst, int total);

#endif