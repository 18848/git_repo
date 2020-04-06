#ifndef READFILE_H_
#define READFILE_H_

    #define readPath "files\\slate-tagged"
    #define readMethod "%s %s %s %lf\n"

	//Estrutura dos dados
	typedef struct _data
	{
		char* original;
		char* root;
		char* morphology;
		double assurance;
	}Data;
	
	//Lista
	typedef struct _dataList{
		Data var;

		struct _dataList *next;
		struct _dataList *previous;
	}DataList;

    DataList *newList();
	DataList *insert();
	DataList *readFile();
	void showList(DataList* lst);

#endif