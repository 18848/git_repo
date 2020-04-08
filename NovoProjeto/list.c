#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include "string.h"
#include "list.h"
#include "readFile.h"
#include "frTabGra.h"

/*Listas duplamente ligadas*/
/*new list*/
List *newList(){
    List *tmp = MALLOC(List);
    tmp = NULL;
    return tmp;
}

/*read file*/
List *readFile(ListTabGra *lstTabGra)
{
    #pragma region "variables"
    List *lst = newList();

    FILE *fp;
    Data data;
    TabGra tabGra;
    #pragma endregion

    #pragma region "reading file"
    
    fp=fopen(filePath, "r");
    while(fscanf(fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){

        if(data.morphology[0] != 'F'){
            lst = insert(lst, data);
            #pragma region "tabela gramatical"
            strcpy(tabGra.morphology, data.morphology);
            lstTabGra = existsTabGra(lstTabGra, tabGra);
            #pragma endregion
        }
    }
    fclose(fp);
    #pragma endregion

    return(lst);
}

/*head insert*/
List *insert (List *lst, Data data){
    List *tmp = MALLOC(List);

    tmp->dados = data;
    tmp->next = lst;

    if(tmp->next)
    {
        tmp->next->previous = tmp;
        tmp->previous = NULL;
    }

    return tmp;
}

/*Apresentacao da lista*/
void showList (List *lst){

    if (lst->next){
        showList(lst->next);
        printf(writeMethod, lst->dados.original, lst->dados.root, lst->dados.morphology, lst->dados.assurance);
    }
}