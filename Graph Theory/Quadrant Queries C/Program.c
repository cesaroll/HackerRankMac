#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

#define OpX 'X'
#define OpY 'Y'
#define OpC 'C'

int main() {

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */    

    //printf("Number of points: ");

    int n;
    scanf("%d", &n);

    int points[n][2];

    //printf("\nEnter points\n");
    for(int i=0; i<n; i++) {
        scanf("%d %d", &points[i][0], &points[i][1]);
    }

    /*
    for(int i=0; i<n; i++) {
        printf("%d %d\n", points[i][0], points[i][1]);
    }*/

    //printf("\n\nEnter Operations number: ");

    int opNum;
    scanf("%d", &opNum);

    //char opTypes[opNum];
    //int opValues[opNum][2];
    char opType;
    int init;
    int end;

    //printf("\nEnter operations\n");
    fflush(stdin);
    for(int i=0; i<opNum; i++) {
        //scanf(" %c %d %d", &opTypes[i], &opValues[i][0], &opValues[i][1]);
        scanf(" %c %d %d", &opType, &init, &end);
        
        init--;
        end--;

        //printf("\n%c %d %d\n", opType, init, end);

        if(opType == OpX || opType == OpY) {

            int id = 0;

            if(opType == OpX)
                id = 1;
            
            for(int i = init; i <= end; i++) {
                points[i][id] *= -1;
            }

        } else if(opType == OpC) {

            int Quad[] = {0,0,0,0};

            for(int i = init; i <= end; i++) {
                
                int x = points[i][0];
                int y = points[i][1];
                int q;



                if(x > 0) {
                    if(y>0)
                        q=0;
                    else
                        q=3;
                } else {
                    if(y>0)
                        q=1;
                    else
                        q=2;
                }

                Quad[q]++;

                //printf("\nQ: %d\n", q);

            }

            for(int i=0; i<4; i++) {
                printf("%d ", Quad[i]);
            }
            printf("\n");

        }
    }


    //printf("\n");
    //printf("%c %d %d\n", opType, opValues[0], opValues[1]);

    /*
    for(int i=0; i<opNum; i++) {
        printf("%c %d %d\n", opTypes[i], opValues[i][0], opValues[i][1]);
    }*/



    return 0;
}
