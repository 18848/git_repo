#include "time.h"
	
	clock_t begin = clock();

	/* here, do your time-consuming job */

    clock_t end = clock();
    double time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
    printf("\ttime: %lf\n", time_spent);