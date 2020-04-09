#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "headers/list.h"
#include "headers/readFile.h"
#include "headers/frTabGra.h"

int main(){

    /*Listas*/
    List *lst = newList();
    ListTabGra *lstTabGra = newListTabGra();

    /*Structs*/
    Data data;
    TabGra tabGra;

    /*Vars*/
    FILE *fp;
    int countList=0;
    
    fp=fopen(filePath, "r");

    while(fscanf(fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){

        if(data.morphology[0] != 'F'){
            lst = insert(lst, data);
            
            strcpy(tabGra.morphology, data.morphology);
            lstTabGra = existsTabGra(lstTabGra, tabGra);

            countList++;
        }
    }   
    fclose(fp);

    /*Ex2------------------------------------------------------------------------------------------*/

    printf("%-10s\t%-10s\t%-10s\t%-12s\t%-12s\n", "Cat Gram", "Freq Abs", "Freq Rel", "Freq Abs Ac", "Freq Rel Ac");
	showListTabGra(lstTabGra, countList);
    printf("  Total\t\t  %d\t\t    1 \t\t    %d\n", countList, countList);
    system("pause");
    /*---------------------------------------------------------------------------------------------*/
    
    return 0;
}