all: Program

Program: main.o list.o frTabGra.o frTabPal.o histograma.o countPal.o
	gcc -g -o Program main.o list.o frTabGra.o frTabPal.o histograma.o countPal.o

main.o: main.c headers\readFile.h headers\list.h headers\histograma.h headers\frTabPal.h headers\frTabGra.h headers\countPal.h
	gcc -g -o main.o main.c -c -W -Wall -ansi -pedantic

list.o: list.c headers\list.h
	gcc -g -o list.o list.c -c -W -Wall -ansi -pedantic

frTabGra.o: frTabGra.c headers\frTabGra.h
	gcc -g -o frTabGra.o frTabGra.c -c -W -Wall -ansi -pedantic

frTabPal.o: frTabPal.c headers\frTabPal.h
	gcc -g -o frTabPal.o frTabPal.c -c -W -Wall -ansi -pedantic

histograma.o: histograma.c headers\histograma.h
	gcc -g -o histograma.o histograma.c -c -W -Wall -ansi -pedantic

countPal.o: countPal.c headers\countPal.h
	gcc -g -o countPal.o countPal.c -c -W -Wall -ansi -pedantic

clean:
	del /Q /S *.o *~ *Program