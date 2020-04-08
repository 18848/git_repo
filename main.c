#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define MALLOC(t)    (t*) malloc(sizeof(t))

/* Struct da lista de palavra que esta representada em cada linha do ficheiro */
typedef struct _word {
    char *original;
    char *source;
    char *type;
    double certain;

    struct _word *next;
} Word;

/* Struct da lista dos tipos de cada palavra (Coluna 3)*/
typedef struct _type
{
    char *type;  
    int quantity;
    float avg_sum;
    float desvio_sum;
    struct _type *next;    
} Type;

/* Struct da lista Do Nº de caracteres de cada palavra */
typedef struct _size_word
{
    int size;  
    int quantity;
    struct _size_word *next;    
} SizeWord;

typedef struct _list
{
    int value;
    struct _list *next; 
}List;

List* listInsert(List* lst,int value){
    List *new_cell= MALLOC(List);
    new_cell->value=value;
    new_cell->next=lst;
    return new_cell;
}

typedef struct _word_frequency {
    char *word;
    int quantity;

    struct _word_frequency *next;
} WordFrequency;

/* Insere um novo tipo na lista e inicializa-o com quantidade 1 */
Type* insert_type(Type* lst,char *type,float certain){
    Type *new_cell = MALLOC(Type);
    new_cell->type=strdup(type);
    new_cell->quantity=1;
    new_cell->avg_sum=certain;
    new_cell->desvio_sum=(float)certain*certain;
    new_cell->next=lst;
    return new_cell;
}

/* Procuar se ja existe esse tipo de palavra se existir aumenta e da return 1 caso coso contrario da return 0 */
int search_type(Type *lst, char *type,float certain){
   
    if(!lst)
    {
        return 0;
    }else
    {        

        if (strcmp(type, lst->type) == 0)
        {
            lst->quantity++;
            lst->avg_sum+=certain;
            lst->desvio_sum+=(float)certain*certain;
            return 1;
        }           
    }
    return search_type(lst->next,type,certain); 
    
}

void list_types(Type *lst)
{
    while (lst)
    {
        printf("%-6s  |  %6d\n",lst->type,lst->quantity);
        lst=lst->next;
    }    
}

void list_types_avg(Type *lst)
{
    float variancia;
    float avg;
    float avg_squared;
    float desvio_padrao;
    printf("%-6s  |  %-6s  |  %-6s  |\n","Tipo","Media","DP");
    printf("------------------------------------\n");
    while (lst)
    {
        avg=lst->avg_sum/lst->quantity;
        avg_squared=lst->desvio_sum/lst->quantity;
        variancia=avg_squared-((float)avg*avg);
        desvio_padrao=sqrt(variancia);
        printf("%-6s  |  %6f  |  %6f  |\n",lst->type,avg,desvio_padrao);
        lst=lst->next;
    }    
}

/* Faz uma inserção ordenada da lista Type */
Type* sorted_insert (Type* lst , int quantity, char *type, float avg_sum, float avg_square) {
    if (!lst || quantity < lst->quantity ) {
        Type* new = MALLOC(Type);
        new->quantity = quantity;
        new->type = strdup(type);
        new->avg_sum=avg_sum;
        new->desvio_sum=avg_square;
        new->next = lst;
        lst = new;
    }
    else {
        lst->next=sorted_insert(lst->next , quantity, type, avg_sum, avg_square);}
    return lst ;
}

/* Mostra a tabela de Frequencias da pergunta 2 */
void show_type_table(Type* lst, int total){
    int Ni=0;
    printf("%d\n",total);
    printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    printf("%-6s  |  %-7s  |  %-7s  |  %-8s  |  %-8s  |\n","Type","ni","Ni","fi","Fi");
    printf("-----------------------------------------------------------\n");

    
    while (lst)
    {
        Ni+=lst->quantity;
        printf("%-6s  |  %7d  |  %7d  |  %f  |  %f  |\n",lst->type,lst->quantity,Ni,(float)lst->quantity/total,(float)Ni/total);
        lst=lst->next;
    }
}

