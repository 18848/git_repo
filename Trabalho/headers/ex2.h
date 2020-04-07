#ifndef Ex2_H_
#define Ex2_H_

	/*Estrutura de dados dos dados*/
	typedef struct _ex2
	{
		char morphology[5];
		double absolut;
	}Ex2;

	/*estrutura de dados da lista*/
	typedef struct _dataListEx2{
		Ex2 var;
		struct _dataListEx2 *next;
	}DataListEx2;

#endif