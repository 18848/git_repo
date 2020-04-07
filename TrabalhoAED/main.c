#include "stdlib.h"
#include "stdio.h"
#include "conio.h"
#include "string.h"

#include "headers\readFile.h"

int main(){
    DataList* lst = newList();

    insert(lst);
    showList(lst);

    system("pause");
    return 0;
}