/* Insere um novo Tamanho na lista e inicializa-o com quantidade 1 */
SizeWord* insert_size_word(SizeWord* lst,int size){
    SizeWord *new_cell = MALLOC(SizeWord);
    new_cell->size=size;
    new_cell->quantity=1;
    new_cell->next=lst;
    return new_cell;
}

/* Procuar se ja existe esse tamanho de palavra se existir aumenta e da return 1 caso coso contrario da return 0 */
int search_size_word(SizeWord *lst, int size){
   
    if(!lst)
    {
        return 0;
    }else
    {        

        if (size == lst->size)
        {
            lst->quantity++;
            return 1;
        }           
    }
    return search_size_word(lst->next,size); 
    
}

void list_size_words(SizeWord *lst)
{
    while (lst)
    {
        printf("%-6d  |  %6d\n",lst->size,lst->quantity);
        lst=lst->next;
    }    
}

/* Faz uma inserção ordenada da lista Type */
SizeWord* sorted_insert_size_word (SizeWord* lst , int quantity, int size) {
    if (!lst || size < lst->size) {
        SizeWord* new = MALLOC(SizeWord);
        new->quantity = quantity;
        new->size = size;
        new->next = lst;
        lst = new;
    }
    else {
        lst->next=sorted_insert_size_word(lst->next , quantity, size);}
    return lst ;
}

