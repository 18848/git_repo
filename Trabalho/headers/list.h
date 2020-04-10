#ifndef LIST_H_
#define LIST_H_

    /*constantes*/
	#define MALLOC(t) (t*)malloc(sizeof(t))

    /*structs*/
    typedef struct _data
    {
		char original[100];
		char root[100];
		char morphology[5];
		double assurance;
    }Data;

    typedef struct _list
    {
        Data dados;
        struct _list *next;
    }List;

    /*Funcoes*/
    List *newList();
    List *insert (List *lst, Data data);
    List *orderLst (List *lst, Data data);

#endif