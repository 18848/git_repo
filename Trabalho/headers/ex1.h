#ifndef EX1_H_
#define EX1_H_

	#define readPath "files\\slate-tagged2"
	#define readMethod "%s %s %s %lf\n"
	#define MALLOC(t) (t*)malloc(sizeof(t))

	/*Estrutura de dados dos dados*/
	typedef struct _ex1
	{
		char original[100];
		char root[100];
		char morphology[5];
		double assurance;
	}Ex1;

	/*Estrutura de dados da lista*/
	typedef struct _dataListEx1{
		Ex1 var;
		struct _dataListEx1 *next;
	}DataListEx1;

	/*Funcoes*/
	DataListEx1 *newList1();
	DataListEx1 *insert1(DataListEx1 *lst, Ex1 value);
	DataListEx1 *readFile1();
	void showList1(DataListEx1* lst);

#endif