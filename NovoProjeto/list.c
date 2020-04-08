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
    List *new = newList();

    FILE *fp;
    Data data;
    TabGra tabGra;
    #pragma endregion

    #pragma region "reading file"
    
    fp=fopen(filePath, "r");
	rewind(fp);
    while(fscanf(fp, readMethod, data.original, data.root, data.morphology, &data.assurance) != EOF){

        if(data.morphology[0] != 'F'){
            new = insert(new, data);
            #pragma region "tabela gramatical"
            strcpy(tabGra.morphology, data.morphology);
            if(!existsTabGra(lstTabGra, tabGra)) { 
	printf(writeMethodTabGra, lstTabGra->dados.morphology, lstTabGra->dados.frequency);
				
				lstTabGra = insertListTabGra(lstTabGra, tabGra); }
		}
	}
    fclose(fp);
    #pragma endregion

    return(new);
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