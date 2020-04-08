#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"

#include "headers\Ex1.h"
#include "headers\Ex2.h"

int main(){
    int count=0;

    DataListEx1* lst1 = newList1();
    DataListEx2* lst2 = newList2();

/* Carregamento dos dados para lista */
    lst1 = readFile1(&count);
    /* showList1(lst1); */

/* Total de linhas lidas 
    printf("\t%d\n\n", count); */

/* Criacao de lista */
    lst2 = table2(lst1, lst2);
    showList2(lst2);

    system("pause");
    return 0;
}