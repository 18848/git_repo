#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"

#include "headers\Ex1.h"
#include "headers\Ex2.h"

int main(){
    int count=0;

    DataListEx1* lst1 = newList1();

    lst1 = readFile1(&count);
    showList1(lst1);

    printf("\t%d\n\n", count);

    system("pause");
    return 0;
}