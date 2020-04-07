#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"

#include "headers\readFile.h"

int main(){
    int count=0;

    DataList* lst = newList();

    lst = readFile(&count);
    showList(lst);

    printf("\t%d\n\n", count);

    system("pause");
    return 0;
}