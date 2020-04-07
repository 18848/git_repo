#ifndef EX2_H_
#define EX2_H_

	/*Estrutura de dados dos dados*/
	typedef struct _ex2
	{
		char morphology[5];
		int absolut;
	}Ex2;

	/*Estrutura de dados da lista*/
	typedef struct _dataListEx2{
		Ex2 var;
		struct _dataListEx2 *next;
	}DataListEx2;

	/*Funcoes*/
	DataListEx2 *newList2();
	DataListEx2 *insert2(DataListEx1 *lst, DataListEx2 *old);
	DataListEx2* search2 (DataListEx1 *lst, char value[]);
	void showList2(DataListEx2* lst);

#endif