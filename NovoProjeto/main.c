#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "list.h"
#include "readFile.h"
#include "frTabGra.h"

int main(){
    List *lst;
    ListTabGra *lstTabGra = newListTabGra();

    lst = readFile(lstTabGra);
    showList(lst);
    puts("\n\tfile read ");
    system("pause");

    puts("\n\t table below ");
	showListTabGra(lstTabGra);
    puts("\n\t table above ");
    system("pause");
    return 0;
}

/*To do:
- Nao está a correr a parte das tabelas (crasha)
*/