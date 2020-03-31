#ifndef READFILE_H_
#define READFILE_H_

//    #define readPath "files\\slate-tagged"
    #define readPath "C:\\codigo\\files\\slate-tagged"
    #define readMethod "%s %s %s %lf\n"

	typedef struct ReadPath{
		char* original;
		char* root;
		char* morphology;
		double assurance;
		struct ReadPath *next;
		struct ReadPath *previous;

	}ReadPath;

    ReadPath *newList();
	ReadPath *insert(ReadPath *lst, ReadPath *value);
	ReadPath *readFile();
	void showList(ReadPath *lst);

#endif