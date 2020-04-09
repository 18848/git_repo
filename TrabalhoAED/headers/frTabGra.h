#ifndef FRTABGRA_H_
#define FRTABGRA_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodTabGra " %s\t\t%d\t\t%lf\t    %d\t  %lf\n"

    /*structs*/
    typedef struct _tabGra
    {
      	char morphology[5];
      	int frequency;
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
	ListTabGra *orderTabGra (ListTabGra *lst, TabGra data);
	void showListTabGra (ListTabGra *lst, int total);

#endif