#ifndef FRTABPAL_H_
#define FRTABPAL_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodTabPal " %d\t\t%d\t\t%lf\t    %d\t  %lf\n"
    #define writeMethodTabPalCalc "Media: %lf\nMediana %f\nModa: %d\nDesvio Padrao: %lf\n"

    /*structs*/
    typedef struct _tabPal
    {   
        int size;
      	int frequency;
    }TabPal;

    typedef struct _listTabPal
   	{
		TabPal dados;
		struct _listTabPal *next;
    }ListTabPal;

    /*Funcoes*/
	ListTabPal *newListTabPal();
	ListTabPal * insertListTabPal (ListTabPal *lst, TabPal data);
	ListTabPal *existsTabPal (ListTabPal *lstTG, TabPal data);
    int countTabPal (char word[]);
	void showListTabPal (ListTabPal *lst, int total);
    void calculateMesuresTabPal(ListTabPal *lst, int total);

#endif