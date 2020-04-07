#ifndef READFILE_H_
#define READFILE_H_

	#define readPath "files\\slate-tagged2"
	#define readMethod "%s %s %s %lf\n"
	#define MALLOC(t) (t*)malloc(sizeof(t))

	/*Estrutura de dados dos dados*/
	typedef struct _data
	{
		char original[100];
		char root[100];
		char morphology[5];
		double assurance;
	}Data;

	/*estrutura de dados da lista*/
	typedef struct _dataList{
		Data var;
		struct _dataList *next;
	}DataList;


	DataList *newList();
	DataList *insert(DataList *lst, Data value);
	DataList *readFile();
	void showList(DataList* lst);

#endif