/* Mostra a tabela de Frequencias da pergunta 2 */
void show_size_word_table(SizeWord* lst, int total){
    int Ni=0;
    printf("%d\n",total);
    printf("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    printf("%-6s  |  %-7s  |  %-7s  |  %-8s  |  %-8s  |\n","Tamanho","ni","Ni","fi","Fi");
    printf("-----------------------------------------------------------\n");

    
    while (lst)
    {
        Ni+=lst->quantity;
        printf("%-6d  |  %7d  |  %7d  |  %f  |  %f  |\n",lst->size,lst->quantity,Ni,(float)lst->quantity/total,(float)Ni/total);
        lst=lst->next;
    }
}

void tarefa5(SizeWord* lst, int total){
    float avg_sum=0;
    float avg_square_sum=0;
    float avg;
    float avg_squared;
    List* moda=NULL;
    int moda_quantity=-1;
    int variancia;
    int flag=0;
    int sum=0;




    while(lst)
    {
        sum+=lst->quantity;
        avg_sum+=lst->quantity*lst->size;
        avg_square_sum+=lst->quantity*(lst->size*lst->size);
        if(flag==0 && sum>=(total/2)){
            printf("%d>=%f",sum,(float)total/2);
            printf("Mediana: %d\n",lst->size);
            flag++;
        }

        if(lst->quantity>moda_quantity){
            moda_quantity=lst->quantity;
            moda=NULL;
            moda=listInsert(moda,lst->size);
        }
        if(lst->quantity==moda){
            moda=listInsert(moda,lst->size);
        }
        lst=lst->next;
    }
    printf("Media:%f\n",avg_sum/total);
    printf("Moda:");
    while (moda)
    {
        printf("%d ",moda->value);
        moda=moda->next;
    }
    avg=avg_sum/total;
    avg_squared=avg_square_sum/total;
    variancia=avg_squared-((float)avg*avg);
    printf("\nDesvio Padrão:%f\n",sqrt(variancia));  
}

int search_wordFrequency(WordFrequency *lst, char* word){
   
    if(!lst)
    {
        return 0;
    }else
    {        

        if (strcmp(word,lst->word)==0)
        {
            lst->quantity++;
            return 1;
        }           
    }
    return search_wordFrequency(lst->next,word); 
    
}

WordFrequency* insert_wordFrequency (WordFrequency* lst , char* word) {
        WordFrequency* new = MALLOC(WordFrequency);
        new->quantity = 1;
        new->word = strdup(word);
        new->next = lst;    
        return new ;
}

WordFrequency* sorted_insert_wordFrequency (WordFrequency* lst , char* word) {
    if (!lst || strcmp(word,lst->word)<0) {
        WordFrequency* new = MALLOC(WordFrequency);
        new->quantity = 1;
        new->word = strdup(word);
        new->next = lst;
        lst = new;
    }
    else {
        lst->next=sorted_insert_wordFrequency(lst->next , word);}
    return lst ;
}

WordFrequency* sorted_insert_wordFrequency2(WordFrequency* lst , char* word){
    WordFrequency* new= MALLOC(WordFrequency);
    new->word=strdup(word);
    new->quantity=1;
    if (!lst || strcmp(new->word,lst->word)<0)
    {
        new->next=lst;
        lst=new;
    }else
    {
        WordFrequency *aux= lst;
        while (aux->next && strcmp(new->word,aux->next->word)>0)
        {
            aux=aux->next;
            new->next=aux->next;
            aux->next=new;
        }
        return lst;        
    }    
}

void listWordsFrequency(WordFrequency* lst){
    while (lst)
    {
        printf("\n%s %d",lst->word,lst->quantity);
        lst=lst->next;
    }    
}


#define FILE_NAME "slate-tagged"
#define READ_LINE "%s %s %s %lf\n"


int main()
{
    // Declaração de variáveis
    char original[100];
    char source[100];
    char type[5];
    double certain;
    Word word;
    FILE *ficheiro;
    int i = 0;
    int count=0;
    Type *type_lst=NULL;
    Type *sorted_type_lst=NULL;
    SizeWord *sizeWord_lst=NULL;
    SizeWord *sorted_sizeWord_lst=NULL;
    WordFrequency *sorted_wordFrequency_list=NULL;
    int total_palavras=0;

    
    ficheiro = fopen(FILE_NAME, "r+");

    if (ficheiro == NULL)
    {
        i = -1;
        return i;
    }    
    
    rewind(ficheiro);



    while (fscanf(ficheiro, READ_LINE,
                  original, source, type, &certain
                  ) != EOF)
    {        
        if(type[0]!='F'){
            
            total_palavras++;
            /* if(total_palavras%100000==0){
                system("cls");
                printf("\n%.10f %%\n",((float)total_palavras/4276471)*100);
            }    */         
            if(!search_type(type_lst,type,certain)){type_lst=insert_type(type_lst,type,certain);}
            if(!search_size_word(sizeWord_lst,strlen(original))){sizeWord_lst=insert_size_word(sizeWord_lst,strlen(original));}
            if(!search_wordFrequency(sorted_wordFrequency_list,original)){sorted_wordFrequency_list=insert_wordFrequency(sorted_wordFrequency_list,original);}                  
        }        
    }
     while (type_lst){
        sorted_type_lst=sorted_insert(sorted_type_lst,type_lst->quantity,type_lst->type, type_lst->avg_sum,type_lst->desvio_sum);
        type_lst=type_lst->next;
    } 
     while (sizeWord_lst){
        sorted_sizeWord_lst=sorted_insert_size_word(sorted_sizeWord_lst,sizeWord_lst->quantity,sizeWord_lst->size);
        sizeWord_lst=sizeWord_lst->next;
    } 
    
    system("pause"); 
    system("pause"); 
    system("pause"); 
    system("cls");
    show_size_word_table(sorted_sizeWord_lst,total_palavras);
    printf("\n\n\n");
    show_type_table(sorted_type_lst,total_palavras);
    printf("\n\n\n");
    list_types_avg(sorted_type_lst);
     printf("\n\n\n");
    tarefa5(sorted_sizeWord_lst,total_palavras);
    printf("\n\n\n");
    //listWordsFrequency(sorted_wordFrequency_list);
    system("pause");    
    fclose(ficheiro);
}
