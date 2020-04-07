#ifndef TableThirdCol_H_
#define TableThirdCol_H_

	#define readMethod "%s %s %s %lf\n"
	#define MALLOC(t) (t*)malloc(sizeof(t))

	/*Estrutura de dados dos dados*/
	typedef struct _tableThirdCol
	{
		char morphology[5];
		double absolut;
	}TableThirdCol;

#endif