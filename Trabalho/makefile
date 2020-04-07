all: audit

audit: auditoria.o
	gcc -g -o audit auditoria.o

auditoria.o: auditoria.c
	gcc -g -o auditoria.o auditoria.c -c -W -Wall -ansi -pedantic

clean:
	del /Q /S *.o *~ audit
