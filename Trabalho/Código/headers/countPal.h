#ifndef COUNTPAL_H_
#define COUNTPAL_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))
	#define writeMethodCountPal "%s %d\n"
    #define writeMethodCountPalCalc "\n\nQuartil: %d\n"
    #define errorMessage "\n\nA palavra %s nao existe!\n"

    /*structs*/
    typedef struct _countPal
    {   
		char original[100];
    	int frequency;
    }CountPal;

    typedef struct _listCountPal
   	{
		CountPal dados;
		struct _listCountPal *next;
    }ListCountPal;

    /*Funcoes*/
    ListCountPal *newListCountPal();
    ListCountPal * insertListCountPal (ListCountPal *lst, CountPal data);
    ListCountPal *existsCountPal (ListCountPal *lst, CountPal data);
    ListCountPal *orderCountPal (ListCountPal *lst, CountPal data);
    void calculateQuartilCountPal (ListCountPal *lst, int total, char word[]);
#endif