all: Program

Program: main.o list.o frTabGra.o frTabPal.o histograma.o countPal.o
	gcc -g -o Program main.o list.o frTabGra.o frTabPal.o histograma.o countPal.o

main.o: main.c

list.o: main.c
	gcc -g -o main.o main.c -c -W -Wall -ansi -pedantic

frTabGra.o: frTabGra.c frTabGra.h
	gcc -g -o frTabGra.o frTabGra.c -c -W -Wall -ansi -pedantic

frTabPal.o: frTabPal.c frTabPal.h
	gcc -g -o frTabPal.o frTabPal.c -c -W -Wall -ansi -pedantic

histograma.o: histograma.c histograma.h
	gcc -g -o histograma.o histograma.c -c -W -Wall -ansi -pedantic

countPal.o: countPal.c countPal.h
	gcc -g -o countPal.o countPal.c -c -W -Wall -ansi -pedantic