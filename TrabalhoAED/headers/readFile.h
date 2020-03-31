#ifndef READFILE_H_
#define READFILE_H_

    #define readPath "files\\slate-tagged"
    #define readMethod "%s %s %s %f\n"

	typedef struct _dataList{
		char* original;
		char* root;
		char* morphology;
		float assurance;

		struct _dataList *next;
		struct _dataList *previous;
	}DataList;

    DataList *newList();
	DataList *insert();
	DataList *readFile();
	void showList(DataList* lst);

#endif