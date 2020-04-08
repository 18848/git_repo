#ifndef FRTABGRA_H_
#define FRTABGRA_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodTabGra "%-5s %d\n"

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
		struct _listTabGra *previous;
    }ListTabGra;

    /*Funcoes*/
	ListTabGra *newListTabGra();
	ListTabGra * insertListTabGra (ListTabGra *lst, TabGra data);
	ListTabGra *existsTabGra (ListTabGra *lstTG, TabGra data);
	void showListTabGra (ListTabGra *lst);
	void show(ListTabGra *lst);

#endif